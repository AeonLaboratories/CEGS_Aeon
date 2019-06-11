using HACS.Components;
using HACS.Core;
using HACS.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace ApplicationNamespace
{
	public partial class UserInterface : Form, IHacsUI
	{
		#region fields

		static Properties.Settings Settings = Properties.Settings.Default;

		// These objects are used to handle actions taken on request 
		// (e.g., to update UI elements that aren't automatically updated 
		// every UpdateTimer tick).
		static Queue<ObjectPair> requestQ = new Queue<ObjectPair>();
		static Thread responseThread;
		static AutoResetEvent requestSignal = new AutoResetEvent(false);

		// sound
		SoundPlayer soundPlayer;

		#endregion fields

		public bool Initialized { get; set; }
		bool UIClosing = false;
		TreeNode DeviceTree = new TreeNode("root");

		HACSBridge<CEGS_Aeon> Bridge = new HACSBridge<CEGS_Aeon>();
		public CEGS_Aeon CEGS;

        public ActuatorController ActuatorController0;
        public SwitchBank SwitchBank0;

		public UserInterface()
		{
			InitializeComponent();
			InitializeSound();

            // immediately register to receive UI-intended messages from HACS
            Notice.DefaultSender.OnNotice += NoticeHandler;

			// Start the bridge (& Hacs)
			Bridge.UserInterface = this;
			CEGS = Bridge.HACSImplementation;
			Text = CEGS.Name;

			#region implementation-specific
			CEGS.VerifySampleInfo = VerifySampleInfo;
			CEGS.ShowProcessSequenceEditor = ShowProcessSequenceEditor;
			#endregion implementation-specific
		}

		void UserInterface_Load(object sender, EventArgs e)
		{
			#region implementation-specific
			SampleInfoBox.CEGS = CEGS;
			#endregion implementation-specific

			populateDropDowns();
			populateDevicePage();

            ActuatorController0 = ActuatorController.Find("ActuatorController0");
            SwitchBank0 = SwitchBank.Find("SwitchBank0");

            // link controls before initializing CEGS system components,
            // so devices can display their status as they are initialized
            LinkControls();

			Location = Settings.FormLocation;
			Size = Settings.FormSize;
			ClipPressure(Settings.ClipPressure);
			ClipTemperature(Settings.ClipTemperature);
			DevicePopupsCheckBox.Checked = Settings.DevicePopups;

			// This thread updates UI elements that are serviced
			// only on request (i.e., they aren't automatically updated 
			// every UpdateTimer tick).
			responseThread = new Thread(respondToRequests)
			{
				Name = "UI respondToRequests",
				IsBackground = true
			};
			responseThread.Start();

			Bridge.UILoaded();  //	(OR have Bridge subscribe to some OnLoaded event?)
		}

		void UserInterface_Shown(object sender, EventArgs e)
		{
			InitializeControlContents();
			UpdateTimer.Start();
			Initialized = true;

			Bridge.UIShown();
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

			Bridge?.UIClosing();
		}

		#region implementation-specific
		void LinkControls()
		{

			#region Connect()ions

			#region AnalogIO
			p_MC.Connect(Meter.Find("m_p_MC"));
			p_Foreline.Connect(Meter.Find("m_p_Foreline"));
			p_VM_HP.Connect(Meter.Find("m_p_VM_HP"));
			p_VM_IG.Connect(Meter.Find("m_p_VM_IG"));
			p_IM.Connect(Meter.Find("m_p_IM"));
			p_VTT.Connect(Meter.Find("m_p_VTT"));
			p_GR1.Connect(Meter.Find("m_p_GR[0]"));
			p_GR2.Connect(Meter.Find("m_p_GR[1]"));
			p_GR3.Connect(Meter.Find("m_p_GR[2]"));
			p_GR4.Connect(Meter.Find("m_p_GR[3]"));
			p_GR5.Connect(Meter.Find("m_p_GR[4]"));
			p_GR6.Connect(Meter.Find("m_p_GR[5]"));
			v_5VSupply.Connect(Meter.Find("m_V_5VPower"));
			v_MainsDetect.Connect(Meter.Find("m_V_5VMainsDetect"));
			p_GM.Connect(Meter.Find("m_p_GM"));
			p_Bakeout.Connect(Meter.Find("m_p_Bakeout"));
            p_Ambient.Connect(Meter.Find("m_p_Ambient"));
			v_LN_supply.Connect(Meter.Find("m_v_LN_supply"));
			t_Ambient.Connect(Meter.Find("m_t_Ambient"));
			t_MC.Connect(Meter.Find("m_t_MC"));

            #endregion AnalogIO

            #region Heaters
            t_CC_S.Connect(Heater.Find("h_CC_S"));
            t_VTT.Connect(Heater.Find("h_VTC"));
            t_GR1_F.Connect(Heater.Find("h_GR1"));
			t_GR2_F.Connect(Heater.Find("h_GR2"));
			t_GR3_F.Connect(Heater.Find("h_GR3"));
			t_GR4_F.Connect(Heater.Find("h_GR4"));
			t_GR5_F.Connect(Heater.Find("h_GR5"));
			t_GR6_F.Connect(Heater.Find("h_GR6"));
			#endregion Heaters

			#region TempSensors
			t_tabletop.Connect(TempSensor.Find("ts_tabletop"));

			t_LnManifold.Connect(TempSensor.Find("ts_LnManifold"));
			t_VTT_CF.Connect(TempSensor.Find("ts_LN_VTC"));
			t_VTT_wire.Connect(TempSensor.Find("ts_VTC_wire"));
			t_VTT_top.Connect(TempSensor.Find("ts_VTC_top"));

			t_CuAg_CF.Connect(TempSensor.Find("ts_LN_CuAg"));
			t_MC_CF.Connect(TempSensor.Find("ts_LN_MC"));

			t_GM.Connect(TempSensor.Find("ts_GM"));
			t_GR1_CF.Connect(TempSensor.Find("ts_LN_GR[0]"));
			t_GR2_CF.Connect(TempSensor.Find("ts_LN_GR[1]"));
			t_GR3_CF.Connect(TempSensor.Find("ts_LN_GR[2]"));
			t_GR4_CF.Connect(TempSensor.Find("ts_LN_GR[3]"));
			t_GR5_CF.Connect(TempSensor.Find("ts_LN_GR[4]"));
			t_GR6_CF.Connect(TempSensor.Find("ts_LN_GR[5]"));
			t_VP.Connect(TempSensor.Find("ts_LN_VP"));
			#endregion TempSensors

			#region Valves
			vi_HV.Connect(Valve.Find("v_HV"));
			vi_LV.Connect(Valve.Find("v_LV"));
			vi_B.Connect(Valve.Find("v_B"));

			vi_IM_VM.Connect(Valve.Find("v_IM_VM"));
            vi_VTTR_VM.Connect(Valve.Find("v_VTTR_VM"));
            vi_Split_VM.Connect(Valve.Find("v_Split_VM"));

			vi_He_IM.Connect(Valve.Find("v_He_IM"));
			vi_O2_IM.Connect(Valve.Find("v_O2_IM"));
			vi_IP_IM.Connect(Valve.Find("v_IP_IM"));

			vi_IM_VTTL.Connect(Valve.Find("v_IM_VTTL"));
			vi_He_VTTL.Connect(Valve.Find("v_He_VTTL"));
			vi_VTTL_VTTR.Connect(Valve.Find("v_VTTL_VTTR"));
			vi_VTT_CuAg.Connect(Valve.Find("v_VTTR_CuAg"));
			vi_CuAg_MC.Connect(Valve.Find("v_CuAg_MC"));
			vi_CO2_GM.Connect(Valve.Find("v_CO2_GM"));
			vi_MC_MCU.Connect(Valve.Find("v_MC_MCU"));
			vi_MC_MCL.Connect(Valve.Find("v_MC_MCL"));
			vi_MC_Split.Connect(Valve.Find("v_MC_Split"));
			vi_He_GM.Connect(Valve.Find("v_He_GM"));
			vi_GM_Split.Connect(Valve.Find("v_GM_Split"));
			vi_H2_GM.Connect(Valve.Find("v_H2_GM"));
			vi_d13C_GM.Connect(Valve.Find("v_d13C_GM"));
			vi_VP_d13C.Connect(Valve.Find("v_VP_d13C"));
			vi_GR1_GM.Connect(Valve.Find("v_GR1_GM"));
			vi_GR2_GM.Connect(Valve.Find("v_GR2_GM"));
			vi_GR3_GM.Connect(Valve.Find("v_GR3_GM"));
			vi_GR4_GM.Connect(Valve.Find("v_GR4_GM"));
			vi_GR5_GM.Connect(Valve.Find("v_GR5_GM"));
			vi_GR6_GM.Connect(Valve.Find("v_GR6_GM"));

			vi_VTT_flow.Connect(Valve.Find("v_VTT_flow"));
			vi_He_GM_flow.Connect(Valve.Find("v_He_GM_flow"));
			vi_H2_GM_flow.Connect(Valve.Find("v_H2_GM_flow"));
			vi_CO2_GM_flow.Connect(Valve.Find("v_CO2_GM_flow"));

			vi_LN_VTC.Connect(Valve.Find("v_LN_VTC"));
			vi_LN_CuAg.Connect(Valve.Find("v_LN_CuAg"));
			vi_LN_MC.Connect(Valve.Find("v_LN_MC"));
			vi_LN_GR1.Connect(Valve.Find("v_LN_GR1"));
			vi_LN_GR2.Connect(Valve.Find("v_LN_GR2"));
			vi_LN_GR3.Connect(Valve.Find("v_LN_GR3"));
			vi_LN_GR4.Connect(Valve.Find("v_LN_GR4"));
			vi_LN_GR5.Connect(Valve.Find("v_LN_GR5"));
			vi_LN_GR6.Connect(Valve.Find("v_LN_GR6"));
			vi_LN_VP.Connect(Valve.Find("v_LN_VP"));
			vi_LN_d13C.Connect(Valve.Find("v_LN_d13C"));

			#endregion Valves

			#endregion Connect()ions


			#region Tag links

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
			VttLPictureBox.Tag = VttPanel;
			VttRPictureBox.Tag = VttPanel;
			p_VTT.Tag = roc_pVTT;
            p_IM.Tag = roc_pIM;
            p_GM.Tag = roc_pGM;
            ugC.Tag = roc_ugC;
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
            #endregion focus links

            #region Link Label-type device state indicators to their devices
            IP_StateLabel.Tag = LinePort.Find("IP");
			VP_StateLabel.Tag = LinePort.Find("VP");
            #endregion Link Label-type device state indicators to their devices

            #region Link non-Gauge value displays to underlying meter
            #endregion Link non-Gauge value displays to underlying meter

            #region Link heater indicators to heaters
            d_CuAg_F.Tag = Heater.Find("h_CuAg");
			d_CC_Q.Tag = Heater.Find("h_CC_Q");
            d_CC_S2.Tag = Heater.Find("h_CC_S2");
            d_GR1_F.Tag = t_GR1_F.Device;
            d_GR2_F.Tag = t_GR2_F.Device;
            d_GR3_F.Tag = t_GR3_F.Device;
            d_GR4_F.Tag = t_GR4_F.Device;
            d_GR5_F.Tag = t_GR5_F.Device;
            d_GR6_F.Tag = t_GR6_F.Device;
            #endregion Link heater indicators to heaters

            #region Link setpoint textbox controls to controlled devices
            sp_CC_S.Tag = t_CC_S.Device;
			sp_VTT.Tag = t_VTT.Device;
			sp_GR1_F.Tag = t_GR1_F.Device;
			sp_GR2_F.Tag = t_GR2_F.Device;
			sp_GR3_F.Tag = t_GR3_F.Device;
			sp_GR4_F.Tag = t_GR4_F.Device;
			sp_GR5_F.Tag = t_GR5_F.Device;
			sp_GR6_F.Tag = t_GR6_F.Device;
            #endregion Link setpoint textbox controls to controlled devices

            #region Link FTC temperature displays to FTC
            t_GR1_CF.Tag = FTColdfinger.Find("ftc_GR1");
			t_GR2_CF.Tag = FTColdfinger.Find("ftc_GR2");
            t_GR3_CF.Tag = FTColdfinger.Find("ftc_GR3");
            t_GR4_CF.Tag = FTColdfinger.Find("ftc_GR4");
            t_GR5_CF.Tag = FTColdfinger.Find("ftc_GR5");
            t_GR6_CF.Tag = FTColdfinger.Find("ftc_GR6");
            t_MC_CF.Tag = FTColdfinger.Find("ftc_MC");
            t_CuAg_CF.Tag = FTColdfinger.Find("ftc_CuAg");
            t_VP.Tag = FTColdfinger.Find("ftc_VP");
            t_VTT_CF.Tag = FTColdfinger.Find("ftc_VTT");
            #endregion Link FTC temperature displays to FTC

            #region Link FTC controls to FTC
            #endregion Link FTC controls to FTC

            #region Link LnManifold controls to LnManifold
            d_LnManifold.Tag = LnManifold.Find("LnManifold");
            t_LnManifold.Tag = d_LnManifold.Tag;
            LnManifoldLabel.Tag = d_LnManifold.Tag;
            // and also the LnManifold level
            v_LN_supply.Tag = d_LnManifold.Tag;
            #endregion Link LnManifold controls to LnManifold

            #region Link VTT controls to VTT
            VttPanel.Tag = VTColdfinger.Find("VTC");
			#endregion Link VTT controls to VTT

            #region Graphite Reactors
            GR1_panel.Tag = GraphiteReactor.Find("GR1");
            GR2_panel.Tag = GraphiteReactor.Find("GR2");
            GR3_panel.Tag = GraphiteReactor.Find("GR3");
            GR4_panel.Tag = GraphiteReactor.Find("GR4");
            GR5_panel.Tag = GraphiteReactor.Find("GR5");
            GR6_panel.Tag = GraphiteReactor.Find("GR6");
            #endregion Graphite Reactors

            #region OnOffDevices
            d_fan_pump_HV.Tag = OnOffDevice.Find("fan_pump_HV");
            d_fan_IP.Tag = OnOffDevice.Find("fan_IP");
            #endregion OnOffDevices

            // Link each ion gauge Gauge (display) to the vacuum system that "owns" the ion gauge.
            d_IGPower.Tag = p_VM_IG.Device;
            p_VM_IG.Tag = VacuumSystem.List.Find(x => x.Pressure.IG == (p_VM_IG.Device as IonGauge));

            #region Link Transparent PictureBox controls to their devices
            CuAgPictureBox.Tag = t_CuAg_CF.Tag;
            VPVPictureBox.Tag = t_VP.Tag;
            VacuumSystemPictureBox.Tag = VacuumSystem.Find("VacuumSystem");
            #endregion Link Transparent PictureBox controls to their devices

            #endregion Tag links
        }

        void InitializeControlContents()
		{
            sp_CC_S.Text = (sp_CC_S.Tag as Heater).Target.Setpoint.ToString("0");
			sp_VTT.Text = (sp_VTT.Tag as Heater).Target.Setpoint.ToString("0");
			sp_GR1_F.Text = (sp_GR1_F.Tag as Heater).Target.Setpoint.ToString("0");
			sp_GR2_F.Text = (sp_GR2_F.Tag as Heater).Target.Setpoint.ToString("0");
			sp_GR3_F.Text = (sp_GR3_F.Tag as Heater).Target.Setpoint.ToString("0");
			sp_GR4_F.Text = (sp_GR4_F.Tag as Heater).Target.Setpoint.ToString("0");
			sp_GR5_F.Text = (sp_GR5_F.Tag as Heater).Target.Setpoint.ToString("0");
			sp_GR6_F.Text = (sp_GR6_F.Tag as Heater).Target.Setpoint.ToString("0");

            showSampleInfo();

			GraphiteNumberTextBox.Text = CEGS.Next_GraphiteNumber.ToString();
			if (string.IsNullOrEmpty(CEGS.Last_GR))
				LastGRTextBox.Text = "1";
			else
				LastGRTextBox.Text = CEGS.Last_GR.Substring(CEGS.Last_GR.Length - 1, 1);

			VP_ContentsLabel.Text = (VP_StateLabel.Tag as LinePort).Contents;

			AlertRecipientsTextBox.Text = "";
			foreach (string s in CEGS.AlertManager.ContactInfo.AlertRecipients)
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
				ProcessDisplay.Text = (sample?.Process ?? "");
				MassDisplay.Text = sample.grams.ToString("0.000000");
				AliquotDisplay.Text = sample.nAliquots.ToString();
				Take_d13C_CheckBox.Checked = sample.Take_d13C;
				NotifyCC_S_CheckBox.Checked = sample.NotifyCC_S;
				SulfurSuspectedCheckBox.Checked = sample.SulfurSuspected;
			}
		}
		#endregion implementation-specific

		void populateDropDowns()
		{
            populateVacuumSystemMenu();
			populateGRMenu();
			populateLinePortStateMenu();
			populateProcessComboBox();
		}

		void populateDevicePage()
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
		}

        // This handler can run in any thread. The queue lets the
        // requesting device get back to work right away, without
        // risking a lengthy wait for the UI to update.
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

						#region implementation-specific

						var requester = Req.x;
						if (requester is ValveIndicator vi)
							vi.UpdateDisplay();
						else if (requester is Gauge g)
							g.UpdateDisplay();
						else
							CEGS.EventLog.Record("Can't fulfill request [" + Req.ToString() + "]");
						#endregion implementation-specific
					}
					requestSignal.WaitOne(1000);    // wait for a Control to be enqueued
				}
			}
			catch (Exception e) 	{ MessageBox.Show(e.ToString()); }
		}

        #region Indicator Highlighting

        void valveChanged(object sender, EventArgs e)
		{
            if (!(sender is ValveIndicator vi && vi.Valve is IValve v)) return;
            switch (v.ValveState)
            {
                case ValveStates.Closed:
                    if (vi.BackColor != ClosedColor.BackColor)
                        vi.BackColor = ClosedColor.BackColor;
                    break;
                case ValveStates.Opening:
                    if (vi.BackColor != OpeningColor.BackColor)
                        vi.BackColor = OpeningColor.BackColor;
                    break;
                case ValveStates.Opened:
                    if (vi.BackColor != OpenedColor.BackColor)
                        vi.BackColor = OpenedColor.BackColor;
                    break;
                case ValveStates.Unknown:
                    if (v is IXValve xv)
                    {
                        vi.BackColor = ClosedColor.BackColor.Blend(OpenedColor.BackColor,
                            (double)(xv.ClosedValue - xv.Position) / (xv.ClosedValue - xv.OpenedValue));
                    }
                    else if (vi.BackColor != UnknownColor.BackColor)
                        vi.BackColor = UnknownColor.BackColor;
                    break;
                case ValveStates.Closing:
                    if (vi.BackColor != ClosingColor.BackColor)
                        vi.BackColor = ClosingColor.BackColor;
                    break;
                default:
                    break;
            }
        }

        void pressureChanged(object sender, EventArgs e)
		{
            if (!(sender is Gauge g)) return;
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
			else	// between 10 and 40 C
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
            bool itsOn = false;

            if (pb.Tag is Heater h)
                itsOn = h.IsOn;
            else if (pb.Tag is EurothermFurnace tf)
                itsOn = tf.IsOn;
            else if (pb.Tag is Eurotherm818Furnace tf818)
                itsOn = tf818.IsOn;
            else if (pb.Tag is MtiFurnace tfMti)
                itsOn = tfMti.IsOn;

            pb.BackColor = itsOn ? HotColor.BackColor : OffColor.BackColor;
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

			#region implementation-specific

			#region VM pressure displays
			if (d_IGPower.Visible != (d_IGPower.Tag as IonGauge).Valid)
				d_IGPower.Visible = (d_IGPower.Tag as IonGauge).Valid;
            p_VMLabel.Text = p_VM_HP.Prefix + Utility.sigDigitsString(CEGS.VacuumSystem.Pressure, 2);
			p_VMLabel.BackColor = pressureColor(CEGS.VacuumSystem.Pressure);
            #endregion VM pressure displays

            #region Heater indicators
            decorateHeaterIndicator(d_CC_Q);
			decorateHeaterIndicator(d_CC_S2);
			decorateHeaterIndicator(d_CuAg_F);

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
				t_TC0mux0.SetDisplayValue(ThermalController.List[0].CJ0Temperature);
				t_TC1mux0.SetDisplayValue(ThermalController.List[1].CJ0Temperature);
				t_TC2mux0.SetDisplayValue(ThermalController.List[2].CJ0Temperature);
				t_TC2mux1.SetDisplayValue(ThermalController.List[2].CJ1Temperature);
				#endregion Thermalcontroller multiplexer temperatures

				sbTextBox.Text = SwitchBank0.ToString();

				StringBuilder sb = new StringBuilder();
				foreach (LabJackDaq d in LabJackDaq.List)
					sb.Append(d.ToString());
				updateTextBox(ljTextBox, sb.ToString().TrimEnd());

				v_SPS.Text = ActuatorController0.Voltage.ToString("0.000");
			}

			displayLinePortState(IP_StateLabel);
            displayLinePortState(VP_StateLabel);

            d_fan_pump_HV.BackColor = (d_fan_pump_HV.Tag as OnOffDevice).IsReallyOn ? HighVacuumColor.BackColor : OffColor.BackColor;
			d_fan_IP.BackColor = (d_fan_IP.Tag as OnOffDevice).IsReallyOn ? HighVacuumColor.BackColor : OffColor.BackColor;

			VP_ContentsLabel.Text = (VP_StateLabel.Tag as LinePort).Contents;

			// hovered device state popup
			if (DeviceStatePopupLabel.Visible) showDeviceState();
			#endregion Other device states

			#region Rate-of-change indicators

			// VTT pressure roc display
			if (p_VTT.OverRange)
			{
				roc_pVTT.Text = "----";
				roc_pVTT.BackColor = VacuumColor.BackColor;
			}
			else
			{   // VTTProc is in Torr / sec
                double roc = (p_VTT.Device as Meter).RoC;
                roc_pVTT.Text = (1000 * roc).ToString("0.0");  // show mTorr/s
				if (Math.Abs(roc) <= 0.0005)   // Torr/s
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
                double roc = (p_GM.Device as Meter).RoC;
                roc_pGM.Text = roc.ToString("0.0");
				if (Math.Abs(roc) < 1)	// Torr/s
					roc_pGM.BackColor = HighVacuumColor.BackColor;
				else
					roc_pGM.BackColor = GaugePressureColor.BackColor;
			}

			// Intake manifold pressure roc display
			if (p_IM.OverRange)
			{
				roc_pIM.Text = "----";
				roc_pIM.BackColor = VacuumColor.BackColor;
			}
			else
			{
                double roc = (p_IM.Device as Meter).RoC;
                roc_pIM.Text = roc.ToString("0.0");
				if (Math.Abs(roc) < 1)	// Torr/s
					roc_pIM.BackColor = HighVacuumColor.BackColor;
				else
					roc_pIM.BackColor = GaugePressureColor.BackColor;
			}

			#endregion Rate-of-change indicators

			#region Sample measurement fields

			ugC.Text = CEGS.ugCinMC.Value.ToString("0.0");

			roc_ugC.Text = CEGS.ugCinMC.RoC.Value.ToString("0.00");
			Color mcColor = CEGS.ugCinMC.IsStable ? HighVacuumColor.BackColor : 
				GaugePressureColor.BackColor;
			roc_ugC.BackColor = mcColor;
			ugC.BackColor = mcColor;

			#endregion Sample measurement fields

			#region Graphite reactor contents
			GR1_ContentsLabel.Text = (GR1_panel.Tag as GraphiteReactor).Contents;
			GR2_ContentsLabel.Text = (GR2_panel.Tag as GraphiteReactor).Contents;
            GR3_ContentsLabel.Text = (GR3_panel.Tag as GraphiteReactor).Contents;
            GR4_ContentsLabel.Text = (GR4_panel.Tag as GraphiteReactor).Contents;
            GR5_ContentsLabel.Text = (GR5_panel.Tag as GraphiteReactor).Contents;
            GR6_ContentsLabel.Text = (GR6_panel.Tag as GraphiteReactor).Contents;
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

			if (CEGS.ProcessState == ProcessManager.ProcessStates.Ready)
			{ if (startButton.Text != "Start") startButton.Text = "Start"; }
			else
			{ if (startButton.Text != "Abort") startButton.Text = "Abort"; }
			ProcessStepLabel.Text = CEGS.ProcessStep.Description;
			ProcessSubStepLabel.Text = CEGS.ProcessSubStep.Description;

			ProcessTimeLabel.Text = swToString(CEGS.ProcessTime);
			ProcessStepTimeLabel.Text = tsToString(CEGS.ProcessStep.Elapsed);
			ProcessSubStepTimeLabel.Text = tsToString(CEGS.ProcessSubStep.Elapsed);
			RunTimeLabel.Text = swToString(CEGS.SystemRunTime);
			
            if (!pTargetTextBox.Focused)
				pTargetTextBox.Text = CEGS.VacuumSystem.pTarget.ToString("0.0e0");

			#endregion Process data

			#endregion implementation-specific
		}

		void displayLinePortState(Label linePortLabel)
		{
			Color highlight = WarningColor.BackColor;
			Color normal = ApplicationBackColor.BackColor;

            if (!(linePortLabel.Tag is LinePort linePort))
                return;

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
			debugLabel1.Visible = !string.IsNullOrEmpty(debugLabel1.Text);
			debugLabel2.Visible = !string.IsNullOrEmpty(debugLabel2.Text);
			debugLabel3.Visible = !string.IsNullOrEmpty(debugLabel3.Text);
		}

		void errorMsg()
		{
			string ErrorMsg = "";
			if (!CEGS.Started) return;

			var checkList = new List<Controller>();
			checkList.AddRange(ThermalController.List);
			checkList.AddRange(TubeFurnace.List);
			foreach (var c in checkList)
			{
				if (c.Disconnected)
					ErrorMsg += $"{c.Name} disconnected!\r\n";
				else if (c.ResponseTime > 30000)
					ErrorMsg += $"{c.Name} not responding!\r\n";
			}

			if (ErrorMsg != "" && (statusLabel2.Text == "" || ErrorMsg != CEGS.LastAlertMessage))
				CEGS.Alert("System Error!", ErrorMsg);
			statusLabel2.Text = ErrorMsg;

			if (CEGS.LastAlertMessage == "" || ErrorMsg.Contains(CEGS.LastAlertMessage))
				statusLabel3.Text = "";
			else
			{
				statusLabel3.Text = (ErrorMsg != "" ? "   " : "") +
					"Last Alert: " + CEGS.LastAlertMessage;
			}
		}

		#region MessageBoxes & Dialogs

        void processNotice(Notice notice)
        {
            if (notice.Text == "PlaySound")
            {
                //if (string.IsNullOrEmpty(notice.Caption))
                PlaySound();
                // else
                // play a specific sound (does nothing for now);

            }
            else   // The default behavior is to show the notice in a MessageBox
            {
                // If the notice Type is Request, the user can't access 
                // the UserInterface until this MessageBox is dismissed.
                // If it's type Tell, the user has access to the UserInterface 
                // while this MessageBox is present, but the MessageBox can 
                // become hidden behind the UserInterface or another window.
                MessageBox.Show(notice.Text, notice.Caption);
            }
        }

        public Notice NoticeHandler(Notice notice)
		{
            if (notice.NoticeType == Notice.Type.Tell)
            {
                // Spawn a thread to handle the Notice and 
                // immediately return control to the caller,
                // without waiting for the handler to finish.
                new Thread(new ThreadStart(delegate
                { processNotice(notice); }))
                { IsBackground = true }.Start();

                return null;
            }
            else if (notice.NoticeType == Notice.Type.Request)
			{
                // NOTE: The caller is "on hold" until this method
                // returns.
                processNotice(notice);
				return null;
			}
			else if (notice.NoticeType == Notice.Type.OkCancel)
			{
				if (MessageBox.Show(notice.Text, notice.Caption,
						MessageBoxButtons.OKCancel) == DialogResult.OK)
					return new Notice("Ok");
				else
					return new Notice("Cancel");
			}
			else if (notice.NoticeType == Notice.Type.Warn)
			{
				if (MessageBox.Show(notice.Text, notice.Caption,
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button2) == DialogResult.OK)
					return new Notice("Ok");
				else
					return new Notice("Cancel");
			}
			else
			{
				return new Notice($"Unhandled NoticeType: {notice.NoticeType}");
			}
		}

		public void ShowProcessSequenceEditor(ProcessManager pm)
		{
            if (InvokeRequired)
            {
                Invoke(new Action(() => ShowProcessSequenceEditor(pm)));
                return;
            }
			ProcessSequenceEditor.Show(pm);
		}

		#region implementation-specific
		public static DialogResult SampleInfoBoxDialogResult;
		public bool VerifySampleInfo(bool run = false)
		{
            if (InvokeRequired)
                Invoke(new Action(() => SampleInfoBoxDialogResult = SampleInfoBox.Show(run)));
            else
                SampleInfoBoxDialogResult = SampleInfoBox.Show(run);
			return SampleInfoBoxDialogResult == DialogResult.OK;
		}
		#endregion implementation-specific

		#endregion MessageBoxes & Dialogs

		#region Sound
		void InitializeSound()
		{
			soundPlayer = new SoundPlayer(@"C:\Windows\Media\chord.wav");
			soundPlayer.Load();
		}

		public void PlaySound()
		{
			if (soundPlayer?.IsLoadCompleted ?? false)
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
			if (!(sender is Control c)) return;
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
            if (!(DeviceStatePopupLabel.Tag is Control c))
                return;

            if (c is ValveIndicator vi)
				DeviceStatePopupLabel.Text = vi.Valve.ToString();
			else if (FindGR(c) is GraphiteReactor gr)
				DeviceStatePopupLabel.Text = gr.ToString();
			else if (FindFTC(c) is FTColdfinger ftc)
				DeviceStatePopupLabel.Text = ftc.ToString();
			else if (FindVTC(c) is VTColdfinger vtt)
				DeviceStatePopupLabel.Text = vtt.ToString();
			else if (FindHeater(c) is Heater h)
				DeviceStatePopupLabel.Text = h.ToString();
			else if (FindTempSensor(c) is TempSensor ts)
				DeviceStatePopupLabel.Text = ts.ToString();
			else if (FindLnManifold(c) is LnManifold t)
				DeviceStatePopupLabel.Text = t.ToString();
            else if (FindMassFlowController(c) is MassFlowController mfc)
                DeviceStatePopupLabel.Text = mfc.ToString();
			else if (FindEurothermFurnace(c) is EurothermFurnace tf)
                DeviceStatePopupLabel.Text = tf.ToString();
            else if (FindEurotherm818Furnace(c) is Eurotherm818Furnace tf818)
                DeviceStatePopupLabel.Text = tf818.ToString();
            else if (FindMtiFurnace(c) is MtiFurnace tfMti)
                DeviceStatePopupLabel.Text = tfMti.ToString();
			else if (FindGauge(c) is Gauge g)
				DeviceStatePopupLabel.Text = g.ToString();
            else if (FindVacuumSystem(c) is VacuumSystem vs)
                DeviceStatePopupLabel.Text = vs.ToString();
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
			if (c is Gauge d) return d;
			if (c.Tag is Control c2) return FindGauge(c2);
			return null;
		}

		TempSensor FindTempSensor(Control c)
		{
			if (c.Tag is TempSensor d) return d;
			if (FindGauge(c)?.Device is TempSensor d2) return d2;
			if (c.Tag is Control c2) return FindTempSensor(c2);
			return null;
		}

		Heater FindHeater(Control c)
		{
			if (c.Tag is Heater d) return d;
			if (FindGauge(c)?.Device is Heater d2) return d2;
			if (c.Tag is Control c2) return FindHeater(c2);
			return null;
		}

		VTColdfinger FindVTC(Control c)
		{
			if (c.Tag is VTColdfinger d) return d;
			if (c.Tag is Control c2) return FindVTC(c2);
			return null;
		}

		GraphiteReactor FindGR(Control c)
		{
			if (c.Tag is GraphiteReactor d) return d;
			if (c.Tag is Control c2) return FindGR(c2);
			return null;
		}

		FTColdfinger FindFTC(Control c)
		{
			if (c.Tag is FTColdfinger d) return d;
			if (c.Tag is Control c2) return FindFTC(c2);
			return null;
		}

		LnManifold FindLnManifold(Control c)
		{
			if (c.Tag is LnManifold d) return d;
			if (c.Tag is Control c2) return FindLnManifold(c2);
			return null;
		}

		OnOffDevice FindOnOffDevice(Control c)
		{
			if (c.Tag is OnOffDevice d) return d;
			if (c.Tag is Control c2) return FindOnOffDevice(c2);
			return null;
		}

		DigitalOutput FindDigitalOutput(Control c)
		{
			if (c.Tag is DigitalOutput d) return d;
			if (c.Tag is Control c2) return FindDigitalOutput(c2);
			return null;
		}

		MassFlowController FindMassFlowController(Control c)
		{
			if (c.Tag is MassFlowController d) return d;
			if (c.Tag is Control c2) return FindMassFlowController(c2);
			return null;
		}

        EurothermFurnace FindEurothermFurnace(Control c)
        {
            if (c.Tag is EurothermFurnace d) return d;
            if (c.Tag is Control c2) return FindEurothermFurnace(c2);
            return null;
        }

        Eurotherm818Furnace FindEurotherm818Furnace(Control c)
        {
            if (c.Tag is Eurotherm818Furnace d) return d;
            if (c.Tag is Control c2) return FindEurotherm818Furnace(c2);
            return null;
        }

        MtiFurnace FindMtiFurnace(Control c)
        {
            if (c.Tag is MtiFurnace d) return d;
            if (c.Tag is Control c2) return FindMtiFurnace(c2);
            return null;
        }

        VacuumSystem FindVacuumSystem(Control c)
        {
            if (c.Tag is VacuumSystem d) return d;
            if (c.Tag is Control c2) return FindVacuumSystem(c2);
            return null;
        }

        #endregion Find devices linked to controls via Control.Tag

        void toggleLinkedControlVisibility(object sender, EventArgs e)
		{
            if (sender is Control c && c.Tag is Control lc)
    			lc.Visible = !lc.Visible;
		}

		// Show and shift Focus to the control in sender.Tag.
		void jumpToLinkedControl(object sender, EventArgs e)
		{
            if (sender is Control c && c.Tag is Control lc)
            {
                lc.Show();
                Cursor.Position = lc.PointToScreen(new Point(lc.Width - 5, lc.Height / 2));
                lc.Focus();
                if (lc is TextBox) ((TextBox)lc).SelectAll();
            }
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

		// TODO: make an interface for which these devices all implement SetSetpoint()
		void LeaveSetpoint(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox; if (tb == null) return;

            double x = GetNumber(tb.Text);
            int n = (int)x;

			if (tb.Tag is Heater h)
			{
                tb.Text = n.ToString();

				if (h == (VttPanel.Tag as VTColdfinger).Heater)
                    (VttPanel.Tag as VTColdfinger).RegulatedSetpoint = n;

				h.SetSetpoint(n);
				if (!h.Target.ManualMode)
					tb.Hide();
			}
			else if (tb.Tag is MassFlowController m)
			{
				tb.Text = x.ToString("0.00");
				m.Setpoint = x;
				tb.Hide();
			}
			else if (tb.Tag is TubeFurnace tf)
			{
                // TODO: validity / bounds checking belongs in the class
                if (n <= 0) n = 1;
				else if (n > 1250) n = 1200;
				tb.Text = n.ToString();
				tf.SetSetpoint(n);
				tb.Hide();
			}
        }

        void Leave_pVM_targetTextBox(object sender, EventArgs e)
		{
			CEGS.VacuumSystem.pTarget = double.Parse(pTargetTextBox.Text);
		}

		void LeaveAlertRecipientsTextBox(object sender, EventArgs e)
		{
			CEGS.AlertManager.ContactInfo.AlertRecipients.Clear();
			foreach (string line in AlertRecipientsTextBox.Lines)
				CEGS.AlertManager.ContactInfo.AlertRecipients.Add(line);

		}

		#region implementation-specific
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
			string valid_keys = "0123";

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
		#endregion implementation-specific

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
				ToolStripMenuItem mi = new ToolStripMenuItem(state.ToString())
				{
					Tag = state
				};
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
            Control c = GetSourceControl(sender);
            bool isOn;
            if (FindHeater(c) is Heater h)
                isOn = h.IsOn;
            else if (FindEurothermFurnace(c) is EurothermFurnace f)
                isOn = f.IsOn;
            else if (FindEurotherm818Furnace(c) is Eurotherm818Furnace f2)
                isOn = f2.IsOn;
            else if (FindMtiFurnace(c) is MtiFurnace f3)
                isOn = f3.IsOn;
            else
                return;

			if (isOn)
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
            Control c = GetSourceControl(mi);

            // TODO: need TurnOn / TurnOff interface
            bool turnOn = mi.Text == "Turn On";
            if (FindHeater(c) is Heater h)
            {
                var vtc = VttPanel.Tag as VTColdfinger;
                if (h == vtc.Heater)
                {
                    if (turnOn)
                        vtc.Regulate();
                    else
                    {
                        if (vtc.Coldfinger.State >= FTColdfinger.States.Freeze)
                            vtc.Freeze();
                        else
                            vtc.Stop();
                    }
                }
                else
                {
                    if (turnOn)
                        h.TurnOn();
                    else
                        h.TurnOff();
                }
            }
            else if (FindEurothermFurnace(c) is EurothermFurnace f)
            {
                if (turnOn)
                    f.TurnOn();
                else
                    f.TurnOff();
            }
            else if (FindEurotherm818Furnace(c) is Eurotherm818Furnace f2)
            {
                if (turnOn)
                    f2.TurnOn();
                else
                    f2.TurnOff();
            }
            else if (FindMtiFurnace(c) is MtiFurnace f3)
            {
                if (turnOn)
                    f3.TurnOn();
                else
                    f3.TurnOff();
            }
            else
                return;

		}

		#endregion Heater Context Menu

		#region Meter Gauge Context Menu

		void meterGaugeMenu_Opening(object sender, CancelEventArgs e)
		{ SaveSourceControl(sender); }

		void ZeroNowMenuItem_Click(object sender, EventArgs e)
		{
			Control c = GetSourceControl(sender); if (c == null) return;
			Gauge g = c as Gauge;
			Meter m = (g == null) ? c.Tag as Meter : g.Device as Meter;
			if (m == null) return;
			m.ZeroNow();
		}

        #endregion Meter Gauge Context Menu

        #region AutoManual Context Menu

        void AutoManualMenu_Opening(object sender, CancelEventArgs e)
        {
            if (!CEGS.EnableWatchdogs)
            {
                SaveSourceControl(sender);
                var c = GetSourceControl(sender); if (c == null) return;
                if (!(c.Tag is VacuumSystem vacuumSystem)) return;
                if (!(c is Gauge g)) return;
                if (!(g.Device is IonGauge ig)) return;

                AutoMenuItem.Checked = vacuumSystem.IonGaugeAuto;
                ManualOnMenuItem.Enabled = !AutoMenuItem.Checked;
                ManualOnMenuItem.Checked = ig.IonGaugeEnable.IsOn;
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
            Control c = GetSourceControl(sender); if (c == null) return;
            if (!(c.Tag is VacuumSystem vacuumSystem)) return;
            vacuumSystem.IonGaugeAuto = AutoMenuItem.Checked;
            ManualOnMenuItem.Enabled = !AutoMenuItem.Checked;
        }

        void ManualOnMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            if (!(c is Gauge g)) return;
            if (!(g.Device is IonGauge ig)) return;
            ig.IonGaugeEnable.SetOutput(ManualOnMenuItem.Checked);
        }

        #endregion AutoManual Context Menu

        #region Valve Context Menu

        void ValveMenu_Opening(object sender, CancelEventArgs e)
		{
			SaveSourceControl(sender);

			var c = GetSourceControl(sender); if (c == null) return;
			var vi = c as ValveIndicator; if (vi == null) return;
			var v = vi.Valve as IValve; if (v == null) return;

			valveMenu.Items.Clear();
			foreach (var opName in v.Operations)
			{
				var valveMenuItem = new ToolStripMenuItem(opName);
				valveMenuItem.Click += new EventHandler(valveMenuItem_Click);
				valveMenu.Items.Add(valveMenuItem);
			}
        }

        void valveMenuItem_Click(object sender, EventArgs e)
		{
			var c = GetSourceControl(sender); if (c == null) return;
			var vi = c as ValveIndicator; if (vi == null) return;
			var v = vi.Valve as IValve; if (v == null) return;

            v.DoOperation((sender as ToolStripMenuItem).Text);
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

            var vtc = (VttPanel.Tag as VTColdfinger);

			if (ftc == vtc.Coldfinger)
			{
				switch (ftcState)
				{
					case FTColdfinger.States.Raise:
						vtc.Raise();
						break;
					case FTColdfinger.States.Freeze:
						vtc.Freeze();
						break;
					case FTColdfinger.States.Standby:
						vtc.Standby();
						break;
					case FTColdfinger.States.Stop:
						vtc.Stop();
						break;
					case FTColdfinger.States.Thaw:
						vtc.Thaw();
						break;
				}
			}
			else
				ftc.EnsureState(ftcState);
		}

		#endregion FTC Context Menu

		#region LnManifold Context Menu

		void LnManifoldMenu_Opening(object sender, CancelEventArgs e)
		{
			SaveSourceControl(sender);
			Control c = GetSourceControl(sender); if (c == null) return;
			object d = c.Tag;
			bool isOn = false;
			if (d is LnManifold)
				isOn = (d as LnManifold).IsActive;
			else
				return;
			LnManifoldTurnOnOffMenuItem.Text = isOn ? "Turn Off" : "Turn On";
		}

		void LnManifoldTurnOnOffMenuItem_Click(object sender, EventArgs e)
		{
			Control c = GetSourceControl(sender); if (c == null) return;
			LnManifold t = c.Tag as LnManifold; if (t == null) return;
			bool onOff = LnManifoldTurnOnOffMenuItem.Text == "Turn On";
			if (t == CEGS.LnManifold) CEGS.LnManifold.KeepActive = onOff;
			t.IsActive = onOff;
		}

		void LnManifoldFillNowMenuItem_Click(object sender, EventArgs e)
		{
			Control c = GetSourceControl(sender); if (c == null) return;
			LnManifold t = c.Tag as LnManifold; if (t == null) return;
			if (t == CEGS.LnManifold) CEGS.LnManifold.KeepActive = true;
			t.IsActive = true;
			t.ForceFill();
		}

		#endregion LnManifold Context Menu

		#region VTC Context Menu

		void VtcMenu_Opening(object sender, CancelEventArgs e)
		{
			SaveSourceControl(sender);
			Control c = GetSourceControl(sender); if (c == null) return;
			VTColdfinger vtc = FindVTC(c); if (vtc == null) return;

			VtcRegulateMenuItem.CheckState =
				VtcRaiseMenuItem.CheckState =
				VtcFreezeMenuItem.CheckState =
				VtcThawMenuItem.CheckState =
				VtcStopMenuItem.CheckState =
				VtcStandbyMenuItem.CheckState = CheckState.Unchecked;

			switch (vtc.State)
			{
				case VTColdfinger.States.Regulate:
					VtcRegulateMenuItem.CheckState = CheckState.Checked;
					break;
				case VTColdfinger.States.Raise:
					VtcRaiseMenuItem.CheckState = CheckState.Checked;
					break;
				case VTColdfinger.States.Freeze:
					VtcFreezeMenuItem.CheckState = CheckState.Checked;
					break;
				case VTColdfinger.States.Thaw:
					VtcThawMenuItem.CheckState = CheckState.Checked;
					break;
				case VTColdfinger.States.Stop:
					VtcStopMenuItem.CheckState = CheckState.Checked;
					break;
				case VTColdfinger.States.Standby:
					VtcStandbyMenuItem.CheckState = CheckState.Checked;
					break;
				default:
					break;
			}
		}

		private void VtcMenuItemClick(object sender, EventArgs e)
		{
			Control c = GetSourceControl(sender); if (c == null) return;
			VTColdfinger vtc = FindVTC(c); if (vtc == null) return;
			VTColdfinger.States vtcState = (VTColdfinger.States)Enum.Parse(typeof(VTColdfinger.States), (sender as ToolStripMenuItem).Text);

			vtc.EnsureState(vtcState);
		}

		#endregion VTC Context Menu

		#region OnOffDevice Context Menu

		void OnOffDeviceMenu_Opening(object sender, CancelEventArgs e)
		{
			SaveSourceControl(sender);  // save SourceControl so submenu items can find it

			if (FindOnOffDevice(GetSourceControl(sender)) is OnOffDevice d)
				OnMenuItem.Checked = d.IsOn;
        }

        void OnMenuItem_CheckedChanged(object sender, EventArgs e)
		{
			Control c = GetSourceControl(sender); if (c == null) return;

			if (FindOnOffDevice(c) is OnOffDevice d)
			{
				if (OnMenuItem.Checked)
					d.TurnOn();
				else
					d.TurnOff();
			}
        }

        #endregion OnOffDevice Context Menu

        #region VacuumSystem Menu
        void populateVacuumSystemMenu()
        {
            foreach (VacuumSystem.TargetStates state in (VacuumSystem.TargetStates[])Enum.GetValues(typeof(VacuumSystem.TargetStates)))
            {
                ToolStripMenuItem mi = new ToolStripMenuItem(state.ToString())
                {
                    Tag = state
                };
                mi.Click += new EventHandler(VacuumSystemMenuItem_Click);
                VacuumSystemMenu.Items.Add(mi);
            }
        }

        void VacuumSystemMenu_Opening(object sender, CancelEventArgs e)
        {
			SaveSourceControl(sender);
			Control c = GetSourceControl(sender); if (c == null) return;
			VacuumSystemMenuTitle.Text = c.AccessibleName;
			VacuumSystem vacuumSystem = c.Tag as VacuumSystem; if (vacuumSystem == null) return;
			foreach (ToolStripMenuItem mi in VacuumSystemMenu.Items)
			{
				if (mi.Tag is VacuumSystem.TargetStates)
				{
					if ((VacuumSystem.TargetStates)(mi.Tag) == vacuumSystem.TargetState)
						mi.CheckState = CheckState.Checked;
					else
						mi.CheckState = CheckState.Unchecked;
				}
			}
		}

		void VacuumSystemMenuItem_Click(object sender, EventArgs e)
        {
            Control c = GetSourceControl(sender); if (c == null) return;
            ToolStripMenuItem mi = sender as ToolStripMenuItem; if (mi == null) return;
            VacuumSystem vacuumSystem = c.Tag as VacuumSystem; if (vacuumSystem == null) return;
            vacuumSystem.SetTargetState((VacuumSystem.TargetStates)mi.Tag);
        }

        #endregion VacuumSystem Menu

        #region State Menus

        void populateLinePortStateMenu()
		{
			foreach (LinePort.States state in (LinePort.States[])Enum.GetValues(typeof(LinePort.States)))
			{
				ToolStripMenuItem mi = new ToolStripMenuItem(state.ToString())
				{
					Tag = state
				};
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
			else
				CEGS.AbortRunningProcess();
            ProcessComboBox.Focus();
        }

		void AlertTestButton_Click(object sender, EventArgs e)
		{
			CEGS.Alert("Alert Test", "Alert Test");
		}

		void tryToStartSelectedProcess()
		{
			var processName = ((KeyValuePair<string, ThreadStart>)
				ProcessComboBox.SelectedItem).Key;
			CEGS.RunProcess(processName);
		}

		void valveDoubleClick(object sender, EventArgs e)
		{
			var vi = sender as ValveIndicator; if (vi == null) return;
			var v = vi.Valve as IValve; if (v == null) return;
			switch (v.ValveState)
			{
				case ValveStates.Closed:
					v.Open();
					break;
				case ValveStates.Opened:
				case ValveStates.Unknown:
					v.Close();
					break;
				case ValveStates.Closing:
				case ValveStates.Opening:
                    v.DoOperation("Stop");  // does nothing if Stop Operation is not available
					break;
				default:
					break;
			}
		}

		#region implementation-specific
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
		#endregion implementation-specific

		void ClipPressureCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ClipPressure(ClipPressureCheckBox.Checked);
		}

		#region implementation-specific
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
				t_LnManifold.Minimum = lnbp; t_LnManifold.ClipMinimum = true;
				t_tabletop.Minimum = lnbp; t_tabletop.ClipMinimum = true;
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
				t_LnManifold.ClipMinimum = false;
				t_tabletop.ClipMinimum = false;
			}
		}
		#endregion implementation-specific

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
		{ CEGS.AlertManager.clearLastAlertMessage(); }

		#region implementation-specific
		void EnableWatchdogsCheckBox_CheckedChanged(object sender, EventArgs e)
		{ CEGS.EnableWatchdogs = EnableWatchdogsCheckBox.Checked; }

		void EnableAutozeroCheckBox_CheckedChanged(object sender, EventArgs e)
		{ CEGS.EnableAutozero = EnableAutozeroCheckBox.Checked; }
		#endregion implementation-specific

		List<KeyValuePair<string, object>> DeviceList(string categoryName)
		{
			PropertyInfo categoryPropertyInfo = typeof(CEGS).GetProperty(categoryName);
			Type systemComponentsPropertyType = categoryPropertyInfo.PropertyType;
			object systemComponentsProperty = categoryPropertyInfo.GetValue(CEGS);

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
			List<string> SystemComponentsFilter = new List<string>
			{
				"ProcessSequences",
				"Samples"
			};

			PropertyInfo[] syscomps = (PropertyInfo[])(CEGS.GetType().GetProperties().Clone());
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
					TreeNode d = new TreeNode(device.Key)
					{
						Tag = device.Value
					};
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
					var groupBox = new GroupBox
					{
						Text = node.Name,
						Location = new Point(gbPad, location.Y),
						Width = control.Width - 2 * gbPad,
						Height = 20,
						AutoSize = true
					};
					control.Controls.Add(groupBox);
					control = groupBox;
				}

				foreach (SettingNode sn in node.Children)
					PopulateControl(control, sn);

				return;
			}

			Label Name = new Label
			{
				TextAlign = ContentAlignment.MiddleLeft,
				AutoSize = true,
				MinimumSize = new Size(80, 18),
				Text = node.Name,
				Location = location
			};
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
				valueControl = new TextBox
				{
					Text = leaf.Value.ToString()
				};
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
