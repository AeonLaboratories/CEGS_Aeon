using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using System.Media;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using Utilities;
using HACS.Components;
using System.Collections;
using System.Text;
using HACS.Components.Controls;
using HACS.Core;

namespace CEGS_Aeon_Namespace
{
	public partial class UserInterface : Form
    {
        #region fields

        static Properties.Settings Settings = Properties.Settings.Default;

		// These objects are used to handle actions taken on request 
		// (e.g., to update UI elements that aren't automatically updated 
		// every UpdateTimer tick).
		static Queue<ObjectPair> requestQ = new Queue<ObjectPair>();
		static Thread responseThread;
		static ManualResetEvent requestSignal = new ManualResetEvent(false);

		// sound
		SoundPlayer soundPlayer;

        #endregion fields

        public CEGS_Aeon CEGS = new CEGS_Aeon();
        public bool Initialized { get; set; }
        bool UIClosing = false;
        TreeNode DeviceTree = new TreeNode("root");

        public UserInterface()
        {
            Initialized = false;
            InitializeComponent();          // Form elements
            StackControls();
            SetSubMenuImageMargins();
            InitializeSound();

			StartCEGS();
			if (UIClosing) Close();

			PopulateDropDowns();
			PopulateDevicePage();

			// link controls before initializing CEGS system components,
			// so devices can display their status as they are initialized
			LinkControls();
		}

		void StackControls()
        {
            DiagramPictureBox.Controls.Add(IMPictureBox);
            DiagramPictureBox.Controls.Add(IPPictureBox);
            DiagramPictureBox.Controls.Add(VttLPictureBox);
            DiagramPictureBox.Controls.Add(VttPictureBox);
            DiagramPictureBox.Controls.Add(VttRPictureBox);
            DiagramPictureBox.Controls.Add(CuAgPictureBox);
            DiagramPictureBox.Controls.Add(MCUPictureBox);
            DiagramPictureBox.Controls.Add(MCPictureBox);
            DiagramPictureBox.Controls.Add(MCLPictureBox);
            DiagramPictureBox.Controls.Add(SplitPictureBox);
            DiagramPictureBox.Controls.Add(GMPictureBox);
            DiagramPictureBox.Controls.Add(GR1PictureBox);
            DiagramPictureBox.Controls.Add(GR2PictureBox);
            DiagramPictureBox.Controls.Add(GR3PictureBox);
            DiagramPictureBox.Controls.Add(GR4PictureBox);
            DiagramPictureBox.Controls.Add(GR5PictureBox);
            DiagramPictureBox.Controls.Add(GR6PictureBox);
            //DiagramPictureBox.Controls.Add(BPPictureBox);
            DiagramPictureBox.Controls.Add(d13CPictureBox);
            DiagramPictureBox.Controls.Add(VPVPictureBox);
            DiagramPictureBox.Controls.Add(d13CCFPictureBox);
            DiagramPictureBox.Controls.Add(VMPictureBox);
        }

        void UpdateField(object o, string propertyName, object value)
        {
            o.GetType().GetField(propertyName).SetValue(o, value);
        }

        void UpdateProperty(object o, string propertyName, object value)
        {
            o.GetType().GetProperty(propertyName).SetValue(o, value, null);
        }

        void StartCEGS()
        {
            string settingsFileName = @"settings.xml";
            tryCEGS(settingsFileName);
            if (CEGS == null)
            {
                if (MessageBox.Show(
                        "Invalid or missing settings file.\r\nUse backup?",
                        Text + " - Warning",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning)
                    != DialogResult.OK)
                {
                    UIClosing = true;
                    return;
                }

                tryCEGS(settingsFileName.Replace(".xml", ".backup.xml"));
                if (CEGS == null)
                {
                    if (MessageBox.Show(
                            "Invalid or missing backup settings.\r\nUse default?",
                            Text + " - Warning",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning)
                        != DialogResult.OK)
                    {
                        UIClosing = true;
                        return;
                    }

                    tryCEGS(settingsFileName.Replace(".xml", ".default.xml"));
                    if (CEGS == null)
                    {
                        MessageBox.Show(
                            "Invalid or missing default settings. Exiting.",
                            Text + " - Fatal Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        UIClosing = true;
                        return;
                    }
                }
            }

            Text = CEGS.SystemName;
            CEGS.SettingsFilename = settingsFileName;
			CEGS.RequestService += RequestService;
			CEGS.MessageHandler.OnMessage = messageHandler;
			CEGS.VerifySampleInfo = verifySampleInfo;
			CEGS.ShowProcessSequenceEditor = showProcessSequenceEditor;
			CEGS.PlaySound = PlaySound;
			CEGS.Start();
        }

        void tryCEGS(string settingsFile)
        {
            try
            {
                TextReader reader = new StreamReader(@"settings.xml");
                CEGS = (CEGS_Aeon)(new XmlSerializer(typeof(CEGS_Aeon))).Deserialize(reader);
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); CEGS = null; }
        }

        void UserInterface_Load(object sender, EventArgs e)
        {
            Location = Settings.FormLocation;
            Size = Settings.FormSize;

            ClipPressure(Settings.ClipPressure);
            ClipTemperature(Settings.ClipTemperature);
            DevicePopupsCheckBox.Checked = Settings.DevicePopups;
        }

        void UserInterface_Shown(object sender, EventArgs e)
        {
			// This thread updates UI elements that are serviced
			// only on request (i.e., they aren't automatically updated 
			// every UpdateTimer tick).
			responseThread = new Thread(respondToRequests);
			responseThread.Name = "UI updateThread";
			responseThread.IsBackground = true;
			responseThread.Start();

			// this just initializes the CEGS system components, 
			// not the overall system state
			CEGS.StartInitializing();
			InitializeControlContents();

			UpdateTimer.Start();
			Initialized = true;		// UserInterface is ready to go

			tryToStartSelectedProcess();        // intialize CEGS
        }

        void UserInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UIClosing) return;
            UIClosing = true;
            UpdateTimer.Stop();

            // These settings are not "bound" to a control
            Settings.ClipPressure = ClipPressureCheckBox.Checked;
            Settings.ClipTemperature = ClipTemperatureCheckBox.Checked;
            Settings.DevicePopups = DevicePopupsCheckBox.Checked;

            // remember these settings only on exit
            Settings.FormLocation = Location;
            Settings.FormSize = (WindowState == FormWindowState.Normal) ?
                Size : RestoreBounds.Size;

            Settings.Save();

            CEGS.ShutDown();
        }

        void SetSubMenuImageMargins()
        {
            // image margins for context sub-menus must be disabled programmatically
            //((ToolStripDropDownMenu)GRForceStateMenuItem.DropDown).ShowImageMargin = false;
        }

        void LinkControls()
        {
            #region visibility links
            // Clicking on one of these controls alternately shows or hides
            // the control stored in the Tag.
            p_VMLabel.Tag = VM_Gauges_Panel;
            VMPressurePictureBox.Tag = VM_Gauges_Panel;
            GR1PictureBox.Tag = GR1_panel;
            GR2PictureBox.Tag = GR2_panel;
            GR3PictureBox.Tag = GR3_panel;
            GR4PictureBox.Tag = GR4_panel;
            GR5PictureBox.Tag = GR5_panel;
            GR6PictureBox.Tag = GR6_panel;
            VttPictureBox.Tag = VttPanel;
            CuAgPictureBox.Tag = CEGS.ftc_CuAg;
            VPVPictureBox.Tag = CEGS.ftc_VP;
            d13CCFPictureBox.Tag = CEGS.ftc_d13C;
            #endregion visibility links

            #region focus links
            // Clicking on one of these controls shows and shifts the focus to
            // the control stored in the Tag.
            t_CC_S.Tag = sp_CC_S;
            t_VTT.Tag = sp_VTT;
            t_GR1_F.Tag = sp_GR1_F;
            t_GR2_F.Tag = sp_GR2_F;
            t_GR3_F.Tag = sp_GR3_F;
            t_GR4_F.Tag = sp_GR4_F;
            t_GR5_F.Tag = sp_GR5_F;
            t_GR6_F.Tag = sp_GR6_F;
            t_FTC_air.Tag = sp_FTC_air;
            #endregion focus links

            #region Link Label-type device state indicators to their devices
            IP_StateLabel.Tag = CEGS.IP;
            VP_StateLabel.Tag = CEGS.VP;
            //BP_StateLabel.Tag = CEGS.BP;
            #endregion Link Label-type device state indicators to their devices

            #region Link non-Gauge value displays to underlying meter
            #endregion Link non-Gauge value displays to underlying meter

            #region Link heater indicators to heaters
            d_CuAg_F.Tag = CEGS.h_CuAg;
            d_CC_Q.Tag = CEGS.h_CC_Q;
            d_CC_S2.Tag = CEGS.h_CC_S2;
            d_FTC_air.Tag = CEGS.h_FTC_air;

            d_GR1_F.Tag = CEGS.h_GR[0];
            d_GR2_F.Tag = CEGS.h_GR[1];
            d_GR3_F.Tag = CEGS.h_GR[2];
            d_GR4_F.Tag = CEGS.h_GR[3];
            d_GR5_F.Tag = CEGS.h_GR[4];
            d_GR6_F.Tag = CEGS.h_GR[5];
            #endregion Link heater indicators to heaters

            #region Link setpoint textbox controls to controlled devices
            sp_CC_S.Tag = CEGS.h_CC_S;
            sp_VTT.Tag = CEGS.h_VTT;
            sp_FTC_air.Tag = CEGS.h_FTC_air;
            sp_GR1_F.Tag = CEGS.h_GR[0];
            sp_GR2_F.Tag = CEGS.h_GR[1];
            sp_GR3_F.Tag = CEGS.h_GR[2];
            sp_GR4_F.Tag = CEGS.h_GR[3];
            sp_GR5_F.Tag = CEGS.h_GR[4];
            sp_GR6_F.Tag = CEGS.h_GR[5];
            #endregion Link setpoint textbox controls to controlled devices

            #region Link FTC temperature displays to FTC
            t_GR1_CF.Tag = CEGS.ftc_GR[0];
            t_GR2_CF.Tag = CEGS.ftc_GR[1];
            t_GR3_CF.Tag = CEGS.ftc_GR[2];
            t_GR4_CF.Tag = CEGS.ftc_GR[3];
            t_GR5_CF.Tag = CEGS.ftc_GR[4];
            t_GR6_CF.Tag = CEGS.ftc_GR[5];
            t_MC_CF.Tag = CEGS.ftc_MC;
            t_CuAg_CF.Tag = CEGS.ftc_CuAg;
            t_VP.Tag = CEGS.ftc_VP;
            t_VTT_CF.Tag = CEGS.ftc_VTT;
            t_d13C_CF.Tag = CEGS.ftc_d13C;
            #endregion Link FTC temperature displays to FTC

            #region Link FTC controls to FTC
            #endregion Link FTC controls to FTC

            #region Link Tank controls to tank
            t_tank.Tag = CEGS.LN_Tank;
            d_LN_Tank.Tag = CEGS.LN_Tank;
            LNTankLabel.Tag = CEGS.LN_Tank;
            #endregion Link Tank controls to tank

            #region Link VTT controls to VTT
            VttPanel.Tag = CEGS.VTT;
            #endregion Link VTT controls to VTT

            #region AnalogIO
            p_MC.Connect(CEGS.m_p_MC);
            p_Foreline.Connect(CEGS.m_p_Foreline);
            p_VM_HP.Connect(CEGS.m_p_VM_HP);
            p_VM_IG.Connect(CEGS.m_p_VM_IG);
            p_IM.Connect(CEGS.m_p_IM);
            p_VTT.Connect(CEGS.m_p_VTT);
            p_GR1.Connect(CEGS.m_p_GR[0]);
            p_GR2.Connect(CEGS.m_p_GR[1]);
            p_GR3.Connect(CEGS.m_p_GR[2]);
            p_GR4.Connect(CEGS.m_p_GR[3]);
            p_GR5.Connect(CEGS.m_p_GR[4]);
            p_GR6.Connect(CEGS.m_p_GR[5]);
            v_5VSupply.Connect(CEGS.m_V_5VPower);
            p_GM.Connect(CEGS.m_p_GM);
            p_Bakeout.Connect(CEGS.m_p_Bakeout);
            p_Ambient.Connect(CEGS.m_p_Ambient);
            v_LN_supply.Connect(CEGS.m_v_LN_supply);
            t_muxAIN13.Connect(CEGS.m_t_muxAIN13);
            t_MC.Connect(CEGS.m_t_MC);
            #endregion AnalogIO

            #region Heaters
            t_GR1_F.Connect(CEGS.h_GR[0]);
            t_GR2_F.Connect(CEGS.h_GR[1]);
            t_GR3_F.Connect(CEGS.h_GR[2]);
            t_GR4_F.Connect(CEGS.h_GR[3]);
            t_GR5_F.Connect(CEGS.h_GR[4]);
            t_GR6_F.Connect(CEGS.h_GR[5]);
            t_CC_S.Connect(CEGS.h_CC_S);
            t_VTT.Connect(CEGS.h_VTT);
            t_FTC_air.Connect(CEGS.h_FTC_air);
            #endregion Heaters

            #region TempSensors
            t_tabletop.Connect(CEGS.ts_tabletop);

            t_tank.Connect(CEGS.ts_LN_Tank);
            t_VTT_CF.Connect(CEGS.ts_LN_VTT);
            t_VTT_wire.Connect(CEGS.ts_VTT_wire);
            t_VTT_top.Connect(CEGS.ts_VTT_top);

            t_CuAg_CF.Connect(CEGS.ts_LN_CuAg);
            t_MC_CF.Connect(CEGS.ts_LN_MC);

            t_GM.Connect(CEGS.ts_GM);
            t_GR1_CF.Connect(CEGS.ts_LN_GR[0]);
            t_GR2_CF.Connect(CEGS.ts_LN_GR[1]);
            t_GR3_CF.Connect(CEGS.ts_LN_GR[2]);
            t_GR4_CF.Connect(CEGS.ts_LN_GR[3]);
            t_GR5_CF.Connect(CEGS.ts_LN_GR[4]);
            t_GR6_CF.Connect(CEGS.ts_LN_GR[5]);
            t_VP.Connect(CEGS.ts_LN_VP);
            t_d13C_CF.Connect(CEGS.ts_LN_d13C);
            #endregion TempSensors

            #region Valves
            vi_HV.Connect(CEGS.v_HV);
            vi_LV.Connect(CEGS.v_LV);
            vi_B.Connect(CEGS.v_B);
            vi_IM_VM.Connect(CEGS.v_IM_VM);
            vi_VTTR_VM.Connect(CEGS.v_VTTR_VM);
            vi_split_VM.Connect(CEGS.v_split_VM);
            vi_GM_VM.Connect(CEGS.v_GM_VM);
            vi_He_IM.Connect(CEGS.v_He_IM);
            vi_O2_IM.Connect(CEGS.v_O2_IM);
            vi_IP_IM.Connect(CEGS.v_IP_IM);
            vi_IM_VTTL.Connect(CEGS.v_IM_VTTL);
            vi_He_VTTL.Connect(CEGS.v_He_VTTL);
            vi_VTTL_VTTR.Connect(CEGS.v_VTTL_VTTR);
            vi_VTTR_CuAg.Connect(CEGS.v_VTTR_CuAg);
            vi_CuAg_MC.Connect(CEGS.v_CuAg_MC);
            vi_MC_MCU.Connect(CEGS.v_MC_MCU);
            vi_MC_MCL.Connect(CEGS.v_MC_MCL);
            vi_MC_split.Connect(CEGS.v_MC_split);
            vi_split_GM.Connect(CEGS.v_split_GM);
            vi_He_GM.Connect(CEGS.v_He_GM);
            vi_H2_GM.Connect(CEGS.v_H2_GM);
            vi_CO2_GM.Connect(CEGS.v_CO2_GM);
            vi_BP_GM.Connect(CEGS.v_BP_GM);
            vi_d13C_GM.Connect(CEGS.v_d13C_GM);
            vi_d13C_CF.Connect(CEGS.v_d13C_CF);
            vi_VP_d13C.Connect(CEGS.v_VP_d13C);
            vi_GR1_GM.Connect(CEGS.v_GR_GM[0]);
            vi_GR2_GM.Connect(CEGS.v_GR_GM[1]);
            vi_GR3_GM.Connect(CEGS.v_GR_GM[2]);
            vi_GR4_GM.Connect(CEGS.v_GR_GM[3]);
            vi_GR5_GM.Connect(CEGS.v_GR_GM[4]);
            vi_GR6_GM.Connect(CEGS.v_GR_GM[5]);
            vi_VTT_flow.Connect(CEGS.v_VTT_flow);
            vi_He_GM_flow.Connect(CEGS.v_He_GM_flow);
            vi_H2_GM_flow.Connect(CEGS.v_H2_GM_flow);
            vi_CO2_GM_flow.Connect(CEGS.v_CO2_GM_flow);
            vi_LN_VTT.Connect(CEGS.v_LN_VTT);
            vi_LN_CuAg.Connect(CEGS.v_LN_CuAg);
            vi_LN_MC.Connect(CEGS.v_LN_MC);
            vi_LN_GR1.Connect(CEGS.v_LN_GR[0]);
            vi_LN_GR2.Connect(CEGS.v_LN_GR[1]);
            vi_LN_GR3.Connect(CEGS.v_LN_GR[2]);
            vi_LN_GR4.Connect(CEGS.v_LN_GR[3]);
            vi_LN_GR5.Connect(CEGS.v_LN_GR[4]);
            vi_LN_GR6.Connect(CEGS.v_LN_GR[5]);
            vi_LN_VP.Connect(CEGS.v_LN_VP);
            vi_LN_d13C.Connect(CEGS.v_LN_d13C);

			vi_new_flow.Connect(CEGS.v_new_flow);
            #endregion Valves

            #region Graphite Reactors
            GR1_panel.Tag = CEGS.GR[0];
            GR2_panel.Tag = CEGS.GR[1];
            GR3_panel.Tag = CEGS.GR[2];
            GR4_panel.Tag = CEGS.GR[3];
            GR5_panel.Tag = CEGS.GR[4];
            GR6_panel.Tag = CEGS.GR[5];
            #endregion Graphite Reactors

            #region OnOffDevices
            d_Pump_HV.Tag = CEGS.pump_HV;
			d_fan_IP.Tag = CEGS.fan_IP;
			#endregion OnOffDevices
		}

		void InitializeControlContents()
        {
            sp_CC_S.Text = CEGS.h_CC_S.Target.Setpoint.ToString("0");
            sp_VTT.Text = CEGS.h_VTT.Target.Setpoint.ToString("0");
            sp_GR1_F.Text = CEGS.h_GR[0].Target.Setpoint.ToString("0");
            sp_GR2_F.Text = CEGS.h_GR[1].Target.Setpoint.ToString("0");
            sp_GR3_F.Text = CEGS.h_GR[2].Target.Setpoint.ToString("0");
            sp_GR4_F.Text = CEGS.h_GR[3].Target.Setpoint.ToString("0");
            sp_GR5_F.Text = CEGS.h_GR[4].Target.Setpoint.ToString("0");
            sp_GR6_F.Text = CEGS.h_GR[5].Target.Setpoint.ToString("0");

            sp_FTC_air.Text = CEGS.h_FTC_air.Target.Setpoint.ToString("0");

            showSampleInfo();

            GraphiteNumberTextBox.Text = CEGS.Next_GraphiteNumber.ToString();
            if (string.IsNullOrEmpty(CEGS.Last_GR))
                LastGRTextBox.Text = "1";
            else
                LastGRTextBox.Text = CEGS.Last_GR.Substring(CEGS.Last_GR.Length - 1, 1);

            VP_ContentsLabel.Text = CEGS.VP.Contents;

            AlertRecipientsTextBox.Text = "";
            foreach (string s in CEGS.ContactInfo.AlertRecipients)
                AlertRecipientsTextBox.Text += s + System.Environment.NewLine;

            EnableWatchdogsCheckBox.Checked = CEGS.EnableWatchdogs;
            EnableAutozeroCheckBox.Checked = CEGS.EnableAutozero;
        }

        void showSampleInfo()
        {
            Sample sample = CEGS.Sample;
            if (sample != null)
            {
                SampleIDDisplay.Text = sample.ID;
                ProcessDisplay.Text = (sample.Process == null ? "" : sample.Process);
                MassDisplay.Text = sample.grams.ToString("0.000000");
                AliquotDisplay.Text = sample.nAliquots.ToString();
                Take_d13C_CheckBox.Checked = sample.Take_d13C;
                Only_d13C_CheckBox.Checked = sample.Only_d13C;
                FiltrationsTextBox.Text = sample.Filtrations.ToString();
                NotifyCC_S_CheckBox.Checked = sample.NotifyCC_S;
                SulfurSuspectedCheckBox.Checked = sample.SulfurSuspected;
            }
        }

        void PopulateDropDowns()
        {
            populateGRMenu();
            populateLinePortStateMenu();
            populateProcessComboBox();
        }

        void PopulateDevicePage()
        {
            DeviceSearchBox.SetWatermark("Search");
            CreateTree();
            PopulateDeviceNavPane("");
        }

        void populateProcessComboBox()
        {
            ProcessComboBox.DataSource = new BindingSource(CEGS.ProcessDictionary, null);
            ProcessComboBox.DisplayMember = "Key";
            ProcessComboBox.ValueMember = "Value";
            ProcessComboBox.SelectedIndex = CEGS.ProcessDictionary.Count - 1;  // "Initialize System"
        }

		// This handler can run in any thread; it does not need to run in the UI thread;
		public void RequestService(object sender, EventArgs e)
		{
			var req = new ObjectPair(sender, e);
			lock (requestQ) { requestQ.Enqueue(req); }
			requestSignal.Set();
		}

		// This runs in a background thread that's ok to be blocked by the UI
		public static ObjectPair Req;
		void respondToRequests()
		{
			try
			{
				while (!UIClosing)
				{
					while (requestQ.Count > 0)
					{
						lock (requestQ) Req = requestQ.Dequeue();
						IAsyncResult ar = tabControl1?.BeginInvoke((MethodInvoker)delegate
						{
							var reqestor = Req.x;
							// This code is executed in the UI thread.
							if (reqestor is ValveIndicator)
								updateUI((ValveIndicator)reqestor);
							else if (reqestor is Gauge)
								((Gauge)reqestor).UpdateDisplay();
							else if (reqestor is CEGS)
							{
								var args = (Request)Req.y;
								switch (args.Service)
								{
//									case Services.MessageBox:
//										CEGS.DialogResult = ShowMessageBox(args.Args);
//										break;
//									case Services.PlaySound:
//										PlaySound();
//										break;
									default:
										break;
								}
							}
							else
								CEGS.EventLog.Record("Can't fulfill request [" + Req.ToString() + "]");
						});
						tabControl1?.EndInvoke(ar);    // wait for async code to finish
					}
					requestSignal.Reset();       // block on WaitOne()
					requestSignal.WaitOne();       // wait for a Control to be enqueued
				}
			}
			catch (Exception e)
			{ MessageBox.Show(e.ToString()); }
		}

		#region Indicator Highlighting

		void updateUI(ValveIndicator vi)
        {
            Valve v = vi.Actuator as Valve; if (v == null) return;
            switch (v.ValveState)
            {
                case Valve.States.Closed:
                    if (vi.BackColor != ClosedColor.BackColor)
                        vi.BackColor = ClosedColor.BackColor;
                    break;
                case Valve.States.Opening:
                    if (vi.BackColor != OpeningColor.BackColor)
                        vi.BackColor = OpeningColor.BackColor;
                    break;
                case Valve.States.Opened:
                    if (vi.BackColor != OpenedColor.BackColor)
                        vi.BackColor = OpenedColor.BackColor;
                    break;
                case Valve.States.Unknown:
					MeteringValve mv = v as MeteringValve;
					if (mv != null)
					{
						vi.BackColor = ClosedColor.BackColor.Blend(OpenedColor.BackColor, (double)mv.Position / (double)mv.OpenedPosition);
					}
                    else if (vi.BackColor != UnknownColor.BackColor)
                        vi.BackColor = UnknownColor.BackColor;
                    break;
                case Valve.States.Closing:
                    if (vi.BackColor != ClosingColor.BackColor)
                        vi.BackColor = ClosingColor.BackColor;
                    break;
                default:
                    break;
            }
        }

        void pressureChanged(object sender, EventArgs e)
        {
            Gauge g = sender as Gauge; if (g == null) return;
            if (g.Error != 0)
                g.BackColor = ErrorColor.BackColor;
            else
                g.BackColor = pressureColor(g.DisplayValue);
        }

        Color pressureColor(double p)
        {
            p = Math.Abs(p);
            if (p < 0.3) // Torr
                return HighVacuumColor.BackColor;
            else if (p >= p_Ambient.DisplayValue) // Torr
                return GaugePressureColor.BackColor;
            else
                return VacuumColor.BackColor;
        }

        void LNLevelChanged(object sender, EventArgs e)
        {
            Gauge g = sender as Gauge; if (g == null) return;
            if (g.Error != 0)
                g.BackColor = ErrorColor.BackColor;
            else
                g.BackColor = LNLevelColor(g.DisplayValue);
            g.ForeColor = g.DeviceOn ? Color.DarkBlue : Color.Black;
        }

        Color LNLevelColor(double liters)
        {
            if (liters > 9)
                return NeutralColor.BackColor;
            else if (liters > 4)
                return WarmColor.BackColor;
            else if (liters > 0)
                return WarningColor.BackColor;
            else
                return ErrorColor.BackColor;
        }

        void temperatureChanged(object sender, EventArgs e)
        {
            Gauge g = sender as Gauge; if (g == null) return;
            if (g.Error != 0)
                g.BackColor = ErrorColor.BackColor;
            else
                g.BackColor = temperatureColor(g.DisplayValue);
            g.ForeColor = g.DeviceOn ? Color.DarkBlue : Color.Black;
        }

        Color temperatureColor(double t)
        {
            if (t > 90)
                return HotColor.BackColor;
            else if (t > 40)
                return WarmColor.BackColor;
            else if (t == -999.9)
                return ErrorColor.BackColor;
            else if (t < -100)
                return ColdColor.BackColor;
            else if (t < 10)
                return CoolColor.BackColor;
            else    // between 10 and 40 C
                return NeutralColor.BackColor;
        }

        #endregion Indicator Highlighting

        // User Interface update timer service
        public static int msUITimer = 0;
        void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // every 100 ms
            if (msUITimer % 100 == 0)
                updateDisplay();

            // every minute
            if (msUITimer % 60000 == 0)
                msUITimer = 0;

            msUITimer += UpdateTimer.Interval;
        }

        void decorateHeaterIndicator(Control c)
        {
            PictureBox pb = c as PictureBox; if (pb == null) return;
            Heater h; EurothermFurnace ef;

            if ((h = pb.Tag as Heater) != null)
                pb.BackColor = h.IsOn ? HotColor.BackColor : OffColor.BackColor;
            else if ((ef = pb.Tag as EurothermFurnace) != null)
                pb.BackColor = ef.IsOn ? HotColor.BackColor : OffColor.BackColor;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);
        void updateTextBox(TextBox tb, string newtext)
        {
            int newlen = newtext.Length;
            int fh = (int)tb.Font.GetHeight();
            int ch = tb.ClientSize.Height;
            int possibleLines = Math.Max(1, ch / fh);
            int extraHeight = ch - possibleLines * fh;
            Point point = new Point(fh, ch - extraHeight - fh + 1);
            int line = tb.GetLineFromCharIndex(tb.GetCharIndexFromPosition(point));
            int ss = tb.SelectionStart;
            int sl = tb.SelectionLength;

            try
            {
                LockWindowUpdate(tb.Handle);
                tb.Text = newtext;
                tb.SelectionStart = tb.GetFirstCharIndexFromLine(line);
                tb.ScrollToCaret();
                tb.SelectionStart = ss;
                tb.SelectionLength = sl;
            }
            finally { LockWindowUpdate(IntPtr.Zero); }
        }

        void updateDisplay()
        {
            debugMsg();
            errorMsg();

            #region VM pressure display
            d_AimPower.Visible =
                CEGS.IonGaugeEnable.IsOn &&
                CEGS.IonGaugeEnable.MillisecondsInState > CEGS.milliseconds_IG_stabilize;
            p_VMLabel.Text = p_VM_HP.Prefix + Utility.sigDigitsString(CEGS.p_VM, 2);
            p_VMLabel.BackColor = pressureColor(CEGS.p_VM);
            #endregion VM pressure display

            #region Heater indicators
            decorateHeaterIndicator(d_CC_Q);
            decorateHeaterIndicator(d_CC_S2);
            decorateHeaterIndicator(d_CuAg_F);
            decorateHeaterIndicator(d_FTC_air);

            decorateHeaterIndicator(d_GR1_F);
            decorateHeaterIndicator(d_GR2_F);
            decorateHeaterIndicator(d_GR3_F);
            decorateHeaterIndicator(d_GR4_F);
            decorateHeaterIndicator(d_GR5_F);
            decorateHeaterIndicator(d_GR6_F);
            #endregion Heater indicators


            #region Other device states
            if (tabControl1.SelectedTab == tabBackPanel)
            {
                #region Thermalcontroller multiplexer temperatures
                t_TC0mux0.SetDisplayValue(CEGS.ThermalControllers[0].CJ0Temperature);
                t_TC1mux0.SetDisplayValue(CEGS.ThermalControllers[1].CJ0Temperature);
                t_TC2mux0.SetDisplayValue(CEGS.ThermalControllers[2].CJ0Temperature);
                t_TC2mux1.SetDisplayValue(CEGS.ThermalControllers[2].CJ1Temperature);
                #endregion Thermalcontroller multiplexer temperatures

                sbTextBox.Text = CEGS.SB0.ToString();

                StringBuilder sb = new StringBuilder();
                foreach (LabJackDaq d in LabJackDaq.List)
                    sb.Append(d.ToString());
                updateTextBox(ljTextBox, sb.ToString().TrimEnd());

                v_SPS.Text = CEGS.ActuatorController.Voltage.ToString("0.000");
            }

            displayLinePortState(IP_StateLabel);
            displayLinePortState(VP_StateLabel);
            //displayLinePortState(BP_StateLabel);

            // decorate HV pump indicator
            if (CEGS.pump_HV.IsOn)
            {
                //if (false)	// TODO: if current is high (> 200 mA -- but no magic number)
                //	d_Pump_HV.BackColor = WarningColor.BackColor;
                //else
                d_Pump_HV.BackColor = HighVacuumColor.BackColor;
            }
            else
            {
                d_Pump_HV.BackColor = OffColor.BackColor;
            }
			d_fan_IP.BackColor = CEGS.fan_IP.IsOn ? HighVacuumColor.BackColor : OffColor.BackColor;

			VP_ContentsLabel.Text = CEGS.VP.Contents;

            // hovered device state popup
            if (DeviceStatePopupLabel.Visible) showDeviceState();
            #endregion Other device states

            #region Rate-of-change indicators

            // Foreline pressure roc display
            if (p_Foreline.OverRange)
            {
                roc_pForeline.Text = "----";
                roc_pForeline.BackColor = VacuumColor.BackColor;
            }
            else
            {
                roc_pForeline.Text = CEGS.m_p_Foreline.RoC.Value.ToString("0.000");
                if (CEGS.m_p_Foreline.RoC < 0.004) // Torr/s
                    roc_pForeline.BackColor = HighVacuumColor.BackColor;
                else
                    roc_pForeline.BackColor = GaugePressureColor.BackColor;
            }

            // VTT pressure roc display
            if (p_VTT.OverRange)
            {
                roc_pVTT.Text = "----";
                roc_pVTT.BackColor = VacuumColor.BackColor;
            }
            else
            {   // VTTProc is in Torr / sec
                roc_pVTT.Text = (1000 * CEGS.m_p_VTT.RoC).ToString("0.0");  // show mTorr/s
                if (Math.Abs(CEGS.m_p_VTT.RoC) <= 0.0005)   // Torr/s
                    roc_pVTT.BackColor = HighVacuumColor.BackColor;
                else
                    roc_pVTT.BackColor = GaugePressureColor.BackColor;
            }


            // Graphite manifold pressure roc display
            if (p_GM.OverRange)
            {
                roc_pGM.Text = "----";
                roc_pGM.BackColor = VacuumColor.BackColor;
            }
            else
            {
                roc_pGM.Text = CEGS.m_p_GM.RoC.Value.ToString("0.0");
                ro_roc_pGM.Text = CEGS.m_p_GM.RoC.RoC.Value.ToString("0.0");
                if (Math.Abs(CEGS.m_p_GM.RoC) < 1)    // Torr/s
                    roc_pGM.BackColor = HighVacuumColor.BackColor;
                else
                    roc_pGM.BackColor = GaugePressureColor.BackColor;
            }
            ro_roc_pGM.BackColor = roc_pGM.BackColor;

            // Intake manifold pressure roc display
            if (p_IM.OverRange)
            {
                roc_pIM.Text = "----";
                roc_pIM.BackColor = VacuumColor.BackColor;
            }
            else
            {
                roc_pIM.Text = CEGS.m_p_IM.RoC.Value.ToString("0.0");
                if (Math.Abs(CEGS.m_p_IM.RoC) < 1)    // Torr/s
                    roc_pIM.BackColor = HighVacuumColor.BackColor;
                else
                    roc_pIM.BackColor = GaugePressureColor.BackColor;
            }

            #endregion Rate-of-change indicators

            #region Sample measurement fields

            ugC.Text = CEGS.ugCinMC.Value.ToString("0.0");

            roc_ugC.Text = CEGS.ugCinMC.RoC.Value.ToString("0.00");
            ro_roc_ugC.Text = CEGS.ugCinMC.RoC.RoC.Value.ToString("0.00");
            Color mcColor = Math.Abs(CEGS.ugCinMC.RoC) < CEGS.roc_ugc_stable ?
                HighVacuumColor.BackColor : GaugePressureColor.BackColor;
            roc_ugC.BackColor = mcColor;
            ro_roc_ugC.BackColor = mcColor;
            ugC.BackColor = mcColor;

            #endregion Sample measurement fields

            #region Graphite reactor contents
            GR1_ContentsLabel.Text = CEGS.GR[0].Contents;
            GR2_ContentsLabel.Text = CEGS.GR[1].Contents;
            GR3_ContentsLabel.Text = CEGS.GR[2].Contents;
            GR4_ContentsLabel.Text = CEGS.GR[3].Contents;
            GR5_ContentsLabel.Text = CEGS.GR[4].Contents;
            GR6_ContentsLabel.Text = CEGS.GR[5].Contents;
            #endregion Graphite reactor contents

            #region Process data
            if (!GraphiteNumberTextBox.Focused) GraphiteNumberTextBox.Text = CEGS.Next_GraphiteNumber.ToString();
            if (!LastGRTextBox.Focused) LastGRTextBox.Text = CEGS.Last_GR.Substring(CEGS.Last_GR.Length - 1, 1);

            if (CEGS.SampleIsRunning)
            {
                if (SampleGroupBox.Text != "Current Sample")
                    SampleGroupBox.Text = "Current Sample";
            }
            else
            {
                if (SampleGroupBox.Text != "Previous Sample")
                    SampleGroupBox.Text = "Previous Sample";
            }
            showSampleInfo();

            if (CEGS.ProcessState == ProcessStates.Ready)
            { if (startButton.Text != "Start") startButton.Text = "Start"; }
            else
            { if (startButton.Text != "Abort") startButton.Text = "Abort"; }
            ProcessStepLabel.Text = CEGS.ProcessStep.Description;
            ProcessSubStepLabel.Text = CEGS.ProcessSubStep.Description;

            ProcessTimeLabel.Text = swToString(CEGS.ProcessTime);
            ProcessStepTimeLabel.Text = tsToString(CEGS.ProcessStep.Elapsed);
            ProcessSubStepTimeLabel.Text = tsToString(CEGS.ProcessSubStep.Elapsed);
            RunTimeLabel.Text = swToString(CEGS.SystemRunTime);

            if (!pVM_targetTextBox.Focused)
                pVM_targetTextBox.Text = CEGS.pVM_target.ToString("0.0e0");

            #endregion Process data
        }

        void displayLinePortState(Label linePortLabel)
        {
            Color highlight = WarningColor.BackColor;
            Color normal = ApplicationBackColor.BackColor;

            LinePort linePort = (linePortLabel.Tag as LinePort);
            if (linePort == null) return;

            linePortLabel.Text = linePort.State.ToString();
            if (linePort.State == LinePort.States.Complete)
                linePortLabel.BackColor = highlight;
            else
                linePortLabel.BackColor = normal;
        }

        string swToString(Stopwatch sw)
        {
            return tsToString(sw.Elapsed);
        }

        string tsToString(TimeSpan ts)
        {
            return ts.ToString(ts.TotalDays < 1 ? @"h\:mm\:ss\.f" : @"d\ h\:mm\:ss");
        }

        void debugMsg()
        {
            //LabJackDaq lj = LabJackDaq.List[0];
            //debugLabel1.Text = 
            //    "DB:" + lj.StreamingBacklogDriver.ToString() + " " +
            //    "HW:" + lj.StreamingBacklogHardware.ToString() + " " +
            //    "DO:" + lj.PendingDO.ToString() + " " +
            //    "AO:" + lj.PendingAO.ToString();
            //debugLabel2.Text =
            //    "SF:" + lj.ScanFreq.ToString() + " " +
            //    "SPP:" + lj.StreamSPP.ToString() + " " +
            //    "RPS:" + lj.ScanRPS.ToString() + " " +
            //    "SRcvd:" + lj.ScansReceived.ToString() + " " +
            //    "SMS:" + lj.ScanMilliseconds.ToString();

            //debugLabel3.Text = "TC[0] ResponseTime/Longest: " +
            //	CEGS.ThermalController[0].ResponseTime.ToString() + "/" +
            //	CEGS.ThermalController[0].LongestResponseTime.ToString();
            debugLabel1.Visible = !string.IsNullOrEmpty(debugLabel1.Text);
            debugLabel2.Visible = !string.IsNullOrEmpty(debugLabel2.Text);
            debugLabel3.Visible = !string.IsNullOrEmpty(debugLabel3.Text);
        }

        void errorMsg()
        {
            string ErrorMsg = "";
            if (!CEGS.Initialized) return;

            if (CEGS.ThermalControllers[0].Disconnected)
                ErrorMsg += "TC[0] disconnected! ";
            else if (CEGS.ThermalControllers[0].ResponseTime > 30000)
                ErrorMsg += "TC[0] not responding! ";

            if (CEGS.ThermalControllers[1].Disconnected)
                ErrorMsg += "TC[1] disconnected! ";
            else if (CEGS.ThermalControllers[1].ResponseTime > 30000)
                ErrorMsg += "TC[1] not responding! ";

            if (CEGS.ThermalControllers[2].Disconnected)
                ErrorMsg += "TC[2] disconnected! ";
            else if (CEGS.ThermalControllers[2].ResponseTime > 30000)
                ErrorMsg += "TC[2] not responding! ";

            if (CEGS.ActuatorController.Disconnected)
                ErrorMsg += "Actuator Controller disconnected! ";

            if (ErrorMsg != "" && (statusLabel2.Text == "" || ErrorMsg != CEGS.LastAlertMessage))
                CEGS.Alert("System Error!", ErrorMsg);
            statusLabel2.Text = ErrorMsg;

            if (CEGS.LastAlertMessage == "")
                statusLabel3.Text = "";
            else
                statusLabel3.Text = (ErrorMsg != "" ? "   " : "") +
                    "Last Alert: " + CEGS.LastAlertMessage;
        }

		#region MessageBoxes & Dialogs

		Utilities.Message messageHandler(Utilities.Message message)
		{
			if (message.MessageType == Utilities.Message.Type.Request)
			{
				// TODO: Is this null check necessary?
				if (message.Caption == null)
					MessageBox.Show(message.Text);
				else
					MessageBox.Show(message.Text, message.Caption);
				return null;
			}
			else if (message.MessageType == Utilities.Message.Type.OkCancel)
			{
				// TODO: Does this fail if Caption is null?
				if (MessageBox.Show(this, message.Text, message.Caption,
						MessageBoxButtons.OKCancel) == DialogResult.OK)
					return new Utilities.Message("Ok");
				else
					return new Utilities.Message("Cancel");
			}
			else if (message.MessageType == Utilities.Message.Type.Tell)
			{
				new Thread(new ThreadStart(delegate
				{ MessageBox.Show(this, message.Text, message.Caption); })).Start();
				return null;
			}
			else if (message.MessageType == Utilities.Message.Type.Warn)
			{
				if (MessageBox.Show(this, message.Text, message.Caption,
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button2) == DialogResult.OK)
					return new Utilities.Message("Ok");
				else
					return new Utilities.Message("Cancel");
			}
			else
			{
				return new Utilities.Message("Unkown MessageType: " + message.MessageType.ToString());
			}
		}

		bool verifySampleInfo(bool run = false)
		{
			return SampleInfoBox.Show(run) == DialogResult.OK;
		}

		void showProcessSequenceEditor()
		{
			ProcessSequenceEditor.Show();
		}

		#endregion MessageBoxes & Dialogs

		#region Sound
		void InitializeSound()
        {
            soundPlayer = new SoundPlayer(@"C:\Windows\Media\chord.wav");
            soundPlayer.Load();
        }

        public void PlaySound()
        {
            if (soundPlayer != null && soundPlayer.IsLoadCompleted)
                soundPlayer.Play();
        }

        #endregion Sound

        #region Mouse and Focus

        // Treat click in blank areas like a tab (shift focus to next control)
        void blankArea_MouseClick(object sender, MouseEventArgs e)
        { SendKeys.Send("{TAB}"); }

        void blankArea_MouseDoubleClick(object sender, MouseEventArgs e)
        { }

        void control_MouseHover(object sender, EventArgs e)
        {
            Control c = sender as Control; if (c == null) return;
            statusLabel1.Text = c.AccessibleDescription;
            DeviceStatePopupLabel.Tag = c;
            showDeviceState();
        }

        void control_MouseLeave(object sender, EventArgs e)
        {
            hideDeviceState();
        }

        void showDeviceState()
        {
            if (!DevicePopupsCheckBox.Checked) return;
            Control c = (Control)DeviceStatePopupLabel.Tag;
            if (c == null) return;

            ValveIndicator vi; GraphiteReactor gr; FTColdfinger ftc;
            VTT vtt; Heater h; TempSensor ts; Gauge g; Tank t;
            MassFlowController mfc; EurothermFurnace tf;

            if ((vi = c as ValveIndicator) != null)
                DeviceStatePopupLabel.Text = vi.Actuator.ToString();
            else if ((gr = FindGR(c)) != null)
                DeviceStatePopupLabel.Text = gr.ToString();
            else if ((ftc = FindFTC(c)) != null)
                DeviceStatePopupLabel.Text = ftc.ToString();
            else if ((vtt = FindVTT(c)) != null)
                DeviceStatePopupLabel.Text = vtt.ToString();
            else if ((h = FindHeater(c)) != null)
                DeviceStatePopupLabel.Text = h.ToString();
            else if ((ts = FindTempSensor(c)) != null)
                DeviceStatePopupLabel.Text = ts.ToString();
            else if ((t = FindTank(c)) != null)
                DeviceStatePopupLabel.Text = t.ToString();
            else if ((g = FindGauge(c)) != null)
                DeviceStatePopupLabel.Text = g.ToString();
            else if ((mfc = FindMassFlowController(c)) != null)
                DeviceStatePopupLabel.Text = mfc.ToString();
            else if ((tf = FindEurothermFurnace(c)) != null)
                DeviceStatePopupLabel.Text = tf.ToString();
            else
                DeviceStatePopupLabel.Text = c.AccessibleName;

            if (!string.IsNullOrEmpty(DeviceStatePopupLabel.Text))
            {
                int pointerWidth = 18;
                int pointerHeight = 24;
                int margin = 25;

                Point LabelPosition = PointToClient(MousePosition);
                LabelPosition.Offset(pointerWidth, pointerHeight);

                int dx = DeviceStatePopupLabel.Parent.ClientRectangle.Width - LabelPosition.X - DeviceStatePopupLabel.Width - margin;
                int dy = DeviceStatePopupLabel.Parent.ClientRectangle.Height - LabelPosition.Y - DeviceStatePopupLabel.Height - margin;

                if (dy > 0)
                    dy = 0;
                else if (dx < 0)
                    dy = -DeviceStatePopupLabel.Height - pointerHeight - 4;
                if (dx > 0)
                    dx = 0;

                LabelPosition.Offset(dx, dy);
                if (LabelPosition.X < 0) LabelPosition.X = 0; if (LabelPosition.Y < 0) LabelPosition.Y = 0;
                DeviceStatePopupLabel.Location = LabelPosition;
                DeviceStatePopupLabel.BringToFront();
                DeviceStatePopupLabel.Show();
            }
        }

        void hideDeviceState()
        {
            statusLabel1.Text = "";
            DeviceStatePopupLabel.Tag = null;
            if (DeviceStatePopupLabel.Visible) DeviceStatePopupLabel.Hide();
        }


        #region Find devices linked to controls via Control.Tag
        Gauge FindGauge(Control c)
        {
            if (c is Gauge) return (Gauge)c;
            if (c.Tag is Control) return FindGauge((Control)c.Tag);
            return null;
        }

        TempSensor FindTempSensor(Control c)
        {
            if (c.Tag is TempSensor) return (TempSensor)c.Tag;
            Gauge g = FindGauge(c);
            if (g != null)
            {
                TempSensor ts = g.Device as TempSensor;
                if (ts != null) return ts;
            }
            if (c.Tag is Control) return FindTempSensor((Control)c.Tag);
            return null;
        }

        Heater FindHeater(Control c)
        {
            if (c.Tag is Heater) return (Heater)c.Tag;
            Gauge g = FindGauge(c);
            if (g != null)
            {
                Heater h = g.Device as Heater;
                if (h != null) return h;
            }
            if (c.Tag is Control) return FindHeater((Control)c.Tag);
            return null;
        }

        VTT FindVTT(Control c)
        {
            if (c.Tag is VTT) return (VTT)c.Tag;
            if (c.Tag is Control) return FindVTT((Control)c.Tag);
            return null;
        }

        GraphiteReactor FindGR(Control c)
        {
            if (c.Tag is GraphiteReactor) return (GraphiteReactor)c.Tag;
            if (c.Tag is Control) return FindGR((Control)c.Tag);
            return null;
        }

        FTColdfinger FindFTC(Control c)
        {
            if (c.Tag is FTColdfinger) return (FTColdfinger)c.Tag;
            if (c.Tag is Control) return FindFTC((Control)c.Tag);
            return null;
        }

        Tank FindTank(Control c)
        {
            if (c.Tag is Tank) return (Tank)c.Tag;
            if (c.Tag is Control) return FindTank((Control)c.Tag);
            return null;
        }

        OnOffDevice FindOnOffDevice(Control c)
        {
            if (c.Tag is OnOffDevice) return (OnOffDevice)c.Tag;
            if (c.Tag is Control) return FindOnOffDevice((Control)c.Tag);
            return null;
        }

        DigitalOutput FindDigitalOutput(Control c)
        {
            if (c.Tag is DigitalOutput) return (DigitalOutput)c.Tag;
            if (c.Tag is Control) return FindDigitalOutput((Control)c.Tag);
            return null;
        }

        MassFlowController FindMassFlowController(Control c)
        {
            if (c.Tag is MassFlowController) return (MassFlowController)c.Tag;
            if (c.Tag is Control) return FindMassFlowController((Control)c.Tag);
            return null;
        }

        EurothermFurnace FindEurothermFurnace(Control c)
        {
            if (c.Tag is EurothermFurnace) return (EurothermFurnace)c.Tag;
            if (c.Tag is Control) return FindEurothermFurnace((Control)c.Tag);
            return null;
        }

        #endregion Find devices linked to controls via Control.Tag

        void toggleLinkedControlVisibility(object sender, EventArgs e)
        {
            Control c = sender as Control; if (c == null) return;
            Control lc = c.Tag as Control; if (lc == null) return;
            lc.Visible = !lc.Visible;
        }

        // Show and shift Focus to the control in sender.Tag.
        void jumpToLinkedControl(object sender, EventArgs e)
        {
            Control c = sender as Control; if (c == null) return;
            Control lc = c.Tag as Control; if (lc == null) return;
            lc.Show();
            Cursor.Position = lc.PointToScreen(new Point(lc.Width - 5, lc.Height / 2));
            lc.Focus();
            if (lc is TextBox) ((TextBox)lc).SelectAll();
        }

        void exitKeyHandler(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        void ProcessListEnterKeyHandler(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tryToStartSelectedProcess();
                e.Handled = true;
            }
        }

        double GetNumber(string s)
        {
            try { return double.Parse(s); }
            catch { return 0; }
        }

        void LeaveSetpoint(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox; if (tb == null) return;
            Heater h; MassFlowController m; EurothermFurnace ef;

            int n = (int)GetNumber(tb.Text);

            if ((h = tb.Tag as Heater) != null)
            {
                tb.Text = n.ToString();

                if (h == CEGS.VTT.Heater)
                    CEGS.VTT.RegulatedSetpoint = n;

                h.SetSetpoint(n);
                if (!h.Target.ManualMode)
                    tb.Hide();
            }
            else if ((m = tb.Tag as MassFlowController) != null)
            {
                tb.Text = n.ToString("0.00");
                m.Setpoint = n;
                tb.Hide();
            }
            else if ((ef = tb.Tag as EurothermFurnace) != null)
            {
                if (n <= 0) n = 1;
                else if (n > 1250) n = 1200;
                tb.Text = n.ToString("0");
                ef.SetSetpoint(n);
                tb.Hide();
            }
        }

        void Leave_pVM_targetTextBox(object sender, EventArgs e)
        {
            CEGS.pVM_target = double.Parse(pVM_targetTextBox.Text);
        }

        void LeaveAlertRecipientsTextBox(object sender, EventArgs e)
        {
            CEGS.ContactInfo.AlertRecipients.Clear();
            foreach (string line in AlertRecipientsTextBox.Lines)
                CEGS.ContactInfo.AlertRecipients.Add(line);

        }

        #region Sample Info Text boxes

        int TextToInt(string s)
        {
            int i;
            try { i = int.Parse(s); }
            catch { i = 0; }
            return i;
        }

        void OneKeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox; if (tb == null) return;
            string valid_keys;
            if (tb.Name == "FiltrationsTextBox")
                valid_keys = "13579";
            else    // if (tb.Name == "SampleAliquotsTextBox")
                valid_keys = "123";

            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            else if (valid_keys.Contains(e.KeyChar.ToString()))
            {
                tb.Text = e.KeyChar.ToString();
                tb.SelectAll();
                e.Handled = true;
            }
            else
                e.Handled = true;
        }

        void LeaveGraphiteNumberTextBox(object sender, EventArgs e)
        { CEGS.Next_GraphiteNumber = TextToInt(((TextBox)sender).Text); }

        void LeaveLastGRTextBox(object sender, EventArgs e)
        { CEGS.Last_GR = "GR" + ((TextBox)sender).Text; }

        #endregion Sample Info Text boxes

        #endregion Mouse and Focus

        #region Context Menus

        void SaveSourceControl(object sender)
        {
            ContextMenuStrip cms = sender as ContextMenuStrip; if (cms == null) return;
            cms.Tag = cms.SourceControl;
        }

        Control GetSourceControl(object sender)
        {
            if (sender is ContextMenuStrip)
                return (sender as ContextMenuStrip).Tag as Control;
            ToolStripItem tsi = sender as ToolStripItem;
            if (tsi == null) return null;
            if (tsi.OwnerItem != null)
                return GetSourceControl(tsi.OwnerItem);
            else
                return GetSourceControl(tsi.Owner);
        }

        #region GR Context Menu

        void populateGRMenu()
        {
            foreach (GraphiteReactor.States state in (GraphiteReactor.States[])Enum.GetValues(typeof(GraphiteReactor.States)))
            {
                ToolStripMenuItem mi = new ToolStripMenuItem(state.ToString());
                mi.Tag = state;
                mi.Click += new EventHandler(GRMenuItem_Click);
                GRMenu.Items.Add(mi);
            }
        }

        void GRMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);
            GraphiteReactor gr = FindGR(GetSourceControl(sender)); if (gr == null) return;
            GRMenuTitle.Text = gr.Name;
            foreach (ToolStripMenuItem mi in GRMenu.Items)
            {
                if (mi.Tag is GraphiteReactor.States)
                {
                    if ((GraphiteReactor.States)(mi.Tag) == gr.State)
                        mi.CheckState = CheckState.Checked;
                    else
                        mi.CheckState = CheckState.Unchecked;
                }
            }
        }

        void GRMenuItem_Click(object sender, EventArgs e)
        {
            GraphiteReactor gr = FindGR(GetSourceControl(sender)); if (gr == null) return;
            gr.State = (GraphiteReactor.States)(((ToolStripMenuItem)sender).Tag);
        }

        #endregion GR Context Menu

        #region Heater Context Menu

        void HeaterMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);  // save SourceControl so submenu items can find it
            Heater h = FindHeater(GetSourceControl(sender)); if (h == null) return;

            if (h.IsOn)
            {
                HtrPowerMenuItem.ToolTipText = "Furnace is ON";
                HtrPowerMenuItem.Text = "Turn Off"; ;
            }
            else
            {
                HtrPowerMenuItem.ToolTipText = "Furnace is OFF";
                HtrPowerMenuItem.Text = "Turn On"; ;
            }
        }

        void HtrPowerMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem; if (mi == null) return;
            Heater h = FindHeater(GetSourceControl(mi)); if (h == null) return;

            if (mi.Text == "Turn Off")
            {
                if (h == CEGS.VTT.Heater)
                {
                    if (CEGS.VTT.Coldfinger.State >= FTColdfinger.States.Freeze)
                        CEGS.VTT.Freeze();
                    else
                        CEGS.VTT.Stop();
                }
                else
                    h.TurnOff();
            }
            else
            {
                if (h == CEGS.VTT.Heater)
                    CEGS.VTT.Regulate();
                else
                    h.TurnOn();
            }
        }

        #endregion Heater Context Menu

        #region Meter Gauge Context Menu

        void meterGaugeMenu_Opening(object sender, CancelEventArgs e)
        { SaveSourceControl(sender); }

        void meterZeroNowMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            Gauge g = c as Gauge;
            Meter m = (g == null) ? c.Tag as Meter : g.Device as Meter;
            if (m == null) return;
            m.ZeroNow();
        }

        #endregion Meter Gauge Context Menu

        #region Valve Context Menu

        void ValveMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);

            Control c = GetSourceControl(sender); if (c == null) return;
            ValveIndicator vi = c as ValveIndicator; if (vi == null) return;
            Valve v = vi.Actuator as Valve; if (v == null) return;

            valveMenu.Items.Clear();
            valveMenu.Items.Add(valveStopMenuItem);

            foreach (ActuatorAction a in v.Actions)
            {
                ToolStripMenuItem valveMenuItem = new ToolStripMenuItem(a.Name);
                valveMenuItem.Click += new EventHandler(valveMenuItem_Click);
                valveMenu.Items.Add(valveMenuItem);
            }
        }

        void valveMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            ValveIndicator vi = c as ValveIndicator; if (vi == null) return;
            Valve v = vi.Actuator as Valve; if (v == null) return;

            string ActionName = (sender as ToolStripMenuItem).Text;
			
			if (v is MeteringValve)
			{
				if (ActionName == Valve.OpenValve)
					v.Open();
				else if (ActionName == Valve.CloseValve)
					v.Close();
				else
					v.DoAction(ActionName);
			}
			else
				v.DoAction(ActionName);
		}

        void valveStopMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            ValveIndicator vi = c as ValveIndicator; if (vi == null) return;
            Valve v = vi.Actuator as Valve; if (v == null) return;
            v.Stop();
        }

        #endregion Valve Context Menu

        #region FTC Context Menu

        void FTCMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);
            Control c = GetSourceControl(sender); if (c == null) return;
            Gauge g = c as Gauge; if (g == null) return;
            FTColdfinger ftc = g.Tag as FTColdfinger; if (ftc == null) return;

            ftcRaiseMenuItem.CheckState =
                ftcFreezeMenuItem.CheckState =
                ftcThawMenuItem.CheckState =
                ftcStopMenuItem.CheckState =
                ftcStandbyMenuItem.CheckState = CheckState.Unchecked;

            switch (ftc.State)
            {
                case FTColdfinger.States.Raise:
                    ftcRaiseMenuItem.CheckState = CheckState.Checked;
                    break;
                case FTColdfinger.States.Freeze:
                    ftcFreezeMenuItem.CheckState = CheckState.Checked;
                    break;
                case FTColdfinger.States.Thaw:
                    ftcThawMenuItem.CheckState = CheckState.Checked;
                    break;
                case FTColdfinger.States.Stop:
                    ftcStopMenuItem.CheckState = CheckState.Checked;
                    break;
                case FTColdfinger.States.Standby:
                    ftcStandbyMenuItem.CheckState = CheckState.Checked;
                    break;
                default:
                    break;
            }
        }

        void FTCMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            FTColdfinger ftc = c.Tag as FTColdfinger; if (ftc == null) return;
            FTColdfinger.States ftcState = (FTColdfinger.States)Enum.Parse(typeof(FTColdfinger.States), (sender as ToolStripMenuItem).Text);

            if (ftc == CEGS.VTT.Coldfinger)
            {
                switch (ftcState)
                {
                    case FTColdfinger.States.Raise:
                        CEGS.VTT.Raise();
                        break;
                    case FTColdfinger.States.Freeze:
                        CEGS.VTT.Freeze();
                        break;
                    case FTColdfinger.States.Standby:
                        CEGS.VTT.Standby();
                        break;
                    case FTColdfinger.States.Stop:
                        CEGS.VTT.Stop();
                        break;
                    case FTColdfinger.States.Thaw:
                        CEGS.VTT.Thaw();
                        break;
                }
            }
            else
                ftc.EnsureState(ftcState);
        }

        #endregion FTC Context Menu

        #region Tank Context Menu

        void tankMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);
            Control c = GetSourceControl(sender); if (c == null) return;
            object d = c.Tag;
            bool isOn = false;
            if (d is Tank)
                isOn = (d as Tank).IsActive;
            else
                return;
            tankTurnOnOffMenuItem.Text = isOn ? "Turn Off" : "Turn On";
        }

        void tankTurnOnOffMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            Tank t = c.Tag as Tank; if (t == null) return;
            bool onOff = tankTurnOnOffMenuItem.Text == "Turn On";
            if (t == CEGS.LN_Tank) CEGS.LN_Tank.KeepActive = onOff;
            t.IsActive = onOff;
        }

        void tankFillNowMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            Tank t = c.Tag as Tank; if (t == null) return;
            if (t == CEGS.LN_Tank) CEGS.LN_Tank.KeepActive = true;
            t.IsActive = true;
            t.ForceFill();
        }

        #endregion Tank Context Menu

        #region VTT Context Menu

        void vttMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);
            Control c = GetSourceControl(sender); if (c == null) return;
            VTT vtt = FindVTT(c); if (vtt == null) return;

            vttRegulateMenuItem.CheckState =
                vttRaiseMenuItem.CheckState =
                vttFreezeMenuItem.CheckState =
                vttThawMenuItem.CheckState =
                vttStopMenuItem.CheckState =
                vttStandbyMenuItem.CheckState = CheckState.Unchecked;

            switch (vtt.State)
            {
                case VTT.States.Regulate:
                    vttRegulateMenuItem.CheckState = CheckState.Checked;
                    break;
                case VTT.States.Raise:
                    vttRaiseMenuItem.CheckState = CheckState.Checked;
                    break;
                case VTT.States.Freeze:
                    vttFreezeMenuItem.CheckState = CheckState.Checked;
                    break;
                case VTT.States.Thaw:
                    vttThawMenuItem.CheckState = CheckState.Checked;
                    break;
                case VTT.States.Stop:
                    vttStopMenuItem.CheckState = CheckState.Checked;
                    break;
                case VTT.States.Standby:
                    vttStandbyMenuItem.CheckState = CheckState.Checked;
                    break;
                default:
                    break;
            }
        }

        private void VTTMenuItemClick(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            VTT vtt = FindVTT(c); if (vtt == null) return;
            VTT.States vttState = (VTT.States)Enum.Parse(typeof(VTT.States), (sender as ToolStripMenuItem).Text);

            vtt.EnsureState(vttState);
        }

        #endregion VTT Context Menu

        #region OnOffDevice Context Menu

        void OnOffDeviceMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);  // save SourceControl so submenu items can find it
            OnOffDevice d; EurothermFurnace ef;

            if ((d = FindOnOffDevice(GetSourceControl(sender))) != null)
                OnMenuItem.Checked = d.IsOn;
            else if ((ef = FindEurothermFurnace(GetSourceControl(sender))) != null)
                OnMenuItem.Checked = ef.IsOn;
        }

        void OnMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            OnOffDevice d; EurothermFurnace ef;

            // TODO:
            // if it's the hv pump then we should instead call a 
            // CEGS function to safely shut down or start up the pump
            if ((d = FindOnOffDevice(c)) != null)
            {
                if (OnMenuItem.Checked)
                    d.TurnOn();
                else
                    d.TurnOff();
            }
            else if ((ef = FindEurothermFurnace(c)) != null)
            {
                if (OnMenuItem.Checked)
                    ef.TurnOn();
                else
                    ef.TurnOff();
            }
        }

        #endregion OnOffDevice Context Menu

        #region AutoManual Context Menu

        void AutoManualMenu_Opening(object sender, CancelEventArgs e)
        {
            if (!CEGS.EnableWatchdogs)
            {
                AutoMenuItem.Checked = CEGS.IonGaugeAuto;
                ManualOnMenuItem.Enabled = !AutoMenuItem.Checked;
                ManualOnMenuItem.Checked = CEGS.IonGaugeEnable.IsOn;
            }
            else
            {
                e.Cancel = true; // Menu disabled unless Watchdogs are off
            }
        }

        void AutoManualMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            //if (!AutoMenuItem.Checked)
            //	e.Cancel = true;
        }

        void AutoMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            CEGS.IonGaugeAuto = AutoMenuItem.Checked;
            ManualOnMenuItem.Enabled = !AutoMenuItem.Checked;
        }

        void ManualOnMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            CEGS.IonGaugeEnable.SetOutput(ManualOnMenuItem.Checked);
        }

        #endregion AutoManual Context Menu

        #region State Menus

        void populateLinePortStateMenu()
        {
            foreach (LinePort.States state in (LinePort.States[])Enum.GetValues(typeof(LinePort.States)))
            {
                ToolStripMenuItem mi = new ToolStripMenuItem(state.ToString());
                mi.Tag = state;
                mi.Click += new EventHandler(LinePortStateMenuItem_Click);
                LinePortStateMenu.Items.Add(mi);
            }
        }

        void LinePortStateMenu_Opening(object sender, CancelEventArgs e)
        {
            SaveSourceControl(sender);
            Control c = GetSourceControl(sender); if (c == null) return;
            LinePortStateMenuTitle.Text = c.AccessibleName;
            LinePort linePort = c.Tag as LinePort; if (linePort == null) return;
            foreach (ToolStripMenuItem mi in LinePortStateMenu.Items)
            {
                if (mi.Tag is LinePort.States)
                {
                    if ((LinePort.States)(mi.Tag) == linePort.State)
                        mi.CheckState = CheckState.Checked;
                    else
                        mi.CheckState = CheckState.Unchecked;
                }
            }
        }

        void LinePortStateMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            ToolStripMenuItem mi = sender as ToolStripMenuItem; if (mi == null) return;
            LinePort linePort = c.Tag as LinePort; if (linePort == null) return;
            linePort.State = (LinePort.States)mi.Tag;
            if (linePort.State == LinePort.States.Loaded)
                linePort.Contents = "";
        }

        #endregion State Menus

        #endregion Context Menus

        #region Other user inputs

        void closeButton_Click(object sender, EventArgs e)
        { Close(); }

        void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
                tryToStartSelectedProcess();
            else if (CEGS.ProcessThread != null)
                CEGS.ProcessThread.Abort();
            ProcessComboBox.Focus();
        }

        public void tryToStartSelectedProcess()
        {
            if (string.IsNullOrEmpty(CEGS.ProcessToRun))
            {
                KeyValuePair<string, ThreadStart> process =
                    (KeyValuePair<string, ThreadStart>)ProcessComboBox.SelectedItem;
                CEGS.ProcessToRun = process.Key;
            }
        }

        public void SelectProcess(string processName)
        {
            ProcessComboBox.SelectedItem = processName;
        }

        void valveDoubleClick(object sender, EventArgs e)
        {
            ValveIndicator vi = sender as ValveIndicator; if (vi == null) return;
            Valve v = vi.Actuator as Valve; if (v == null) return;
            switch (v.ValveState)
            {
                case Valve.States.Closed:
                    v.Open();
                    break;
                case Valve.States.Opened:
                case Valve.States.Unknown:
                    v.Close();
                    break;
                case Valve.States.Closing:
                case Valve.States.Opening:
                    v.Stop();
                    break;
                default:
                    break;
            }
        }

        void ClipPressure(bool YesNo)
        {
            if (YesNo)
            {
                p_GR1.Minimum = 0; p_GR1.ClipMinimum = true;
                p_GR2.Minimum = 0; p_GR2.ClipMinimum = true;
                p_GR3.Minimum = 0; p_GR3.ClipMinimum = true;
                p_GR4.Minimum = 0; p_GR4.ClipMinimum = true;
                p_GR5.Minimum = 0; p_GR5.ClipMinimum = true;
                p_GR6.Minimum = 0; p_GR6.ClipMinimum = true;
                p_IM.Minimum = 0; p_IM.ClipMinimum = true;
                p_GM.Minimum = 0; p_GM.ClipMinimum = true;
            }
            else
            {
                p_GR1.ClipMinimum = false;
                p_GR2.ClipMinimum = false;
                p_GR3.ClipMinimum = false;
                p_GR4.ClipMinimum = false;
                p_GR5.ClipMinimum = false;
                p_GR6.ClipMinimum = false;
                p_IM.ClipMinimum = false;
                p_GM.ClipMinimum = false;
            }
        }

        void ClipPressureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClipPressure(ClipPressureCheckBox.Checked);
        }

        void ClipTemperature(bool YesNo)
        {
            if (YesNo)
            {
                double lnbp = -195.8;
                t_CuAg_CF.Minimum = lnbp; t_CuAg_CF.ClipMinimum = true;
                t_GR1_CF.Minimum = lnbp; t_GR1_CF.ClipMinimum = true;
                t_GR2_CF.Minimum = lnbp; t_GR2_CF.ClipMinimum = true;
                t_GR3_CF.Minimum = lnbp; t_GR3_CF.ClipMinimum = true;
                t_GR4_CF.Minimum = lnbp; t_GR4_CF.ClipMinimum = true;
                t_GR5_CF.Minimum = lnbp; t_GR5_CF.ClipMinimum = true;
                t_GR6_CF.Minimum = lnbp; t_GR6_CF.ClipMinimum = true;
                t_MC_CF.Minimum = lnbp; t_MC_CF.ClipMinimum = true;
                t_VP.Minimum = lnbp; t_VP.ClipMinimum = true;
                t_VTT.Minimum = lnbp; t_VTT.ClipMinimum = true;
                t_VTT_CF.Minimum = lnbp; t_VTT_CF.ClipMinimum = true;
                t_tank.Minimum = lnbp; t_tank.ClipMinimum = true;
                t_tabletop.Minimum = lnbp; t_tabletop.ClipMinimum = true;
                t_d13C_CF.Minimum = lnbp; t_d13C_CF.ClipMinimum = true;
            }
            else
            {
                t_CuAg_CF.ClipMinimum = false;
                t_GR1_CF.ClipMinimum = false;
                t_GR2_CF.ClipMinimum = false;
                t_GR3_CF.ClipMinimum = false;
                t_GR4_CF.ClipMinimum = false;
                t_GR5_CF.ClipMinimum = false;
                t_GR6_CF.ClipMinimum = false;
                t_MC_CF.ClipMinimum = false;
                t_VP.ClipMinimum = false;
                t_VTT.ClipMinimum = false;
                t_VTT_CF.ClipMinimum = false;
                t_tank.ClipMinimum = false;
                t_tabletop.ClipMinimum = false;
                t_d13C_CF.ClipMinimum = false;
            }
        }

        void ClipTemperatureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClipTemperature(ClipTemperatureCheckBox.Checked);
        }

        void color_Click(object sender, EventArgs e)
        {
            Control c = sender as Control; if (c == null) return;
            colorDialog1.Color = c.BackColor;
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                c.BackColor = colorDialog1.Color;
                if (c == ApplicationBackColor)
                {
                    this.BackColor = c.BackColor;
                    statusStrip1.BackColor = c.BackColor;
                    tabControlPanel.BackColor = c.BackColor;
                    mainPanel.BackColor = c.BackColor;
                    DiagramPictureBox.BackColor = c.BackColor;
                    tabBackPanel.BackColor = c.BackColor;
                    tabSettings.BackColor = c.BackColor;
                    tabDeviceSettings.BackColor = c.BackColor;
                }
            }
        }

        void statusLabel3_Click(object sender, EventArgs e)
        { CEGS.clearLastAlertMessage(); }

        void EnableWatchdogsCheckBox_CheckedChanged(object sender, EventArgs e)
        { CEGS.EnableWatchdogs = EnableWatchdogsCheckBox.Checked; }

        void EnableAutozeroCheckBox_CheckedChanged(object sender, EventArgs e)
        { CEGS.EnableAutozero = EnableAutozeroCheckBox.Checked; }

        List<KeyValuePair<string, object>> DeviceList(string categoryName)
        {
            PropertyInfo categoryPropertyInfo = typeof(SystemComponents).GetProperty(categoryName);
            Type systemComponentsPropertyType = categoryPropertyInfo.PropertyType;
            object systemComponentsProperty = categoryPropertyInfo.GetValue(CEGS.SystemComponents);

            var deviceList = new List<KeyValuePair<string, object>>();
            if (typeof(IList).IsAssignableFrom(systemComponentsPropertyType))  // this systemComponentsField is a list
            {
                foreach (object device in systemComponentsProperty as IList)
                {
                    try
                    {
                        string name = (string)device.GetType().GetProperty("Name").GetValue(device, null);
                        var kvp = new KeyValuePair<string, object>(name, device);
                        deviceList.Add(kvp);
                    }
                    catch { /* ignore it if it doesn't have a name */ }
                }
            }
            return deviceList;
        }

        void CreateTree()
        {
            List<string> SystemComponentsFilter = new List<string>();
            SystemComponentsFilter.Add("ProcessSequences");
            SystemComponentsFilter.Add("Samples");

            PropertyInfo[] syscomps = (PropertyInfo[])(CEGS.SystemComponents.GetType().GetProperties().Clone());
            List<string> cats = new List<string>();
            foreach (PropertyInfo pi in syscomps)
            {
                if (SystemComponentsFilter.Contains(pi.Name))
                    continue;
                cats.Add(pi.Name);
            }

            foreach (string category in cats)
            {
                TreeNode c = new TreeNode(category);
                foreach (var device in DeviceList(category))
                {
                    TreeNode d = new TreeNode(device.Key);
                    d.Tag = device.Value;
                    c.Nodes.Add(d);
                }
                if (c.Nodes.Count > 0)
                {
                    DeviceTree.Nodes.Add(c);
                }
            }
        }

        void PopulateDeviceNavPane(string search)
        {
            DeviceNavTree.ShowLines = false;
            DeviceNavTree.Nodes.Clear();

            int counter = 0;
            foreach (TreeNode c in DeviceTree.Nodes)
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach (TreeNode d in c.Nodes)
                {
                    if (d.Text.ToLower().Contains(search.ToLower()))
                        nodes.Add(d);
                }
                if (nodes.Count > 0)
                {
                    DeviceNavTree.Nodes.Add(c.Text);
                    DeviceNavTree.Nodes[counter].Nodes.AddRange(nodes.ToArray());
                    counter++;
                }
            }
            if (search != "")
                DeviceNavTree.ExpandAll();
        }

        private void DeviceNavTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SettingsPanel.Controls.Clear();
            TreeNode n = (sender as TreeView).SelectedNode;
            if (n != null)
            {
                object o = n.Tag;
                if (o != null)
                {
                    DeviceLabel.Text = n.Text;
                    separator1.Visible = true;
                    PopulateControl(SettingsPanel, new SettingNode(o));
                    SettingsPanel.Visible = true;
                }
                else
                {
                    DeviceLabel.Text = "";
                    separator1.Visible = false;
                    SettingsPanel.Visible = false;
                }
            }
        }

        private void DeviceSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                return;
            }

            PopulateDeviceNavPane((sender as TextBox).Text);
        }

        int Below(Control c)
        {
            return (c == null) ? 0 :
                c.Bottom + (c is GroupBox ? 12 : 10);
        }

        void PopulateControl(Control control, SettingNode node)
        {
            //int nameWidth = (int)(0.5 * control.Width);
            int gbPad = 9;
            int hPad = control is GroupBox ? 6 : 15;
            int vPad = control is GroupBox ? 20 : 5;
            ///int valueWidth = control.Width - nameWidth - 2 * hPad;

            int y = vPad;

            int i = control.Controls.Count - 1;
            if (i >= 0) y = Below(control.Controls[i]);
            Point location = new Point(hPad, y);

            Leaf leaf = node as Leaf;

            if (leaf == null)
            {
                if (node.IsNamed && node.HasSiblings)
                {
                    var groupBox = new GroupBox();
                    groupBox.Text = node.Name;
                    groupBox.Location = new Point(gbPad, location.Y);
                    groupBox.Width = control.Width - 2 * gbPad;
                    groupBox.Height = 20;
                    groupBox.AutoSize = true;
                    control.Controls.Add(groupBox);
                    control = groupBox;
                }

                foreach (SettingNode sn in node.Children)
                    PopulateControl(control, sn);

                return;
            }

            Label Name = new Label();
            Name.TextAlign = ContentAlignment.MiddleLeft;
            Name.AutoSize = true;
            Name.MinimumSize = new Size(80, 18);
            Name.Text = node.Name;
            Name.Location = location;
            control.Controls.Add(Name);

            Control valueControl;
            if (leaf.Type == typeof(bool) || leaf.Type.IsEnum)
            {
                location.Offset(Name.Width, -1);
                valueControl = new ComboBox();
                ComboBox comboBox = valueControl as ComboBox;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.FormattingEnabled = true;
                if (leaf.Type == typeof(bool))
                {
                    comboBox.Items.Add("No");
                    comboBox.Items.Add("Yes");
                    comboBox.SelectedIndex = (bool)leaf.Value ? 1 : 0;
                }
                else if (leaf.Type.IsEnum)
                {
                    foreach (object o in Enum.GetValues(leaf.Type))
                        comboBox.Items.Add(o);
                    comboBox.SelectedItem = leaf.Value;
                }
            }
            else
            {
                location.Offset(Name.Width, 0);
                valueControl = new TextBox();
                valueControl.Text = leaf.Value.ToString();
                valueControl.KeyPress += new KeyPressEventHandler(exitKeyHandler);
            }

            valueControl.Tag = node;
            valueControl.Location = location;
            valueControl.Width = control.Width - Name.Width - 2 * hPad;
            valueControl.Leave += new EventHandler(UpdateSetting);
            control.Controls.Add(valueControl);
        }

        void UpdateSetting(object sender, EventArgs e)
        {
            Leaf sn = (sender as Control).Tag as Leaf;
            if (sn == null)
                return;
            sn.SetValue((sender as Control).Text);
        }

        #endregion Other user inputs
    }
}
