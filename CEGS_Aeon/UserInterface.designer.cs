using System;
namespace CEGS_Aeon_Namespace {
    partial class UserInterface {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
			this.DiagramPictureBox = new System.Windows.Forms.PictureBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.valveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.valveStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GRMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.GRMenuTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.sp_CC_S = new System.Windows.Forms.TextBox();
			this.sp_GR1_F = new System.Windows.Forms.TextBox();
			this.sp_GR2_F = new System.Windows.Forms.TextBox();
			this.sp_GR3_F = new System.Windows.Forms.TextBox();
			this.sp_GR4_F = new System.Windows.Forms.TextBox();
			this.sp_GR5_F = new System.Windows.Forms.TextBox();
			this.sp_GR6_F = new System.Windows.Forms.TextBox();
			this.p_VMLabel = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.d_fan_IP = new System.Windows.Forms.PictureBox();
			this.OnOffMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.OnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vi_new_flow = new HACS.Components.Controls.ValveIndicator();
			this.d_AimPower = new System.Windows.Forms.Label();
			this.p_MC = new HACS.Components.Controls.Gauge();
			this.meterDisplayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.meterZeroNowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VMPressurePictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.VM_Gauges_Panel = new System.Windows.Forms.Panel();
			this.p_VM_HP = new HACS.Components.Controls.Gauge();
			this.p_VM_IG = new HACS.Components.Controls.Gauge();
			this.AutoManualMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AutoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManualOnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.d_CC_S2 = new System.Windows.Forms.PictureBox();
			this.heaterMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.HtrPowerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vi_VTTR_VM = new HACS.Components.Controls.ValveIndicator();
			this.sp_VTT = new System.Windows.Forms.TextBox();
			this.sp_FTC_air = new System.Windows.Forms.TextBox();
			this.t_VTT = new HACS.Components.Controls.Gauge();
			this.t_FTC_air = new HACS.Components.Controls.Gauge();
			this.MCUPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_MC_MCL = new HACS.Components.Controls.ValveIndicator();
			this.t_MC_CF = new HACS.Components.Controls.Gauge();
			this.ftcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ftcRaiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ftcFreezeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ftcThawMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ftcStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ftcStandbyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MCLPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_VTTL_VTTR = new HACS.Components.Controls.ValveIndicator();
			this.d_CuAg_F = new System.Windows.Forms.PictureBox();
			this.CuAgPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.VttPanel = new System.Windows.Forms.Panel();
			this.t_VTT_wire = new HACS.Components.Controls.Gauge();
			this.t_VTT_top = new HACS.Components.Controls.Gauge();
			this.t_VTT_CF = new HACS.Components.Controls.Gauge();
			this.VttPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vttMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.vttRegulateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vttRaiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vttFreezeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vttThawMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vttStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vttStandbyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VttLPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.VttRPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.ro_roc_pGM = new System.Windows.Forms.Label();
			this.t_GM = new HACS.Components.Controls.Gauge();
			this.ro_roc_ugC = new System.Windows.Forms.Label();
			this.vi_CO2_GM = new HACS.Components.Controls.ValveIndicator();
			this.vi_H2_GM = new HACS.Components.Controls.ValveIndicator();
			this.vi_GM_VM = new HACS.Components.Controls.ValveIndicator();
			this.vi_split_GM = new HACS.Components.Controls.ValveIndicator();
			this.vi_BP_GM = new HACS.Components.Controls.ValveIndicator();
			this.vi_d13C_GM = new HACS.Components.Controls.ValveIndicator();
			this.vi_d13C_CF = new HACS.Components.Controls.ValveIndicator();
			this.GMPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.d13CPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_split_VM = new HACS.Components.Controls.ValveIndicator();
			this.vi_MC_split = new HACS.Components.Controls.ValveIndicator();
			this.vi_CuAg_MC = new HACS.Components.Controls.ValveIndicator();
			this.vi_VTTR_CuAg = new HACS.Components.Controls.ValveIndicator();
			this.SplitPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.SampleGroupBox = new CEGS_Aeon_Namespace.CustomGroupBox();
			this.label45 = new System.Windows.Forms.Label();
			this.AliquotDisplay = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.ProcessDisplay = new System.Windows.Forms.Label();
			this.MassDisplay = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SampleIDDisplay = new System.Windows.Forms.Label();
			this.SulfurSuspectedCheckBox = new System.Windows.Forms.CheckBox();
			this.Take_d13C_CheckBox = new System.Windows.Forms.CheckBox();
			this.FiltrationsTextBox = new System.Windows.Forms.TextBox();
			this.Only_d13C_CheckBox = new System.Windows.Forms.CheckBox();
			this.NotifyCC_S_CheckBox = new System.Windows.Forms.CheckBox();
			this.t_MC = new HACS.Components.Controls.Gauge();
			this.MCPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.roc_pVTT = new System.Windows.Forms.Label();
			this.p_VTT = new HACS.Components.Controls.Gauge();
			this.p_IM = new HACS.Components.Controls.Gauge();
			this.VMPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.t_CC_S = new HACS.Components.Controls.Gauge();
			this.vi_IP_IM = new HACS.Components.Controls.ValveIndicator();
			this.d_CC_Q = new System.Windows.Forms.PictureBox();
			this.IPPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_He_IM = new HACS.Components.Controls.ValveIndicator();
			this.vi_IM_VTTL = new HACS.Components.Controls.ValveIndicator();
			this.vi_IM_VM = new HACS.Components.Controls.ValveIndicator();
			this.vi_O2_IM = new HACS.Components.Controls.ValveIndicator();
			this.IMPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_GR1_GM = new HACS.Components.Controls.ValveIndicator();
			this.GR1PictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.d_GR1_F = new OvalPictureBox();
			this.vi_GR6_GM = new HACS.Components.Controls.ValveIndicator();
			this.GR6PictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_GR5_GM = new HACS.Components.Controls.ValveIndicator();
			this.GR5PictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_GR4_GM = new HACS.Components.Controls.ValveIndicator();
			this.GR4PictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_GR3_GM = new HACS.Components.Controls.ValveIndicator();
			this.GR3PictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_GR2_GM = new HACS.Components.Controls.ValveIndicator();
			this.GR2PictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.v_LN_supply = new HACS.Components.Controls.Gauge();
			this.d_GR6_F = new OvalPictureBox();
			this.d_GR5_F = new OvalPictureBox();
			this.d_GR4_F = new OvalPictureBox();
			this.d_GR3_F = new OvalPictureBox();
			this.d_GR2_F = new OvalPictureBox();
			this.vi_VP_d13C = new HACS.Components.Controls.ValveIndicator();
			this.d13CCFPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.VPVPictureBox = new CEGS_Aeon_Namespace.TransparentPictureBox();
			this.vi_MC_MCU = new HACS.Components.Controls.ValveIndicator();
			this.p_Ambient = new HACS.Components.Controls.Gauge();
			this.t_muxAIN13 = new HACS.Components.Controls.Gauge();
			this.label6 = new System.Windows.Forms.Label();
			this.d_LN_Tank = new System.Windows.Forms.Panel();
			this.tankMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tankTurnOnOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tankFillNowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label65 = new System.Windows.Forms.Label();
			this.label64 = new System.Windows.Forms.Label();
			this.label63 = new System.Windows.Forms.Label();
			this.label62 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.vi_LN_GR3 = new HACS.Components.Controls.ValveIndicator();
			this.t_tank = new HACS.Components.Controls.Gauge();
			this.vi_LN_CuAg = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_MC = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_VTT = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_GR1 = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_d13C = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_GR2 = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_VP = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_GR4 = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_GR6 = new HACS.Components.Controls.ValveIndicator();
			this.vi_LN_GR5 = new HACS.Components.Controls.ValveIndicator();
			this.LNTankLabel = new System.Windows.Forms.Label();
			this.VP_ContentsLabel = new System.Windows.Forms.Label();
			this.debugLabel3 = new System.Windows.Forms.Label();
			this.debugLabel2 = new System.Windows.Forms.Label();
			this.debugLabel1 = new System.Windows.Forms.Label();
			this.t_tabletop = new HACS.Components.Controls.Gauge();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.roc_pIM = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.d_FTC_air = new System.Windows.Forms.PictureBox();
			this.GR6_ContentsLabel = new System.Windows.Forms.Label();
			this.GR5_ContentsLabel = new System.Windows.Forms.Label();
			this.GR4_ContentsLabel = new System.Windows.Forms.Label();
			this.GR3_ContentsLabel = new System.Windows.Forms.Label();
			this.GR2_ContentsLabel = new System.Windows.Forms.Label();
			this.GR1_ContentsLabel = new System.Windows.Forms.Label();
			this.ProcessComboBox = new CEGS_Aeon_Namespace.CustomComboBox();
			this.VP_StateLabel = new System.Windows.Forms.Label();
			this.LinePortStateMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.LinePortStateMenuTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.IP_StateLabel = new System.Windows.Forms.Label();
			this.GR2_panel = new System.Windows.Forms.Panel();
			this.p_GR2 = new HACS.Components.Controls.Gauge();
			this.t_GR2_F = new HACS.Components.Controls.Gauge();
			this.t_GR2_CF = new HACS.Components.Controls.Gauge();
			this.roc_pGM = new System.Windows.Forms.Label();
			this.roc_pForeline = new System.Windows.Forms.Label();
			this.RunTimeLabel = new System.Windows.Forms.Label();
			this.ProcessTimeLabel = new System.Windows.Forms.Label();
			this.ProcessStepTimeLabel = new System.Windows.Forms.Label();
			this.ProcessSubStepTimeLabel = new System.Windows.Forms.Label();
			this.t_d13C_CF = new HACS.Components.Controls.Gauge();
			this.t_VP = new HACS.Components.Controls.Gauge();
			this.vi_He_VTTL = new HACS.Components.Controls.ValveIndicator();
			this.ProcessSubStepLabel = new System.Windows.Forms.Label();
			this.ProcessStepLabel = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.vi_B = new HACS.Components.Controls.ValveIndicator();
			this.vi_LV = new HACS.Components.Controls.ValveIndicator();
			this.vi_HV = new HACS.Components.Controls.ValveIndicator();
			this.vi_CO2_GM_flow = new HACS.Components.Controls.ValveIndicator();
			this.vi_H2_GM_flow = new HACS.Components.Controls.ValveIndicator();
			this.vi_He_GM_flow = new HACS.Components.Controls.ValveIndicator();
			this.vi_He_GM = new HACS.Components.Controls.ValveIndicator();
			this.vi_VTT_flow = new HACS.Components.Controls.ValveIndicator();
			this.roc_ugC = new System.Windows.Forms.Label();
			this.ugCLabel = new System.Windows.Forms.Label();
			this.ugC = new System.Windows.Forms.Label();
			this.label66 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.HeLabel4 = new System.Windows.Forms.Label();
			this.HeLabel2 = new System.Windows.Forms.Label();
			this.HeLabel1 = new System.Windows.Forms.Label();
			this.H2Label = new System.Windows.Forms.Label();
			this.CO2Label = new System.Windows.Forms.Label();
			this.O2Label1 = new System.Windows.Forms.Label();
			this.d_Pump_HV = new System.Windows.Forms.PictureBox();
			this.d_RoughingPump = new System.Windows.Forms.PictureBox();
			this.GR6_panel = new System.Windows.Forms.Panel();
			this.p_GR6 = new HACS.Components.Controls.Gauge();
			this.t_GR6_F = new HACS.Components.Controls.Gauge();
			this.t_GR6_CF = new HACS.Components.Controls.Gauge();
			this.GR5_panel = new System.Windows.Forms.Panel();
			this.p_GR5 = new HACS.Components.Controls.Gauge();
			this.t_GR5_F = new HACS.Components.Controls.Gauge();
			this.t_GR5_CF = new HACS.Components.Controls.Gauge();
			this.GR4_panel = new System.Windows.Forms.Panel();
			this.p_GR4 = new HACS.Components.Controls.Gauge();
			this.t_GR4_F = new HACS.Components.Controls.Gauge();
			this.t_GR4_CF = new HACS.Components.Controls.Gauge();
			this.GR3_panel = new System.Windows.Forms.Panel();
			this.p_GR3 = new HACS.Components.Controls.Gauge();
			this.t_GR3_F = new HACS.Components.Controls.Gauge();
			this.t_GR3_CF = new HACS.Components.Controls.Gauge();
			this.GR1_panel = new System.Windows.Forms.Panel();
			this.p_GR1 = new HACS.Components.Controls.Gauge();
			this.t_GR1_F = new HACS.Components.Controls.Gauge();
			this.t_GR1_CF = new HACS.Components.Controls.Gauge();
			this.t_CuAg_CF = new HACS.Components.Controls.Gauge();
			this.p_Foreline = new HACS.Components.Controls.Gauge();
			this.p_GM = new HACS.Components.Controls.Gauge();
			this.label25 = new System.Windows.Forms.Label();
			this.pVM_targetTextBox = new System.Windows.Forms.TextBox();
			this.v_SPS = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ClipTemperatureCheckBox = new System.Windows.Forms.CheckBox();
			this.ClipPressureCheckBox = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabControlPanel = new System.Windows.Forms.TabPage();
			this.tabBackPanel = new System.Windows.Forms.TabPage();
			this.sbTextBox = new System.Windows.Forms.TextBox();
			this.ljTextBox = new System.Windows.Forms.TextBox();
			this.t_TC2mux0 = new HACS.Components.Controls.Gauge();
			this.t_TC2mux1 = new HACS.Components.Controls.Gauge();
			this.v_5VSupply = new HACS.Components.Controls.Gauge();
			this.t_TC1mux0 = new HACS.Components.Controls.Gauge();
			this.t_TC0mux0 = new HACS.Components.Controls.Gauge();
			this.p_Bakeout = new HACS.Components.Controls.Gauge();
			this.tabSettings = new System.Windows.Forms.TabPage();
			this.DevicePopupsCheckBox = new System.Windows.Forms.CheckBox();
			this.EnableAutozeroCheckBox = new System.Windows.Forms.CheckBox();
			this.EnableWatchdogsCheckBox = new System.Windows.Forms.CheckBox();
			this.label35 = new System.Windows.Forms.Label();
			this.AlertRecipientsTextBox = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.LastGRTextBox = new System.Windows.Forms.TextBox();
			this.WarningColorLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.ApplicationBackColorLabel = new System.Windows.Forms.Label();
			this.OpenedColorLabel = new System.Windows.Forms.Label();
			this.UnknownColorLabel = new System.Windows.Forms.Label();
			this.NeutralColorLabel = new System.Windows.Forms.Label();
			this.ClosedColorLabel = new System.Windows.Forms.Label();
			this.ErrorColorLabel = new System.Windows.Forms.Label();
			this.GaugePressureColorLabel = new System.Windows.Forms.Label();
			this.ClosingColorLabel = new System.Windows.Forms.Label();
			this.VacuumColorLabel = new System.Windows.Forms.Label();
			this.OpeningColorLabel = new System.Windows.Forms.Label();
			this.HighVacuumColorLabel = new System.Windows.Forms.Label();
			this.CoolColorLabel = new System.Windows.Forms.Label();
			this.ColdColorLabel = new System.Windows.Forms.Label();
			this.WarmColorLabel = new System.Windows.Forms.Label();
			this.HotColorLabel = new System.Windows.Forms.Label();
			this.OffColorLabel = new System.Windows.Forms.Label();
			this.OnColorLabel = new System.Windows.Forms.Label();
			this.WarningColor = new System.Windows.Forms.Label();
			this.ApplicationBackColor = new System.Windows.Forms.Label();
			this.OpenedColor = new System.Windows.Forms.Label();
			this.UnknownColor = new System.Windows.Forms.Label();
			this.GaugePressureColor = new System.Windows.Forms.Label();
			this.NeutralColor = new System.Windows.Forms.Label();
			this.ClosingColor = new System.Windows.Forms.Label();
			this.ClosedColor = new System.Windows.Forms.Label();
			this.OpeningColor = new System.Windows.Forms.Label();
			this.ErrorColor = new System.Windows.Forms.Label();
			this.VacuumColor = new System.Windows.Forms.Label();
			this.HighVacuumColor = new System.Windows.Forms.Label();
			this.CoolColor = new System.Windows.Forms.Label();
			this.ColdColor = new System.Windows.Forms.Label();
			this.WarmColor = new System.Windows.Forms.Label();
			this.HotColor = new System.Windows.Forms.Label();
			this.OffColor = new System.Windows.Forms.Label();
			this.OnColor = new System.Windows.Forms.Label();
			this.tabDeviceSettings = new System.Windows.Forms.TabPage();
			this.ScrollPanel = new System.Windows.Forms.Panel();
			this.SettingsPanel = new System.Windows.Forms.Panel();
			this.DeviceLabel = new System.Windows.Forms.Label();
			this.separator1 = new System.Windows.Forms.Label();
			this.DevicesPanel = new System.Windows.Forms.Panel();
			this.DeviceSearchBox = new System.Windows.Forms.TextBox();
			this.DeviceNavTree = new System.Windows.Forms.TreeView();
			this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.DeviceStatePopupLabel = new CEGS_Aeon_Namespace.MouseTransparentLabel();
			this.GraphiteNumberTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.DiagramPictureBox)).BeginInit();
			this.valveMenu.SuspendLayout();
			this.GRMenu.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.d_fan_IP)).BeginInit();
			this.OnOffMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vi_new_flow)).BeginInit();
			this.meterDisplayMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VMPressurePictureBox)).BeginInit();
			this.VM_Gauges_Panel.SuspendLayout();
			this.AutoManualMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.d_CC_S2)).BeginInit();
			this.heaterMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTTR_VM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MCUPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_MC_MCL)).BeginInit();
			this.ftcMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MCLPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTTL_VTTR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_CuAg_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CuAgPictureBox)).BeginInit();
			this.VttPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VttPictureBox)).BeginInit();
			this.vttMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VttLPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VttRPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_CO2_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_H2_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GM_VM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_split_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_BP_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_d13C_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_d13C_CF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GMPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d13CPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_split_VM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_MC_split)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_CuAg_MC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTTR_CuAg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitPictureBox)).BeginInit();
			this.SampleGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MCPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VMPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_IP_IM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_CC_Q)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IPPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_IM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_IM_VTTL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_IM_VM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_O2_IM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IMPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR1_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GR1PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR1_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR6_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GR6PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR5_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GR5PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR4_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GR4PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR3_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GR3PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR2_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GR2PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR6_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR5_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR4_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR3_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR2_F)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VP_d13C)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d13CCFPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VPVPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_MC_MCU)).BeginInit();
			this.d_LN_Tank.SuspendLayout();
			this.tankMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_CuAg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_MC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_VTT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_d13C)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_VP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_FTC_air)).BeginInit();
			this.LinePortStateMenu.SuspendLayout();
			this.GR2_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_VTTL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_B)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_HV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_CO2_GM_flow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_H2_GM_flow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_GM_flow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_GM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTT_flow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_Pump_HV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.d_RoughingPump)).BeginInit();
			this.GR6_panel.SuspendLayout();
			this.GR5_panel.SuspendLayout();
			this.GR4_panel.SuspendLayout();
			this.GR3_panel.SuspendLayout();
			this.GR1_panel.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabControlPanel.SuspendLayout();
			this.tabBackPanel.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.tabDeviceSettings.SuspendLayout();
			this.ScrollPanel.SuspendLayout();
			this.DevicesPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// DiagramPictureBox
			// 
			this.DiagramPictureBox.BackColor = System.Drawing.Color.Silver;
			this.DiagramPictureBox.ErrorImage = null;
			this.DiagramPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DiagramPictureBox.Image")));
			this.DiagramPictureBox.InitialImage = null;
			this.DiagramPictureBox.Location = new System.Drawing.Point(5, 3);
			this.DiagramPictureBox.Name = "DiagramPictureBox";
			this.DiagramPictureBox.Size = new System.Drawing.Size(788, 326);
			this.DiagramPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.DiagramPictureBox.TabIndex = 0;
			this.DiagramPictureBox.TabStop = false;
			this.DiagramPictureBox.Tag = "";
			this.DiagramPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseClick);
			this.DiagramPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseDoubleClick);
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Location = new System.Drawing.Point(731, 433);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 3;
			this.closeButton.TabStop = false;
			this.closeButton.Tag = "";
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			this.closeButton.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.closeButton.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
			this.openFileDialog1.Tag = "";
			this.openFileDialog1.Title = "Select a picture file";
			// 
			// colorDialog1
			// 
			this.colorDialog1.Tag = "";
			// 
			// valveMenu
			// 
			this.valveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valveStopMenuItem});
			this.valveMenu.Name = "valveContextMenu";
			this.valveMenu.ShowImageMargin = false;
			this.valveMenu.Size = new System.Drawing.Size(74, 26);
			this.valveMenu.Tag = "";
			this.valveMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ValveMenu_Opening);
			// 
			// valveStopMenuItem
			// 
			this.valveStopMenuItem.Name = "valveStopMenuItem";
			this.valveStopMenuItem.Size = new System.Drawing.Size(73, 22);
			this.valveStopMenuItem.Tag = "";
			this.valveStopMenuItem.Text = "Stop";
			this.valveStopMenuItem.Click += new System.EventHandler(this.valveStopMenuItem_Click);
			// 
			// GRMenu
			// 
			this.GRMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GRMenuTitle});
			this.GRMenu.Name = "valveContextMenu";
			this.GRMenu.ShowCheckMargin = true;
			this.GRMenu.ShowImageMargin = false;
			this.GRMenu.Size = new System.Drawing.Size(98, 26);
			this.GRMenu.Tag = "";
			this.GRMenu.Opening += new System.ComponentModel.CancelEventHandler(this.GRMenu_Opening);
			// 
			// GRMenuTitle
			// 
			this.GRMenuTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.GRMenuTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GRMenuTitle.Name = "GRMenuTitle";
			this.GRMenuTitle.Size = new System.Drawing.Size(97, 22);
			this.GRMenuTitle.Text = "Title";
			this.GRMenuTitle.ToolTipText = "Device Name";
			// 
			// sp_CC_S
			// 
			this.sp_CC_S.AccessibleDescription = "CC sample furnace setpoint";
			this.sp_CC_S.AccessibleName = "CC sample furnace setpoint";
			this.sp_CC_S.Location = new System.Drawing.Point(41, 305);
			this.sp_CC_S.Name = "sp_CC_S";
			this.sp_CC_S.Size = new System.Drawing.Size(46, 20);
			this.sp_CC_S.TabIndex = 65;
			this.sp_CC_S.TabStop = false;
			this.sp_CC_S.Tag = "";
			this.sp_CC_S.Text = "200";
			this.sp_CC_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_CC_S.Visible = false;
			this.sp_CC_S.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_CC_S.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_CC_S.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_GR1_F
			// 
			this.sp_GR1_F.AccessibleDescription = "GR1 furnace setpoint";
			this.sp_GR1_F.Location = new System.Drawing.Point(0, 20);
			this.sp_GR1_F.Margin = new System.Windows.Forms.Padding(0);
			this.sp_GR1_F.Name = "sp_GR1_F";
			this.sp_GR1_F.Size = new System.Drawing.Size(35, 20);
			this.sp_GR1_F.TabIndex = 57;
			this.sp_GR1_F.TabStop = false;
			this.sp_GR1_F.Tag = "";
			this.sp_GR1_F.Text = "400";
			this.sp_GR1_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_GR1_F.Visible = false;
			this.sp_GR1_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_GR1_F.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_GR1_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_GR2_F
			// 
			this.sp_GR2_F.AccessibleDescription = "GR2 furnace setpoint";
			this.sp_GR2_F.Location = new System.Drawing.Point(0, 20);
			this.sp_GR2_F.Margin = new System.Windows.Forms.Padding(0);
			this.sp_GR2_F.Name = "sp_GR2_F";
			this.sp_GR2_F.Size = new System.Drawing.Size(35, 20);
			this.sp_GR2_F.TabIndex = 58;
			this.sp_GR2_F.TabStop = false;
			this.sp_GR2_F.Tag = "";
			this.sp_GR2_F.Text = "400";
			this.sp_GR2_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_GR2_F.Visible = false;
			this.sp_GR2_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_GR2_F.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_GR2_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_GR3_F
			// 
			this.sp_GR3_F.AccessibleDescription = "GR3 furnace setpoint";
			this.sp_GR3_F.Location = new System.Drawing.Point(0, 20);
			this.sp_GR3_F.Margin = new System.Windows.Forms.Padding(0);
			this.sp_GR3_F.Name = "sp_GR3_F";
			this.sp_GR3_F.Size = new System.Drawing.Size(35, 20);
			this.sp_GR3_F.TabIndex = 59;
			this.sp_GR3_F.TabStop = false;
			this.sp_GR3_F.Tag = "";
			this.sp_GR3_F.Text = "400";
			this.sp_GR3_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_GR3_F.Visible = false;
			this.sp_GR3_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_GR3_F.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_GR3_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_GR4_F
			// 
			this.sp_GR4_F.AccessibleDescription = "GR4 furnace setpoint";
			this.sp_GR4_F.Location = new System.Drawing.Point(0, 20);
			this.sp_GR4_F.Margin = new System.Windows.Forms.Padding(0);
			this.sp_GR4_F.Name = "sp_GR4_F";
			this.sp_GR4_F.Size = new System.Drawing.Size(35, 20);
			this.sp_GR4_F.TabIndex = 60;
			this.sp_GR4_F.TabStop = false;
			this.sp_GR4_F.Tag = "";
			this.sp_GR4_F.Text = "400";
			this.sp_GR4_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_GR4_F.Visible = false;
			this.sp_GR4_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_GR4_F.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_GR4_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_GR5_F
			// 
			this.sp_GR5_F.AccessibleDescription = "GR5 furnace setpoint";
			this.sp_GR5_F.Location = new System.Drawing.Point(0, 20);
			this.sp_GR5_F.Margin = new System.Windows.Forms.Padding(0);
			this.sp_GR5_F.Name = "sp_GR5_F";
			this.sp_GR5_F.Size = new System.Drawing.Size(35, 20);
			this.sp_GR5_F.TabIndex = 61;
			this.sp_GR5_F.TabStop = false;
			this.sp_GR5_F.Tag = "";
			this.sp_GR5_F.Text = "400";
			this.sp_GR5_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_GR5_F.Visible = false;
			this.sp_GR5_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_GR5_F.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_GR5_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_GR6_F
			// 
			this.sp_GR6_F.AccessibleDescription = "GR6 furnace setpoint";
			this.sp_GR6_F.Location = new System.Drawing.Point(0, 20);
			this.sp_GR6_F.Margin = new System.Windows.Forms.Padding(0);
			this.sp_GR6_F.Name = "sp_GR6_F";
			this.sp_GR6_F.Size = new System.Drawing.Size(35, 20);
			this.sp_GR6_F.TabIndex = 62;
			this.sp_GR6_F.TabStop = false;
			this.sp_GR6_F.Tag = "";
			this.sp_GR6_F.Text = "400";
			this.sp_GR6_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_GR6_F.Visible = false;
			this.sp_GR6_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_GR6_F.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_GR6_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_VMLabel
			// 
			this.p_VMLabel.AccessibleDescription = "VM pressure";
			this.p_VMLabel.AccessibleName = "Vacuum manifold pressure";
			this.p_VMLabel.BackColor = System.Drawing.Color.Silver;
			this.p_VMLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_VMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p_VMLabel.Location = new System.Drawing.Point(76, 60);
			this.p_VMLabel.Name = "p_VMLabel";
			this.p_VMLabel.Size = new System.Drawing.Size(70, 24);
			this.p_VMLabel.TabIndex = 63;
			this.p_VMLabel.Tag = "";
			this.p_VMLabel.Text = "0";
			this.p_VMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_VMLabel.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.p_VMLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_VMLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
			this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.statusStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLabel2,
            this.statusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 633);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip1.Size = new System.Drawing.Size(960, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 64;
			this.statusStrip1.Tag = "";
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusLabel1
			// 
			this.statusLabel1.Name = "statusLabel1";
			this.statusLabel1.Size = new System.Drawing.Size(0, 17);
			this.statusLabel1.Tag = "";
			// 
			// statusLabel2
			// 
			this.statusLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel2.Name = "statusLabel2";
			this.statusLabel2.Size = new System.Drawing.Size(0, 17);
			this.statusLabel2.Tag = "";
			// 
			// statusLabel3
			// 
			this.statusLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel3.Name = "statusLabel3";
			this.statusLabel3.Size = new System.Drawing.Size(0, 17);
			this.statusLabel3.Click += new System.EventHandler(this.statusLabel3_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.AutoScrollMargin = new System.Drawing.Size(3, 3);
			this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.d_fan_IP);
			this.mainPanel.Controls.Add(this.vi_new_flow);
			this.mainPanel.Controls.Add(this.d_AimPower);
			this.mainPanel.Controls.Add(this.p_MC);
			this.mainPanel.Controls.Add(this.p_VMLabel);
			this.mainPanel.Controls.Add(this.VMPressurePictureBox);
			this.mainPanel.Controls.Add(this.VM_Gauges_Panel);
			this.mainPanel.Controls.Add(this.d_CC_S2);
			this.mainPanel.Controls.Add(this.vi_VTTR_VM);
			this.mainPanel.Controls.Add(this.sp_VTT);
			this.mainPanel.Controls.Add(this.sp_FTC_air);
			this.mainPanel.Controls.Add(this.t_VTT);
			this.mainPanel.Controls.Add(this.t_FTC_air);
			this.mainPanel.Controls.Add(this.MCUPictureBox);
			this.mainPanel.Controls.Add(this.vi_MC_MCL);
			this.mainPanel.Controls.Add(this.t_MC_CF);
			this.mainPanel.Controls.Add(this.MCLPictureBox);
			this.mainPanel.Controls.Add(this.vi_VTTL_VTTR);
			this.mainPanel.Controls.Add(this.d_CuAg_F);
			this.mainPanel.Controls.Add(this.CuAgPictureBox);
			this.mainPanel.Controls.Add(this.VttPanel);
			this.mainPanel.Controls.Add(this.VttPictureBox);
			this.mainPanel.Controls.Add(this.VttLPictureBox);
			this.mainPanel.Controls.Add(this.VttRPictureBox);
			this.mainPanel.Controls.Add(this.ro_roc_pGM);
			this.mainPanel.Controls.Add(this.t_GM);
			this.mainPanel.Controls.Add(this.ro_roc_ugC);
			this.mainPanel.Controls.Add(this.vi_CO2_GM);
			this.mainPanel.Controls.Add(this.vi_H2_GM);
			this.mainPanel.Controls.Add(this.vi_GM_VM);
			this.mainPanel.Controls.Add(this.vi_split_GM);
			this.mainPanel.Controls.Add(this.vi_BP_GM);
			this.mainPanel.Controls.Add(this.vi_d13C_GM);
			this.mainPanel.Controls.Add(this.vi_d13C_CF);
			this.mainPanel.Controls.Add(this.GMPictureBox);
			this.mainPanel.Controls.Add(this.d13CPictureBox);
			this.mainPanel.Controls.Add(this.vi_split_VM);
			this.mainPanel.Controls.Add(this.vi_MC_split);
			this.mainPanel.Controls.Add(this.vi_CuAg_MC);
			this.mainPanel.Controls.Add(this.vi_VTTR_CuAg);
			this.mainPanel.Controls.Add(this.SplitPictureBox);
			this.mainPanel.Controls.Add(this.SampleGroupBox);
			this.mainPanel.Controls.Add(this.t_MC);
			this.mainPanel.Controls.Add(this.MCPictureBox);
			this.mainPanel.Controls.Add(this.roc_pVTT);
			this.mainPanel.Controls.Add(this.p_VTT);
			this.mainPanel.Controls.Add(this.p_IM);
			this.mainPanel.Controls.Add(this.VMPictureBox);
			this.mainPanel.Controls.Add(this.sp_CC_S);
			this.mainPanel.Controls.Add(this.t_CC_S);
			this.mainPanel.Controls.Add(this.vi_IP_IM);
			this.mainPanel.Controls.Add(this.d_CC_Q);
			this.mainPanel.Controls.Add(this.IPPictureBox);
			this.mainPanel.Controls.Add(this.vi_He_IM);
			this.mainPanel.Controls.Add(this.vi_IM_VTTL);
			this.mainPanel.Controls.Add(this.vi_IM_VM);
			this.mainPanel.Controls.Add(this.vi_O2_IM);
			this.mainPanel.Controls.Add(this.IMPictureBox);
			this.mainPanel.Controls.Add(this.vi_GR1_GM);
			this.mainPanel.Controls.Add(this.GR1PictureBox);
			this.mainPanel.Controls.Add(this.d_GR1_F);
			this.mainPanel.Controls.Add(this.vi_GR6_GM);
			this.mainPanel.Controls.Add(this.GR6PictureBox);
			this.mainPanel.Controls.Add(this.vi_GR5_GM);
			this.mainPanel.Controls.Add(this.GR5PictureBox);
			this.mainPanel.Controls.Add(this.vi_GR4_GM);
			this.mainPanel.Controls.Add(this.GR4PictureBox);
			this.mainPanel.Controls.Add(this.vi_GR3_GM);
			this.mainPanel.Controls.Add(this.GR3PictureBox);
			this.mainPanel.Controls.Add(this.vi_GR2_GM);
			this.mainPanel.Controls.Add(this.GR2PictureBox);
			this.mainPanel.Controls.Add(this.v_LN_supply);
			this.mainPanel.Controls.Add(this.d_GR6_F);
			this.mainPanel.Controls.Add(this.d_GR5_F);
			this.mainPanel.Controls.Add(this.d_GR4_F);
			this.mainPanel.Controls.Add(this.d_GR3_F);
			this.mainPanel.Controls.Add(this.d_GR2_F);
			this.mainPanel.Controls.Add(this.vi_VP_d13C);
			this.mainPanel.Controls.Add(this.d13CCFPictureBox);
			this.mainPanel.Controls.Add(this.VPVPictureBox);
			this.mainPanel.Controls.Add(this.vi_MC_MCU);
			this.mainPanel.Controls.Add(this.p_Ambient);
			this.mainPanel.Controls.Add(this.t_muxAIN13);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Controls.Add(this.d_LN_Tank);
			this.mainPanel.Controls.Add(this.VP_ContentsLabel);
			this.mainPanel.Controls.Add(this.debugLabel3);
			this.mainPanel.Controls.Add(this.debugLabel2);
			this.mainPanel.Controls.Add(this.debugLabel1);
			this.mainPanel.Controls.Add(this.t_tabletop);
			this.mainPanel.Controls.Add(this.label29);
			this.mainPanel.Controls.Add(this.label30);
			this.mainPanel.Controls.Add(this.roc_pIM);
			this.mainPanel.Controls.Add(this.label28);
			this.mainPanel.Controls.Add(this.label27);
			this.mainPanel.Controls.Add(this.label7);
			this.mainPanel.Controls.Add(this.label26);
			this.mainPanel.Controls.Add(this.d_FTC_air);
			this.mainPanel.Controls.Add(this.GR6_ContentsLabel);
			this.mainPanel.Controls.Add(this.GR5_ContentsLabel);
			this.mainPanel.Controls.Add(this.GR4_ContentsLabel);
			this.mainPanel.Controls.Add(this.GR3_ContentsLabel);
			this.mainPanel.Controls.Add(this.GR2_ContentsLabel);
			this.mainPanel.Controls.Add(this.GR1_ContentsLabel);
			this.mainPanel.Controls.Add(this.ProcessComboBox);
			this.mainPanel.Controls.Add(this.VP_StateLabel);
			this.mainPanel.Controls.Add(this.IP_StateLabel);
			this.mainPanel.Controls.Add(this.GR2_panel);
			this.mainPanel.Controls.Add(this.roc_pGM);
			this.mainPanel.Controls.Add(this.roc_pForeline);
			this.mainPanel.Controls.Add(this.RunTimeLabel);
			this.mainPanel.Controls.Add(this.ProcessTimeLabel);
			this.mainPanel.Controls.Add(this.ProcessStepTimeLabel);
			this.mainPanel.Controls.Add(this.ProcessSubStepTimeLabel);
			this.mainPanel.Controls.Add(this.t_d13C_CF);
			this.mainPanel.Controls.Add(this.t_VP);
			this.mainPanel.Controls.Add(this.vi_He_VTTL);
			this.mainPanel.Controls.Add(this.ProcessSubStepLabel);
			this.mainPanel.Controls.Add(this.ProcessStepLabel);
			this.mainPanel.Controls.Add(this.startButton);
			this.mainPanel.Controls.Add(this.vi_B);
			this.mainPanel.Controls.Add(this.vi_LV);
			this.mainPanel.Controls.Add(this.vi_HV);
			this.mainPanel.Controls.Add(this.vi_CO2_GM_flow);
			this.mainPanel.Controls.Add(this.vi_H2_GM_flow);
			this.mainPanel.Controls.Add(this.vi_He_GM_flow);
			this.mainPanel.Controls.Add(this.vi_He_GM);
			this.mainPanel.Controls.Add(this.vi_VTT_flow);
			this.mainPanel.Controls.Add(this.roc_ugC);
			this.mainPanel.Controls.Add(this.ugCLabel);
			this.mainPanel.Controls.Add(this.ugC);
			this.mainPanel.Controls.Add(this.label66);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.HeLabel4);
			this.mainPanel.Controls.Add(this.HeLabel2);
			this.mainPanel.Controls.Add(this.HeLabel1);
			this.mainPanel.Controls.Add(this.H2Label);
			this.mainPanel.Controls.Add(this.CO2Label);
			this.mainPanel.Controls.Add(this.O2Label1);
			this.mainPanel.Controls.Add(this.d_Pump_HV);
			this.mainPanel.Controls.Add(this.d_RoughingPump);
			this.mainPanel.Controls.Add(this.GR6_panel);
			this.mainPanel.Controls.Add(this.GR5_panel);
			this.mainPanel.Controls.Add(this.GR4_panel);
			this.mainPanel.Controls.Add(this.GR3_panel);
			this.mainPanel.Controls.Add(this.GR1_panel);
			this.mainPanel.Controls.Add(this.t_CuAg_CF);
			this.mainPanel.Controls.Add(this.closeButton);
			this.mainPanel.Controls.Add(this.p_Foreline);
			this.mainPanel.Controls.Add(this.p_GM);
			this.mainPanel.Controls.Add(this.DiagramPictureBox);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(948, 603);
			this.mainPanel.TabIndex = 65;
			this.mainPanel.Tag = "";
			this.mainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseClick);
			this.mainPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseDoubleClick);
			// 
			// d_fan_IP
			// 
			this.d_fan_IP.AccessibleDescription = "IP fan";
			this.d_fan_IP.AccessibleName = "IP fan";
			this.d_fan_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_fan_IP.ContextMenuStrip = this.OnOffMenu;
			this.d_fan_IP.ErrorImage = null;
			this.d_fan_IP.InitialImage = null;
			this.d_fan_IP.Location = new System.Drawing.Point(85, 232);
			this.d_fan_IP.Name = "d_fan_IP";
			this.d_fan_IP.Size = new System.Drawing.Size(13, 27);
			this.d_fan_IP.TabIndex = 571;
			this.d_fan_IP.TabStop = false;
			this.d_fan_IP.Tag = "";
			this.d_fan_IP.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_fan_IP.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OnOffMenu
			// 
			this.OnOffMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnMenuItem});
			this.OnOffMenu.Name = "valveContextMenu";
			this.OnOffMenu.ShowCheckMargin = true;
			this.OnOffMenu.ShowImageMargin = false;
			this.OnOffMenu.Size = new System.Drawing.Size(91, 26);
			this.OnOffMenu.Tag = "";
			this.OnOffMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnOffDeviceMenu_Opening);
			// 
			// OnMenuItem
			// 
			this.OnMenuItem.CheckOnClick = true;
			this.OnMenuItem.Name = "OnMenuItem";
			this.OnMenuItem.Size = new System.Drawing.Size(90, 22);
			this.OnMenuItem.Tag = "";
			this.OnMenuItem.Text = "On";
			this.OnMenuItem.ToolTipText = "Controls power to the device";
			this.OnMenuItem.CheckedChanged += new System.EventHandler(this.OnMenuItem_CheckedChanged);
			// 
			// vi_new_flow
			// 
			this.vi_new_flow.AccessibleDescription = "VTT flow valve";
			this.vi_new_flow.Actuator = null;
			this.vi_new_flow.BackColor = System.Drawing.Color.Blue;
			this.vi_new_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_new_flow.ContextMenuStrip = this.valveMenu;
			this.vi_new_flow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_new_flow.Location = new System.Drawing.Point(183, 28);
			this.vi_new_flow.Name = "vi_new_flow";
			this.vi_new_flow.Size = new System.Drawing.Size(19, 19);
			this.vi_new_flow.TabIndex = 570;
			this.vi_new_flow.TabStop = false;
			this.vi_new_flow.Tag = "";
			this.vi_new_flow.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_new_flow.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_new_flow.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_new_flow.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_AimPower
			// 
			this.d_AimPower.AccessibleDescription = "AIM-X gauge power indicator";
			this.d_AimPower.BackColor = System.Drawing.Color.Transparent;
			this.d_AimPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.d_AimPower.Location = new System.Drawing.Point(123, 87);
			this.d_AimPower.Margin = new System.Windows.Forms.Padding(0);
			this.d_AimPower.Name = "d_AimPower";
			this.d_AimPower.Size = new System.Drawing.Size(26, 12);
			this.d_AimPower.TabIndex = 128;
			this.d_AimPower.Text = "ion";
			this.d_AimPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.d_AimPower.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_MC
			// 
			this.p_MC.AccessibleDescription = "MC pressure";
			this.p_MC.BackColor = System.Drawing.Color.Silver;
			this.p_MC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_MC.ClipMaximum = false;
			this.p_MC.ClipMinimum = false;
			this.p_MC.ContextMenuStrip = this.meterDisplayMenu;
			this.p_MC.Device = null;
			this.p_MC.DeviceOn = false;
			this.p_MC.DeviceState = null;
			this.p_MC.DisplayFormat = "0.000";
			this.p_MC.Error = 0;
			this.p_MC.LinkedControl = null;
			this.p_MC.Location = new System.Drawing.Point(338, 133);
			this.p_MC.Margin = new System.Windows.Forms.Padding(0);
			this.p_MC.Maximum = 100D;
			this.p_MC.Minimum = 0D;
			this.p_MC.Name = "p_MC";
			this.p_MC.OverRange = false;
			this.p_MC.Prefix = null;
			this.p_MC.SignificantDigits = 4;
			this.p_MC.Size = new System.Drawing.Size(45, 18);
			this.p_MC.Suffix = null;
			this.p_MC.TabIndex = 7;
			this.p_MC.Tag = "";
			this.p_MC.Text = ">-0.001";
			this.p_MC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_MC.UnderRange = false;
			this.p_MC.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_MC.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_MC.DeviceError += new System.EventHandler(this.RequestService);
			this.p_MC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_MC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// meterDisplayMenu
			// 
			this.meterDisplayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meterZeroNowMenuItem});
			this.meterDisplayMenu.Name = "meterGaugeMenu";
			this.meterDisplayMenu.ShowImageMargin = false;
			this.meterDisplayMenu.Size = new System.Drawing.Size(102, 26);
			this.meterDisplayMenu.Opening += new System.ComponentModel.CancelEventHandler(this.meterGaugeMenu_Opening);
			// 
			// meterZeroNowMenuItem
			// 
			this.meterZeroNowMenuItem.Name = "meterZeroNowMenuItem";
			this.meterZeroNowMenuItem.Size = new System.Drawing.Size(101, 22);
			this.meterZeroNowMenuItem.Text = "Zero Now";
			this.meterZeroNowMenuItem.Click += new System.EventHandler(this.meterZeroNowMenuItem_Click);
			// 
			// VMPressurePictureBox
			// 
			this.VMPressurePictureBox.Location = new System.Drawing.Point(69, 50);
			this.VMPressurePictureBox.Name = "VMPressurePictureBox";
			this.VMPressurePictureBox.Size = new System.Drawing.Size(84, 57);
			this.VMPressurePictureBox.TabIndex = 569;
			this.VMPressurePictureBox.TabStop = false;
			this.VMPressurePictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			// 
			// VM_Gauges_Panel
			// 
			this.VM_Gauges_Panel.Controls.Add(this.p_VM_HP);
			this.VM_Gauges_Panel.Controls.Add(this.p_VM_IG);
			this.VM_Gauges_Panel.Location = new System.Drawing.Point(21, 50);
			this.VM_Gauges_Panel.Name = "VM_Gauges_Panel";
			this.VM_Gauges_Panel.Size = new System.Drawing.Size(49, 44);
			this.VM_Gauges_Panel.TabIndex = 568;
			this.VM_Gauges_Panel.Visible = false;
			// 
			// p_VM_HP
			// 
			this.p_VM_HP.AccessibleDescription = "VM pressure (High Pressure)";
			this.p_VM_HP.BackColor = System.Drawing.Color.Silver;
			this.p_VM_HP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_VM_HP.ClipMaximum = false;
			this.p_VM_HP.ClipMinimum = false;
			this.p_VM_HP.ContextMenuStrip = this.meterDisplayMenu;
			this.p_VM_HP.Device = null;
			this.p_VM_HP.DeviceOn = false;
			this.p_VM_HP.DeviceState = null;
			this.p_VM_HP.DisplayFormat = "";
			this.p_VM_HP.Error = 0;
			this.p_VM_HP.LinkedControl = null;
			this.p_VM_HP.Location = new System.Drawing.Point(2, 2);
			this.p_VM_HP.Maximum = 0.1D;
			this.p_VM_HP.Minimum = 0D;
			this.p_VM_HP.Name = "p_VM_HP";
			this.p_VM_HP.OverRange = false;
			this.p_VM_HP.Prefix = null;
			this.p_VM_HP.SignificantDigits = 2;
			this.p_VM_HP.Size = new System.Drawing.Size(45, 20);
			this.p_VM_HP.Suffix = null;
			this.p_VM_HP.TabIndex = 17;
			this.p_VM_HP.Tag = "";
			this.p_VM_HP.Text = ">1.0e-2";
			this.p_VM_HP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_VM_HP.UnderRange = false;
			this.p_VM_HP.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_VM_HP.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_VM_HP.DeviceError += new System.EventHandler(this.RequestService);
			this.p_VM_HP.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_VM_HP.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_VM_IG
			// 
			this.p_VM_IG.AccessibleDescription = "VM pressure (ion gauge)";
			this.p_VM_IG.BackColor = System.Drawing.Color.Silver;
			this.p_VM_IG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_VM_IG.ClipMaximum = false;
			this.p_VM_IG.ClipMinimum = false;
			this.p_VM_IG.ContextMenuStrip = this.AutoManualMenu;
			this.p_VM_IG.Device = null;
			this.p_VM_IG.DeviceOn = false;
			this.p_VM_IG.DeviceState = null;
			this.p_VM_IG.DisplayFormat = "";
			this.p_VM_IG.Error = 0;
			this.p_VM_IG.LinkedControl = null;
			this.p_VM_IG.Location = new System.Drawing.Point(2, 22);
			this.p_VM_IG.Maximum = 0.0075D;
			this.p_VM_IG.Minimum = 0D;
			this.p_VM_IG.Name = "p_VM_IG";
			this.p_VM_IG.OverRange = false;
			this.p_VM_IG.Prefix = null;
			this.p_VM_IG.SignificantDigits = 2;
			this.p_VM_IG.Size = new System.Drawing.Size(45, 20);
			this.p_VM_IG.Suffix = null;
			this.p_VM_IG.TabIndex = 13;
			this.p_VM_IG.Tag = "";
			this.p_VM_IG.Text = "0.00";
			this.p_VM_IG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_VM_IG.UnderRange = false;
			this.p_VM_IG.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_VM_IG.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_VM_IG.DeviceError += new System.EventHandler(this.RequestService);
			this.p_VM_IG.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_VM_IG.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// AutoManualMenu
			// 
			this.AutoManualMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoMenuItem,
            this.ManualOnMenuItem});
			this.AutoManualMenu.Name = "valveContextMenu";
			this.AutoManualMenu.ShowCheckMargin = true;
			this.AutoManualMenu.ShowImageMargin = false;
			this.AutoManualMenu.Size = new System.Drawing.Size(101, 48);
			this.AutoManualMenu.Tag = "";
			this.AutoManualMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.AutoManualMenu_Closing);
			this.AutoManualMenu.Opening += new System.ComponentModel.CancelEventHandler(this.AutoManualMenu_Opening);
			// 
			// AutoMenuItem
			// 
			this.AutoMenuItem.Checked = true;
			this.AutoMenuItem.CheckOnClick = true;
			this.AutoMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoMenuItem.Name = "AutoMenuItem";
			this.AutoMenuItem.Size = new System.Drawing.Size(100, 22);
			this.AutoMenuItem.Tag = "";
			this.AutoMenuItem.Text = "Auto";
			this.AutoMenuItem.ToolTipText = "Switch between automatic and manual mode";
			this.AutoMenuItem.CheckedChanged += new System.EventHandler(this.AutoMenuItem_CheckedChanged);
			// 
			// ManualOnMenuItem
			// 
			this.ManualOnMenuItem.Checked = true;
			this.ManualOnMenuItem.CheckOnClick = true;
			this.ManualOnMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ManualOnMenuItem.Name = "ManualOnMenuItem";
			this.ManualOnMenuItem.Size = new System.Drawing.Size(100, 22);
			this.ManualOnMenuItem.Text = "On";
			this.ManualOnMenuItem.ToolTipText = "Turn AIM on oroff";
			this.ManualOnMenuItem.CheckedChanged += new System.EventHandler(this.ManualOnMenuItem_CheckedChanged);
			// 
			// d_CC_S2
			// 
			this.d_CC_S2.AccessibleDescription = "CC sample furnace channel 2";
			this.d_CC_S2.AccessibleName = "CC sample furnace channel 2";
			this.d_CC_S2.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.d_CC_S2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_CC_S2.ContextMenuStrip = this.heaterMenu;
			this.d_CC_S2.ErrorImage = null;
			this.d_CC_S2.InitialImage = null;
			this.d_CC_S2.Location = new System.Drawing.Point(89, 305);
			this.d_CC_S2.Name = "d_CC_S2";
			this.d_CC_S2.Size = new System.Drawing.Size(20, 20);
			this.d_CC_S2.TabIndex = 567;
			this.d_CC_S2.TabStop = false;
			this.d_CC_S2.Tag = "";
			this.d_CC_S2.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_CC_S2.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// heaterMenu
			// 
			this.heaterMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HtrPowerMenuItem});
			this.heaterMenu.Name = "valveContextMenu";
			this.heaterMenu.ShowImageMargin = false;
			this.heaterMenu.Size = new System.Drawing.Size(94, 26);
			this.heaterMenu.Tag = "";
			this.heaterMenu.Opening += new System.ComponentModel.CancelEventHandler(this.HeaterMenu_Opening);
			// 
			// HtrPowerMenuItem
			// 
			this.HtrPowerMenuItem.Name = "HtrPowerMenuItem";
			this.HtrPowerMenuItem.Size = new System.Drawing.Size(93, 22);
			this.HtrPowerMenuItem.Tag = "";
			this.HtrPowerMenuItem.Text = "Turn On";
			this.HtrPowerMenuItem.ToolTipText = "Controls power to the heater";
			this.HtrPowerMenuItem.Click += new System.EventHandler(this.HtrPowerMenuItem_Click);
			// 
			// vi_VTTR_VM
			// 
			this.vi_VTTR_VM.AccessibleDescription = "VTTR-VM valve";
			this.vi_VTTR_VM.Actuator = null;
			this.vi_VTTR_VM.BackColor = System.Drawing.Color.Blue;
			this.vi_VTTR_VM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_VTTR_VM.ContextMenuStrip = this.valveMenu;
			this.vi_VTTR_VM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_VTTR_VM.Location = new System.Drawing.Point(222, 173);
			this.vi_VTTR_VM.Name = "vi_VTTR_VM";
			this.vi_VTTR_VM.Size = new System.Drawing.Size(19, 19);
			this.vi_VTTR_VM.TabIndex = 203;
			this.vi_VTTR_VM.TabStop = false;
			this.vi_VTTR_VM.Tag = "";
			this.vi_VTTR_VM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_VTTR_VM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_VTTR_VM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_VTTR_VM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_VTT
			// 
			this.sp_VTT.AccessibleDescription = "VTT setpoint";
			this.sp_VTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sp_VTT.Location = new System.Drawing.Point(177, 266);
			this.sp_VTT.MaximumSize = new System.Drawing.Size(46, 20);
			this.sp_VTT.MinimumSize = new System.Drawing.Size(46, 20);
			this.sp_VTT.Multiline = true;
			this.sp_VTT.Name = "sp_VTT";
			this.sp_VTT.Size = new System.Drawing.Size(46, 20);
			this.sp_VTT.TabIndex = 542;
			this.sp_VTT.TabStop = false;
			this.sp_VTT.Tag = "";
			this.sp_VTT.Text = "-110";
			this.sp_VTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_VTT.Visible = false;
			this.sp_VTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_VTT.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_VTT.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.sp_VTT.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// sp_FTC_air
			// 
			this.sp_FTC_air.AccessibleDescription = "FTC air setpoint";
			this.sp_FTC_air.AccessibleName = "FTC air setpoint";
			this.sp_FTC_air.Location = new System.Drawing.Point(714, 66);
			this.sp_FTC_air.Name = "sp_FTC_air";
			this.sp_FTC_air.Size = new System.Drawing.Size(46, 20);
			this.sp_FTC_air.TabIndex = 566;
			this.sp_FTC_air.TabStop = false;
			this.sp_FTC_air.Tag = "";
			this.sp_FTC_air.Text = "100";
			this.sp_FTC_air.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sp_FTC_air.Visible = false;
			this.sp_FTC_air.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.sp_FTC_air.Leave += new System.EventHandler(this.LeaveSetpoint);
			this.sp_FTC_air.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_VTT
			// 
			this.t_VTT.AccessibleDescription = "VTT Temperature";
			this.t_VTT.AccessibleName = "";
			this.t_VTT.BackColor = System.Drawing.Color.Silver;
			this.t_VTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_VTT.ClipMaximum = false;
			this.t_VTT.ClipMinimum = false;
			this.t_VTT.ContextMenuStrip = this.heaterMenu;
			this.t_VTT.Device = null;
			this.t_VTT.DeviceOn = false;
			this.t_VTT.DeviceState = null;
			this.t_VTT.DisplayFormat = "0.0";
			this.t_VTT.Error = 0;
			this.t_VTT.LinkedControl = this.sp_VTT;
			this.t_VTT.Location = new System.Drawing.Point(177, 266);
			this.t_VTT.Maximum = 500D;
			this.t_VTT.Minimum = -196D;
			this.t_VTT.Name = "t_VTT";
			this.t_VTT.OverRange = false;
			this.t_VTT.Prefix = null;
			this.t_VTT.SignificantDigits = 3;
			this.t_VTT.Size = new System.Drawing.Size(46, 20);
			this.t_VTT.Suffix = null;
			this.t_VTT.TabIndex = 543;
			this.t_VTT.Tag = "";
			this.t_VTT.Text = "0";
			this.t_VTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_VTT.UnderRange = false;
			this.t_VTT.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_VTT.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_VTT.DeviceError += new System.EventHandler(this.RequestService);
			this.t_VTT.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_VTT.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_VTT.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_FTC_air
			// 
			this.t_FTC_air.AccessibleDescription = "FTC air temperature";
			this.t_FTC_air.AccessibleName = "FTC air temperature";
			this.t_FTC_air.BackColor = System.Drawing.Color.Silver;
			this.t_FTC_air.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_FTC_air.ClipMaximum = false;
			this.t_FTC_air.ClipMinimum = false;
			this.t_FTC_air.ContextMenuStrip = this.heaterMenu;
			this.t_FTC_air.Device = null;
			this.t_FTC_air.DeviceOn = false;
			this.t_FTC_air.DeviceState = null;
			this.t_FTC_air.DisplayFormat = "0.0";
			this.t_FTC_air.Error = 0;
			this.t_FTC_air.LinkedControl = null;
			this.t_FTC_air.Location = new System.Drawing.Point(714, 66);
			this.t_FTC_air.Maximum = 500D;
			this.t_FTC_air.Minimum = -196D;
			this.t_FTC_air.Name = "t_FTC_air";
			this.t_FTC_air.OverRange = false;
			this.t_FTC_air.Prefix = null;
			this.t_FTC_air.SignificantDigits = 3;
			this.t_FTC_air.Size = new System.Drawing.Size(46, 18);
			this.t_FTC_air.Suffix = null;
			this.t_FTC_air.TabIndex = 565;
			this.t_FTC_air.Tag = "";
			this.t_FTC_air.Text = "0.0";
			this.t_FTC_air.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_FTC_air.UnderRange = false;
			this.t_FTC_air.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_FTC_air.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_FTC_air.DeviceError += new System.EventHandler(this.RequestService);
			this.t_FTC_air.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_FTC_air.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_FTC_air.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// MCUPictureBox
			// 
			this.MCUPictureBox.AccessibleDescription = "Measurement Chamber, Upper (MCU)";
			this.MCUPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.MCUPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.MCUPictureBox.ErrorImage = null;
			this.MCUPictureBox.InitialImage = null;
			this.MCUPictureBox.Location = new System.Drawing.Point(384, 138);
			this.MCUPictureBox.Name = "MCUPictureBox";
			this.MCUPictureBox.Size = new System.Drawing.Size(19, 35);
			this.MCUPictureBox.TabIndex = 564;
			this.MCUPictureBox.TabStop = false;
			this.MCUPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.MCUPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_MC_MCL
			// 
			this.vi_MC_MCL.AccessibleDescription = "MC-MCL valve";
			this.vi_MC_MCL.Actuator = null;
			this.vi_MC_MCL.BackColor = System.Drawing.Color.Blue;
			this.vi_MC_MCL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_MC_MCL.ContextMenuStrip = this.valveMenu;
			this.vi_MC_MCL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_MC_MCL.Location = new System.Drawing.Point(384, 219);
			this.vi_MC_MCL.Name = "vi_MC_MCL";
			this.vi_MC_MCL.Size = new System.Drawing.Size(19, 19);
			this.vi_MC_MCL.TabIndex = 184;
			this.vi_MC_MCL.TabStop = false;
			this.vi_MC_MCL.Tag = "";
			this.vi_MC_MCL.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_MC_MCL.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_MC_MCL.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_MC_MCL.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_MC_CF
			// 
			this.t_MC_CF.AccessibleDescription = "MC coldfinger temperature";
			this.t_MC_CF.AccessibleName = "MC coldfinger";
			this.t_MC_CF.BackColor = System.Drawing.Color.Silver;
			this.t_MC_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_MC_CF.ClipMaximum = false;
			this.t_MC_CF.ClipMinimum = false;
			this.t_MC_CF.ContextMenuStrip = this.ftcMenu;
			this.t_MC_CF.Device = null;
			this.t_MC_CF.DeviceOn = false;
			this.t_MC_CF.DeviceState = null;
			this.t_MC_CF.DisplayFormat = "0";
			this.t_MC_CF.Error = 0;
			this.t_MC_CF.LinkedControl = null;
			this.t_MC_CF.Location = new System.Drawing.Point(345, 266);
			this.t_MC_CF.Maximum = 500D;
			this.t_MC_CF.Minimum = -196D;
			this.t_MC_CF.Name = "t_MC_CF";
			this.t_MC_CF.OverRange = false;
			this.t_MC_CF.Prefix = null;
			this.t_MC_CF.SignificantDigits = 3;
			this.t_MC_CF.Size = new System.Drawing.Size(40, 18);
			this.t_MC_CF.Suffix = null;
			this.t_MC_CF.TabIndex = 20;
			this.t_MC_CF.Tag = "";
			this.t_MC_CF.Text = "-196";
			this.t_MC_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_MC_CF.UnderRange = false;
			this.t_MC_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_MC_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_MC_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_MC_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_MC_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_MC_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ftcMenu
			// 
			this.ftcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftcRaiseMenuItem,
            this.ftcFreezeMenuItem,
            this.ftcThawMenuItem,
            this.ftcStopMenuItem,
            this.ftcStandbyMenuItem});
			this.ftcMenu.Name = "valveContextMenu";
			this.ftcMenu.ShowCheckMargin = true;
			this.ftcMenu.ShowImageMargin = false;
			this.ftcMenu.Size = new System.Drawing.Size(118, 114);
			this.ftcMenu.Tag = "";
			this.ftcMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FTCMenu_Opening);
			// 
			// ftcRaiseMenuItem
			// 
			this.ftcRaiseMenuItem.Name = "ftcRaiseMenuItem";
			this.ftcRaiseMenuItem.Size = new System.Drawing.Size(117, 22);
			this.ftcRaiseMenuItem.Text = "Raise";
			this.ftcRaiseMenuItem.Click += new System.EventHandler(this.FTCMenuItem_Click);
			// 
			// ftcFreezeMenuItem
			// 
			this.ftcFreezeMenuItem.Name = "ftcFreezeMenuItem";
			this.ftcFreezeMenuItem.Size = new System.Drawing.Size(117, 22);
			this.ftcFreezeMenuItem.Text = "Freeze";
			this.ftcFreezeMenuItem.Click += new System.EventHandler(this.FTCMenuItem_Click);
			// 
			// ftcThawMenuItem
			// 
			this.ftcThawMenuItem.Name = "ftcThawMenuItem";
			this.ftcThawMenuItem.Size = new System.Drawing.Size(117, 22);
			this.ftcThawMenuItem.Text = "Thaw";
			this.ftcThawMenuItem.Click += new System.EventHandler(this.FTCMenuItem_Click);
			// 
			// ftcStopMenuItem
			// 
			this.ftcStopMenuItem.Name = "ftcStopMenuItem";
			this.ftcStopMenuItem.Size = new System.Drawing.Size(117, 22);
			this.ftcStopMenuItem.Text = "Stop";
			this.ftcStopMenuItem.Click += new System.EventHandler(this.FTCMenuItem_Click);
			// 
			// ftcStandbyMenuItem
			// 
			this.ftcStandbyMenuItem.Name = "ftcStandbyMenuItem";
			this.ftcStandbyMenuItem.Size = new System.Drawing.Size(117, 22);
			this.ftcStandbyMenuItem.Tag = "";
			this.ftcStandbyMenuItem.Text = "Standby";
			this.ftcStandbyMenuItem.Click += new System.EventHandler(this.FTCMenuItem_Click);
			// 
			// MCLPictureBox
			// 
			this.MCLPictureBox.AccessibleDescription = "Measurement Chamber, Lower (MCL)";
			this.MCLPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.MCLPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.MCLPictureBox.ErrorImage = null;
			this.MCLPictureBox.InitialImage = null;
			this.MCLPictureBox.Location = new System.Drawing.Point(384, 242);
			this.MCLPictureBox.Name = "MCLPictureBox";
			this.MCLPictureBox.Size = new System.Drawing.Size(19, 35);
			this.MCLPictureBox.TabIndex = 563;
			this.MCLPictureBox.TabStop = false;
			this.MCLPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.MCLPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_VTTL_VTTR
			// 
			this.vi_VTTL_VTTR.AccessibleDescription = "VTTL-VTTR valve";
			this.vi_VTTL_VTTR.Actuator = null;
			this.vi_VTTL_VTTR.BackColor = System.Drawing.Color.Blue;
			this.vi_VTTL_VTTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_VTTL_VTTR.ContextMenuStrip = this.valveMenu;
			this.vi_VTTL_VTTR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_VTTL_VTTR.Location = new System.Drawing.Point(143, 196);
			this.vi_VTTL_VTTR.Name = "vi_VTTL_VTTR";
			this.vi_VTTL_VTTR.Size = new System.Drawing.Size(19, 19);
			this.vi_VTTL_VTTR.TabIndex = 179;
			this.vi_VTTL_VTTR.TabStop = false;
			this.vi_VTTL_VTTR.Tag = "";
			this.vi_VTTL_VTTR.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_VTTL_VTTR.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_VTTL_VTTR.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_VTTL_VTTR.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_CuAg_F
			// 
			this.d_CuAg_F.AccessibleDescription = "Cu/Ag trap furnace";
			this.d_CuAg_F.AccessibleName = "Cu/Ag furnace";
			this.d_CuAg_F.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.d_CuAg_F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_CuAg_F.ContextMenuStrip = this.heaterMenu;
			this.d_CuAg_F.ErrorImage = null;
			this.d_CuAg_F.InitialImage = null;
			this.d_CuAg_F.Location = new System.Drawing.Point(291, 192);
			this.d_CuAg_F.Name = "d_CuAg_F";
			this.d_CuAg_F.Size = new System.Drawing.Size(35, 27);
			this.d_CuAg_F.TabIndex = 93;
			this.d_CuAg_F.TabStop = false;
			this.d_CuAg_F.Tag = "";
			this.d_CuAg_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_CuAg_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// CuAgPictureBox
			// 
			this.CuAgPictureBox.AccessibleDescription = "Copper-Silver Trap (CuAg)";
			this.CuAgPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.CuAgPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CuAgPictureBox.ErrorImage = null;
			this.CuAgPictureBox.InitialImage = null;
			this.CuAgPictureBox.Location = new System.Drawing.Point(264, 192);
			this.CuAgPictureBox.Name = "CuAgPictureBox";
			this.CuAgPictureBox.Size = new System.Drawing.Size(71, 51);
			this.CuAgPictureBox.TabIndex = 556;
			this.CuAgPictureBox.TabStop = false;
			this.CuAgPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.CuAgPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VttPanel
			// 
			this.VttPanel.AutoSize = true;
			this.VttPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.VttPanel.Controls.Add(this.t_VTT_wire);
			this.VttPanel.Controls.Add(this.t_VTT_top);
			this.VttPanel.Controls.Add(this.t_VTT_CF);
			this.VttPanel.Location = new System.Drawing.Point(208, 224);
			this.VttPanel.Margin = new System.Windows.Forms.Padding(0);
			this.VttPanel.Name = "VttPanel";
			this.VttPanel.Size = new System.Drawing.Size(60, 36);
			this.VttPanel.TabIndex = 82;
			this.VttPanel.Tag = "";
			this.VttPanel.Visible = false;
			this.VttPanel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VttPanel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_VTT_wire
			// 
			this.t_VTT_wire.AccessibleDescription = "VTT heater coil wire temperature";
			this.t_VTT_wire.AccessibleName = "";
			this.t_VTT_wire.BackColor = System.Drawing.Color.Silver;
			this.t_VTT_wire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_VTT_wire.ClipMaximum = false;
			this.t_VTT_wire.ClipMinimum = false;
			this.t_VTT_wire.Device = null;
			this.t_VTT_wire.DeviceOn = false;
			this.t_VTT_wire.DeviceState = null;
			this.t_VTT_wire.DisplayFormat = "0";
			this.t_VTT_wire.Error = 0;
			this.t_VTT_wire.LinkedControl = null;
			this.t_VTT_wire.Location = new System.Drawing.Point(30, 18);
			this.t_VTT_wire.Margin = new System.Windows.Forms.Padding(0);
			this.t_VTT_wire.Maximum = 500D;
			this.t_VTT_wire.Minimum = -196D;
			this.t_VTT_wire.Name = "t_VTT_wire";
			this.t_VTT_wire.OverRange = false;
			this.t_VTT_wire.Prefix = null;
			this.t_VTT_wire.SignificantDigits = 3;
			this.t_VTT_wire.Size = new System.Drawing.Size(30, 18);
			this.t_VTT_wire.Suffix = null;
			this.t_VTT_wire.TabIndex = 545;
			this.t_VTT_wire.Tag = "";
			this.t_VTT_wire.Text = "-196";
			this.t_VTT_wire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_VTT_wire.UnderRange = false;
			this.t_VTT_wire.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_VTT_wire.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_VTT_wire.DeviceError += new System.EventHandler(this.RequestService);
			this.t_VTT_wire.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_VTT_wire.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_VTT_top
			// 
			this.t_VTT_top.AccessibleDescription = "Temperature at top of VTT Coldfinger";
			this.t_VTT_top.AccessibleName = "";
			this.t_VTT_top.BackColor = System.Drawing.Color.Silver;
			this.t_VTT_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_VTT_top.ClipMaximum = false;
			this.t_VTT_top.ClipMinimum = false;
			this.t_VTT_top.Device = null;
			this.t_VTT_top.DeviceOn = false;
			this.t_VTT_top.DeviceState = null;
			this.t_VTT_top.DisplayFormat = "0";
			this.t_VTT_top.Error = 0;
			this.t_VTT_top.LinkedControl = null;
			this.t_VTT_top.Location = new System.Drawing.Point(0, 0);
			this.t_VTT_top.Margin = new System.Windows.Forms.Padding(0);
			this.t_VTT_top.Maximum = 500D;
			this.t_VTT_top.Minimum = -196D;
			this.t_VTT_top.Name = "t_VTT_top";
			this.t_VTT_top.OverRange = false;
			this.t_VTT_top.Prefix = null;
			this.t_VTT_top.SignificantDigits = 3;
			this.t_VTT_top.Size = new System.Drawing.Size(30, 18);
			this.t_VTT_top.Suffix = null;
			this.t_VTT_top.TabIndex = 549;
			this.t_VTT_top.Tag = "";
			this.t_VTT_top.Text = "-196";
			this.t_VTT_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_VTT_top.UnderRange = false;
			this.t_VTT_top.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_VTT_top.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_VTT_top.DeviceError += new System.EventHandler(this.RequestService);
			this.t_VTT_top.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_VTT_top.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_VTT_CF
			// 
			this.t_VTT_CF.AccessibleDescription = "VTT Coldfinger Temperature";
			this.t_VTT_CF.AccessibleName = "";
			this.t_VTT_CF.BackColor = System.Drawing.Color.Silver;
			this.t_VTT_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_VTT_CF.ClipMaximum = false;
			this.t_VTT_CF.ClipMinimum = false;
			this.t_VTT_CF.ContextMenuStrip = this.ftcMenu;
			this.t_VTT_CF.Device = null;
			this.t_VTT_CF.DeviceOn = false;
			this.t_VTT_CF.DeviceState = null;
			this.t_VTT_CF.DisplayFormat = "0";
			this.t_VTT_CF.Error = 0;
			this.t_VTT_CF.LinkedControl = null;
			this.t_VTT_CF.Location = new System.Drawing.Point(0, 18);
			this.t_VTT_CF.Maximum = 500D;
			this.t_VTT_CF.MaximumSize = new System.Drawing.Size(30, 18);
			this.t_VTT_CF.Minimum = -196D;
			this.t_VTT_CF.MinimumSize = new System.Drawing.Size(30, 18);
			this.t_VTT_CF.Name = "t_VTT_CF";
			this.t_VTT_CF.OverRange = false;
			this.t_VTT_CF.Prefix = null;
			this.t_VTT_CF.SignificantDigits = 3;
			this.t_VTT_CF.Size = new System.Drawing.Size(30, 18);
			this.t_VTT_CF.Suffix = null;
			this.t_VTT_CF.TabIndex = 544;
			this.t_VTT_CF.Tag = "";
			this.t_VTT_CF.Text = "-196";
			this.t_VTT_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_VTT_CF.UnderRange = false;
			this.t_VTT_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_VTT_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_VTT_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_VTT_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_VTT_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VttPictureBox
			// 
			this.VttPictureBox.AccessibleDescription = "Variable Temperature Trap (VTT)";
			this.VttPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.VttPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.VttPictureBox.ContextMenuStrip = this.vttMenu;
			this.VttPictureBox.ErrorImage = null;
			this.VttPictureBox.InitialImage = null;
			this.VttPictureBox.Location = new System.Drawing.Point(182, 167);
			this.VttPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.VttPictureBox.Name = "VttPictureBox";
			this.VttPictureBox.Size = new System.Drawing.Size(35, 99);
			this.VttPictureBox.TabIndex = 550;
			this.VttPictureBox.TabStop = false;
			this.VttPictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.VttPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VttPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vttMenu
			// 
			this.vttMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vttRegulateMenuItem,
            this.vttRaiseMenuItem,
            this.vttFreezeMenuItem,
            this.vttThawMenuItem,
            this.vttStopMenuItem,
            this.vttStandbyMenuItem});
			this.vttMenu.Name = "valveContextMenu";
			this.vttMenu.ShowCheckMargin = true;
			this.vttMenu.ShowImageMargin = false;
			this.vttMenu.Size = new System.Drawing.Size(121, 136);
			this.vttMenu.Tag = "";
			this.vttMenu.Opening += new System.ComponentModel.CancelEventHandler(this.vttMenu_Opening);
			// 
			// vttRegulateMenuItem
			// 
			this.vttRegulateMenuItem.Name = "vttRegulateMenuItem";
			this.vttRegulateMenuItem.Size = new System.Drawing.Size(120, 22);
			this.vttRegulateMenuItem.Tag = "";
			this.vttRegulateMenuItem.Text = "Regulate";
			this.vttRegulateMenuItem.Click += new System.EventHandler(this.VTTMenuItemClick);
			// 
			// vttRaiseMenuItem
			// 
			this.vttRaiseMenuItem.Name = "vttRaiseMenuItem";
			this.vttRaiseMenuItem.Size = new System.Drawing.Size(120, 22);
			this.vttRaiseMenuItem.Text = "Raise";
			this.vttRaiseMenuItem.Click += new System.EventHandler(this.VTTMenuItemClick);
			// 
			// vttFreezeMenuItem
			// 
			this.vttFreezeMenuItem.Name = "vttFreezeMenuItem";
			this.vttFreezeMenuItem.Size = new System.Drawing.Size(120, 22);
			this.vttFreezeMenuItem.Text = "Freeze";
			this.vttFreezeMenuItem.Click += new System.EventHandler(this.VTTMenuItemClick);
			// 
			// vttThawMenuItem
			// 
			this.vttThawMenuItem.Name = "vttThawMenuItem";
			this.vttThawMenuItem.Size = new System.Drawing.Size(120, 22);
			this.vttThawMenuItem.Text = "Thaw";
			this.vttThawMenuItem.Click += new System.EventHandler(this.VTTMenuItemClick);
			// 
			// vttStopMenuItem
			// 
			this.vttStopMenuItem.Name = "vttStopMenuItem";
			this.vttStopMenuItem.Size = new System.Drawing.Size(120, 22);
			this.vttStopMenuItem.Text = "Stop";
			this.vttStopMenuItem.Click += new System.EventHandler(this.VTTMenuItemClick);
			// 
			// vttStandbyMenuItem
			// 
			this.vttStandbyMenuItem.Name = "vttStandbyMenuItem";
			this.vttStandbyMenuItem.Size = new System.Drawing.Size(120, 22);
			this.vttStandbyMenuItem.Text = "Standby";
			this.vttStandbyMenuItem.Click += new System.EventHandler(this.VTTMenuItemClick);
			// 
			// VttLPictureBox
			// 
			this.VttLPictureBox.AccessibleDescription = "VTT Chamber, Left (VTTL)";
			this.VttLPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.VttLPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.VttLPictureBox.ErrorImage = null;
			this.VttLPictureBox.InitialImage = null;
			this.VttLPictureBox.Location = new System.Drawing.Point(116, 192);
			this.VttLPictureBox.Name = "VttLPictureBox";
			this.VttLPictureBox.Size = new System.Drawing.Size(27, 27);
			this.VttLPictureBox.TabIndex = 562;
			this.VttLPictureBox.TabStop = false;
			this.VttLPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VttLPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VttRPictureBox
			// 
			this.VttRPictureBox.AccessibleDescription = "VTT Chamber, Right (VTTR)";
			this.VttRPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.VttRPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.VttRPictureBox.ErrorImage = null;
			this.VttRPictureBox.InitialImage = null;
			this.VttRPictureBox.Location = new System.Drawing.Point(139, 174);
			this.VttRPictureBox.Name = "VttRPictureBox";
			this.VttRPictureBox.Size = new System.Drawing.Size(106, 42);
			this.VttRPictureBox.TabIndex = 561;
			this.VttRPictureBox.TabStop = false;
			this.VttRPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VttRPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ro_roc_pGM
			// 
			this.ro_roc_pGM.AccessibleDescription = "GM pressure rate of change (Torr/s/s)";
			this.ro_roc_pGM.BackColor = System.Drawing.Color.Silver;
			this.ro_roc_pGM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ro_roc_pGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ro_roc_pGM.Location = new System.Drawing.Point(641, 182);
			this.ro_roc_pGM.Name = "ro_roc_pGM";
			this.ro_roc_pGM.Size = new System.Drawing.Size(40, 15);
			this.ro_roc_pGM.TabIndex = 512;
			this.ro_roc_pGM.Tag = "";
			this.ro_roc_pGM.Text = "0";
			this.ro_roc_pGM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ro_roc_pGM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ro_roc_pGM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GM
			// 
			this.t_GM.AccessibleDescription = "GM temperature";
			this.t_GM.BackColor = System.Drawing.Color.Silver;
			this.t_GM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GM.ClipMaximum = false;
			this.t_GM.ClipMinimum = false;
			this.t_GM.ContextMenuStrip = this.ftcMenu;
			this.t_GM.Device = null;
			this.t_GM.DeviceOn = false;
			this.t_GM.DeviceState = null;
			this.t_GM.DisplayFormat = "0.0";
			this.t_GM.Error = 0;
			this.t_GM.LinkedControl = null;
			this.t_GM.Location = new System.Drawing.Point(593, 179);
			this.t_GM.Maximum = 500D;
			this.t_GM.Minimum = -196D;
			this.t_GM.Name = "t_GM";
			this.t_GM.OverRange = false;
			this.t_GM.Prefix = null;
			this.t_GM.SignificantDigits = 3;
			this.t_GM.Size = new System.Drawing.Size(46, 18);
			this.t_GM.Suffix = null;
			this.t_GM.TabIndex = 547;
			this.t_GM.Tag = "";
			this.t_GM.Text = "0.0";
			this.t_GM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GM.UnderRange = false;
			this.t_GM.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GM.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GM.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ro_roc_ugC
			// 
			this.ro_roc_ugC.AccessibleDescription = "MC sample mass rate of rate of change (μgC/s/s)";
			this.ro_roc_ugC.BackColor = System.Drawing.Color.Silver;
			this.ro_roc_ugC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ro_roc_ugC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ro_roc_ugC.Location = new System.Drawing.Point(501, 182);
			this.ro_roc_ugC.Name = "ro_roc_ugC";
			this.ro_roc_ugC.Size = new System.Drawing.Size(40, 15);
			this.ro_roc_ugC.TabIndex = 511;
			this.ro_roc_ugC.Tag = "";
			this.ro_roc_ugC.Text = "0";
			this.ro_roc_ugC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ro_roc_ugC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ro_roc_ugC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_CO2_GM
			// 
			this.vi_CO2_GM.AccessibleDescription = "CO2-GM valve";
			this.vi_CO2_GM.Actuator = null;
			this.vi_CO2_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_CO2_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_CO2_GM.ContextMenuStrip = this.valveMenu;
			this.vi_CO2_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_CO2_GM.Location = new System.Drawing.Point(718, 173);
			this.vi_CO2_GM.Name = "vi_CO2_GM";
			this.vi_CO2_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_CO2_GM.TabIndex = 191;
			this.vi_CO2_GM.TabStop = false;
			this.vi_CO2_GM.Tag = "";
			this.vi_CO2_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_CO2_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_CO2_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_CO2_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_H2_GM
			// 
			this.vi_H2_GM.AccessibleDescription = "H2-GM valve";
			this.vi_H2_GM.Actuator = null;
			this.vi_H2_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_H2_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_H2_GM.ContextMenuStrip = this.valveMenu;
			this.vi_H2_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_H2_GM.Location = new System.Drawing.Point(741, 196);
			this.vi_H2_GM.Name = "vi_H2_GM";
			this.vi_H2_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_H2_GM.TabIndex = 189;
			this.vi_H2_GM.TabStop = false;
			this.vi_H2_GM.Tag = "";
			this.vi_H2_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_H2_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_H2_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_H2_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GM_VM
			// 
			this.vi_GM_VM.AccessibleDescription = "GM-VM valve";
			this.vi_GM_VM.Actuator = null;
			this.vi_GM_VM.BackColor = System.Drawing.Color.Blue;
			this.vi_GM_VM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GM_VM.ContextMenuStrip = this.valveMenu;
			this.vi_GM_VM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GM_VM.Location = new System.Drawing.Point(476, 173);
			this.vi_GM_VM.Name = "vi_GM_VM";
			this.vi_GM_VM.Size = new System.Drawing.Size(19, 19);
			this.vi_GM_VM.TabIndex = 205;
			this.vi_GM_VM.TabStop = false;
			this.vi_GM_VM.Tag = "";
			this.vi_GM_VM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GM_VM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GM_VM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GM_VM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_split_GM
			// 
			this.vi_split_GM.AccessibleDescription = "split-GM valve";
			this.vi_split_GM.Actuator = null;
			this.vi_split_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_split_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_split_GM.ContextMenuStrip = this.valveMenu;
			this.vi_split_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_split_GM.Location = new System.Drawing.Point(453, 196);
			this.vi_split_GM.Name = "vi_split_GM";
			this.vi_split_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_split_GM.TabIndex = 186;
			this.vi_split_GM.TabStop = false;
			this.vi_split_GM.Tag = "";
			this.vi_split_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_split_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_split_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_split_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_BP_GM
			// 
			this.vi_BP_GM.AccessibleDescription = "BP-GM valve (Breakseal Port)";
			this.vi_BP_GM.Actuator = null;
			this.vi_BP_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_BP_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_BP_GM.ContextMenuStrip = this.valveMenu;
			this.vi_BP_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_BP_GM.Location = new System.Drawing.Point(665, 219);
			this.vi_BP_GM.Name = "vi_BP_GM";
			this.vi_BP_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_BP_GM.TabIndex = 6;
			this.vi_BP_GM.TabStop = false;
			this.vi_BP_GM.Tag = "";
			this.vi_BP_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_BP_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_BP_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_BP_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_d13C_GM
			// 
			this.vi_d13C_GM.AccessibleDescription = "d13C-GM valve";
			this.vi_d13C_GM.Actuator = null;
			this.vi_d13C_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_d13C_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_d13C_GM.ContextMenuStrip = this.valveMenu;
			this.vi_d13C_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_d13C_GM.Location = new System.Drawing.Point(692, 219);
			this.vi_d13C_GM.Name = "vi_d13C_GM";
			this.vi_d13C_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_d13C_GM.TabIndex = 193;
			this.vi_d13C_GM.TabStop = false;
			this.vi_d13C_GM.Tag = "";
			this.vi_d13C_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_d13C_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_d13C_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_d13C_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_d13C_CF
			// 
			this.vi_d13C_CF.AccessibleDescription = "d13C coldfinger valve";
			this.vi_d13C_CF.Actuator = null;
			this.vi_d13C_CF.BackColor = System.Drawing.Color.Blue;
			this.vi_d13C_CF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_d13C_CF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_d13C_CF.Location = new System.Drawing.Point(715, 242);
			this.vi_d13C_CF.Name = "vi_d13C_CF";
			this.vi_d13C_CF.Size = new System.Drawing.Size(19, 19);
			this.vi_d13C_CF.TabIndex = 6;
			this.vi_d13C_CF.TabStop = false;
			this.vi_d13C_CF.Tag = "";
			this.vi_d13C_CF.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_d13C_CF.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_d13C_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_d13C_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GMPictureBox
			// 
			this.GMPictureBox.AccessibleDescription = "Graphite Manifold (GM)";
			this.GMPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GMPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.GMPictureBox.ErrorImage = null;
			this.GMPictureBox.InitialImage = null;
			this.GMPictureBox.Location = new System.Drawing.Point(471, 192);
			this.GMPictureBox.Name = "GMPictureBox";
			this.GMPictureBox.Size = new System.Drawing.Size(270, 27);
			this.GMPictureBox.TabIndex = 560;
			this.GMPictureBox.TabStop = false;
			this.GMPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GMPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d13CPictureBox
			// 
			this.d13CPictureBox.AccessibleDescription = "d13C";
			this.d13CPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.d13CPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.d13CPictureBox.ErrorImage = null;
			this.d13CPictureBox.InitialImage = null;
			this.d13CPictureBox.Location = new System.Drawing.Point(689, 237);
			this.d13CPictureBox.Name = "d13CPictureBox";
			this.d13CPictureBox.Size = new System.Drawing.Size(27, 29);
			this.d13CPictureBox.TabIndex = 558;
			this.d13CPictureBox.TabStop = false;
			this.d13CPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d13CPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_split_VM
			// 
			this.vi_split_VM.AccessibleDescription = "split-VM valve";
			this.vi_split_VM.Actuator = null;
			this.vi_split_VM.BackColor = System.Drawing.Color.Blue;
			this.vi_split_VM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_split_VM.ContextMenuStrip = this.valveMenu;
			this.vi_split_VM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_split_VM.Location = new System.Drawing.Point(430, 173);
			this.vi_split_VM.Name = "vi_split_VM";
			this.vi_split_VM.Size = new System.Drawing.Size(19, 19);
			this.vi_split_VM.TabIndex = 204;
			this.vi_split_VM.TabStop = false;
			this.vi_split_VM.Tag = "";
			this.vi_split_VM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_split_VM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_split_VM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_split_VM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_MC_split
			// 
			this.vi_MC_split.AccessibleDescription = "MC-split valve";
			this.vi_MC_split.Actuator = null;
			this.vi_MC_split.BackColor = System.Drawing.Color.Blue;
			this.vi_MC_split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_MC_split.ContextMenuStrip = this.valveMenu;
			this.vi_MC_split.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_MC_split.Location = new System.Drawing.Point(407, 196);
			this.vi_MC_split.Name = "vi_MC_split";
			this.vi_MC_split.Size = new System.Drawing.Size(19, 19);
			this.vi_MC_split.TabIndex = 185;
			this.vi_MC_split.TabStop = false;
			this.vi_MC_split.Tag = "";
			this.vi_MC_split.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_MC_split.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_MC_split.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_MC_split.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_CuAg_MC
			// 
			this.vi_CuAg_MC.AccessibleDescription = "CuAg-MC valve";
			this.vi_CuAg_MC.Actuator = null;
			this.vi_CuAg_MC.BackColor = System.Drawing.Color.Blue;
			this.vi_CuAg_MC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_CuAg_MC.ContextMenuStrip = this.valveMenu;
			this.vi_CuAg_MC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_CuAg_MC.Location = new System.Drawing.Point(334, 196);
			this.vi_CuAg_MC.Name = "vi_CuAg_MC";
			this.vi_CuAg_MC.Size = new System.Drawing.Size(19, 19);
			this.vi_CuAg_MC.TabIndex = 182;
			this.vi_CuAg_MC.TabStop = false;
			this.vi_CuAg_MC.Tag = "";
			this.vi_CuAg_MC.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_CuAg_MC.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_CuAg_MC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_CuAg_MC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_VTTR_CuAg
			// 
			this.vi_VTTR_CuAg.AccessibleDescription = "VTTR-CuAg valve";
			this.vi_VTTR_CuAg.Actuator = null;
			this.vi_VTTR_CuAg.BackColor = System.Drawing.Color.Blue;
			this.vi_VTTR_CuAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_VTTR_CuAg.ContextMenuStrip = this.valveMenu;
			this.vi_VTTR_CuAg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_VTTR_CuAg.Location = new System.Drawing.Point(245, 196);
			this.vi_VTTR_CuAg.Name = "vi_VTTR_CuAg";
			this.vi_VTTR_CuAg.Size = new System.Drawing.Size(19, 19);
			this.vi_VTTR_CuAg.TabIndex = 181;
			this.vi_VTTR_CuAg.TabStop = false;
			this.vi_VTTR_CuAg.Tag = "";
			this.vi_VTTR_CuAg.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_VTTR_CuAg.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_VTTR_CuAg.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_VTTR_CuAg.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// SplitPictureBox
			// 
			this.SplitPictureBox.AccessibleDescription = "Split Chamber (split)";
			this.SplitPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.SplitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.SplitPictureBox.ErrorImage = null;
			this.SplitPictureBox.InitialImage = null;
			this.SplitPictureBox.Location = new System.Drawing.Point(425, 191);
			this.SplitPictureBox.Name = "SplitPictureBox";
			this.SplitPictureBox.Size = new System.Drawing.Size(29, 43);
			this.SplitPictureBox.TabIndex = 557;
			this.SplitPictureBox.TabStop = false;
			this.SplitPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.SplitPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// SampleGroupBox
			// 
			this.SampleGroupBox.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.SampleGroupBox.Controls.Add(this.label45);
			this.SampleGroupBox.Controls.Add(this.AliquotDisplay);
			this.SampleGroupBox.Controls.Add(this.label17);
			this.SampleGroupBox.Controls.Add(this.label43);
			this.SampleGroupBox.Controls.Add(this.ProcessDisplay);
			this.SampleGroupBox.Controls.Add(this.MassDisplay);
			this.SampleGroupBox.Controls.Add(this.label31);
			this.SampleGroupBox.Controls.Add(this.label22);
			this.SampleGroupBox.Controls.Add(this.label8);
			this.SampleGroupBox.Controls.Add(this.SampleIDDisplay);
			this.SampleGroupBox.Controls.Add(this.SulfurSuspectedCheckBox);
			this.SampleGroupBox.Controls.Add(this.Take_d13C_CheckBox);
			this.SampleGroupBox.Controls.Add(this.FiltrationsTextBox);
			this.SampleGroupBox.Controls.Add(this.Only_d13C_CheckBox);
			this.SampleGroupBox.Controls.Add(this.NotifyCC_S_CheckBox);
			this.SampleGroupBox.Location = new System.Drawing.Point(4, 350);
			this.SampleGroupBox.Name = "SampleGroupBox";
			this.SampleGroupBox.Size = new System.Drawing.Size(342, 104);
			this.SampleGroupBox.TabIndex = 555;
			this.SampleGroupBox.TabStop = false;
			this.SampleGroupBox.Text = "Previous Sample";
			this.SampleGroupBox.TextAlign = CEGS_Aeon_Namespace.CustomGroupBox.TextAlignValue.Left;
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.BackColor = System.Drawing.Color.Transparent;
			this.label45.Location = new System.Drawing.Point(148, 43);
			this.label45.Margin = new System.Windows.Forms.Padding(0);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(13, 13);
			this.label45.TabIndex = 564;
			this.label45.Text = "g";
			// 
			// AliquotDisplay
			// 
			this.AliquotDisplay.BackColor = System.Drawing.Color.Silver;
			this.AliquotDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.AliquotDisplay.Enabled = false;
			this.AliquotDisplay.Location = new System.Drawing.Point(54, 62);
			this.AliquotDisplay.Name = "AliquotDisplay";
			this.AliquotDisplay.Size = new System.Drawing.Size(19, 20);
			this.AliquotDisplay.TabIndex = 563;
			this.AliquotDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(90, 66);
			this.label17.Margin = new System.Windows.Forms.Padding(0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(54, 13);
			this.label17.TabIndex = 562;
			this.label17.Text = "Filtrations:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.BackColor = System.Drawing.Color.Transparent;
			this.label43.Location = new System.Drawing.Point(4, 66);
			this.label43.Margin = new System.Windows.Forms.Padding(0);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(47, 13);
			this.label43.TabIndex = 562;
			this.label43.Text = "Aliquots:";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ProcessDisplay
			// 
			this.ProcessDisplay.BackColor = System.Drawing.Color.Silver;
			this.ProcessDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProcessDisplay.Enabled = false;
			this.ProcessDisplay.Location = new System.Drawing.Point(230, 17);
			this.ProcessDisplay.Name = "ProcessDisplay";
			this.ProcessDisplay.Size = new System.Drawing.Size(106, 20);
			this.ProcessDisplay.TabIndex = 561;
			this.ProcessDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MassDisplay
			// 
			this.MassDisplay.BackColor = System.Drawing.Color.Silver;
			this.MassDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MassDisplay.Enabled = false;
			this.MassDisplay.Location = new System.Drawing.Point(54, 39);
			this.MassDisplay.Name = "MassDisplay";
			this.MassDisplay.Size = new System.Drawing.Size(91, 20);
			this.MassDisplay.TabIndex = 560;
			this.MassDisplay.Text = "10000.000000";
			this.MassDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Location = new System.Drawing.Point(16, 43);
			this.label31.Margin = new System.Windows.Forms.Padding(0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(35, 13);
			this.label31.TabIndex = 559;
			this.label31.Text = "Mass:";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(176, 21);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(48, 13);
			this.label22.TabIndex = 558;
			this.label22.Text = "Process:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 13);
			this.label8.TabIndex = 557;
			this.label8.Text = "ID:";
			// 
			// SampleIDDisplay
			// 
			this.SampleIDDisplay.BackColor = System.Drawing.Color.Silver;
			this.SampleIDDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.SampleIDDisplay.Enabled = false;
			this.SampleIDDisplay.Location = new System.Drawing.Point(54, 17);
			this.SampleIDDisplay.Name = "SampleIDDisplay";
			this.SampleIDDisplay.Size = new System.Drawing.Size(116, 20);
			this.SampleIDDisplay.TabIndex = 556;
			this.SampleIDDisplay.Text = "sample id";
			this.SampleIDDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SulfurSuspectedCheckBox
			// 
			this.SulfurSuspectedCheckBox.AccessibleDescription = "Use an extra GR to trap sulfur before graphitizing";
			this.SulfurSuspectedCheckBox.AutoSize = true;
			this.SulfurSuspectedCheckBox.Enabled = false;
			this.SulfurSuspectedCheckBox.Location = new System.Drawing.Point(179, 85);
			this.SulfurSuspectedCheckBox.Name = "SulfurSuspectedCheckBox";
			this.SulfurSuspectedCheckBox.Size = new System.Drawing.Size(105, 17);
			this.SulfurSuspectedCheckBox.TabIndex = 5;
			this.SulfurSuspectedCheckBox.Text = "Sulfur suspected";
			this.SulfurSuspectedCheckBox.UseVisualStyleBackColor = true;
			this.SulfurSuspectedCheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.SulfurSuspectedCheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// Take_d13C_CheckBox
			// 
			this.Take_d13C_CheckBox.AccessibleDescription = "Uncheck if no d13C aliquant should be taken from this sample.";
			this.Take_d13C_CheckBox.AutoSize = true;
			this.Take_d13C_CheckBox.Enabled = false;
			this.Take_d13C_CheckBox.Location = new System.Drawing.Point(179, 65);
			this.Take_d13C_CheckBox.Name = "Take_d13C_CheckBox";
			this.Take_d13C_CheckBox.Size = new System.Drawing.Size(79, 17);
			this.Take_d13C_CheckBox.TabIndex = 5;
			this.Take_d13C_CheckBox.Text = "Take d13C";
			this.Take_d13C_CheckBox.UseVisualStyleBackColor = true;
			this.Take_d13C_CheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.Take_d13C_CheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// FiltrationsTextBox
			// 
			this.FiltrationsTextBox.AccessibleDescription = "Enter the number of times to filter the test sample (must be an odd number, 1..9)" +
    ".";
			this.FiltrationsTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.FiltrationsTextBox.Enabled = false;
			this.FiltrationsTextBox.Location = new System.Drawing.Point(147, 63);
			this.FiltrationsTextBox.MaxLength = 1;
			this.FiltrationsTextBox.Name = "FiltrationsTextBox";
			this.FiltrationsTextBox.Size = new System.Drawing.Size(18, 20);
			this.FiltrationsTextBox.TabIndex = 529;
			this.FiltrationsTextBox.TabStop = false;
			this.FiltrationsTextBox.Text = "1";
			this.FiltrationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FiltrationsTextBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.FiltrationsTextBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// Only_d13C_CheckBox
			// 
			this.Only_d13C_CheckBox.AccessibleDescription = "Check ONLY if no graphite is to be made.";
			this.Only_d13C_CheckBox.AutoSize = true;
			this.Only_d13C_CheckBox.Enabled = false;
			this.Only_d13C_CheckBox.Location = new System.Drawing.Point(262, 65);
			this.Only_d13C_CheckBox.Name = "Only_d13C_CheckBox";
			this.Only_d13C_CheckBox.Size = new System.Drawing.Size(75, 17);
			this.Only_d13C_CheckBox.TabIndex = 6;
			this.Only_d13C_CheckBox.Text = "Only d13C";
			this.Only_d13C_CheckBox.UseVisualStyleBackColor = true;
			this.Only_d13C_CheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.Only_d13C_CheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// NotifyCC_S_CheckBox
			// 
			this.NotifyCC_S_CheckBox.AccessibleDescription = "Check if CC_S is not raised before starting sample.";
			this.NotifyCC_S_CheckBox.AutoSize = true;
			this.NotifyCC_S_CheckBox.Enabled = false;
			this.NotifyCC_S_CheckBox.Location = new System.Drawing.Point(179, 45);
			this.NotifyCC_S_CheckBox.Name = "NotifyCC_S_CheckBox";
			this.NotifyCC_S_CheckBox.Size = new System.Drawing.Size(120, 17);
			this.NotifyCC_S_CheckBox.TabIndex = 4;
			this.NotifyCC_S_CheckBox.Text = "Notify to raise CC_S";
			this.NotifyCC_S_CheckBox.UseVisualStyleBackColor = true;
			this.NotifyCC_S_CheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.NotifyCC_S_CheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_MC
			// 
			this.t_MC.AccessibleDescription = "MC temperature";
			this.t_MC.BackColor = System.Drawing.Color.Silver;
			this.t_MC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_MC.ClipMaximum = false;
			this.t_MC.ClipMinimum = false;
			this.t_MC.Device = null;
			this.t_MC.DeviceOn = false;
			this.t_MC.DeviceState = null;
			this.t_MC.DisplayFormat = "0.00";
			this.t_MC.Error = 0;
			this.t_MC.LinkedControl = null;
			this.t_MC.Location = new System.Drawing.Point(338, 151);
			this.t_MC.Maximum = 500D;
			this.t_MC.Minimum = -196D;
			this.t_MC.Name = "t_MC";
			this.t_MC.OverRange = false;
			this.t_MC.Prefix = null;
			this.t_MC.SignificantDigits = 3;
			this.t_MC.Size = new System.Drawing.Size(45, 18);
			this.t_MC.Suffix = "";
			this.t_MC.TabIndex = 148;
			this.t_MC.Tag = "";
			this.t_MC.Text = "25.00";
			this.t_MC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_MC.UnderRange = false;
			this.t_MC.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_MC.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_MC.DeviceError += new System.EventHandler(this.RequestService);
			this.t_MC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_MC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// MCPictureBox
			// 
			this.MCPictureBox.AccessibleDescription = "Measurement Chamber (MC)";
			this.MCPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.MCPictureBox.ErrorImage = null;
			this.MCPictureBox.InitialImage = null;
			this.MCPictureBox.Location = new System.Drawing.Point(353, 192);
			this.MCPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.MCPictureBox.Name = "MCPictureBox";
			this.MCPictureBox.Size = new System.Drawing.Size(54, 51);
			this.MCPictureBox.TabIndex = 550;
			this.MCPictureBox.TabStop = false;
			this.MCPictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.MCPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.MCPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// roc_pVTT
			// 
			this.roc_pVTT.AccessibleDescription = "VTT pressure rate of change (mTorr/s)";
			this.roc_pVTT.BackColor = System.Drawing.Color.Silver;
			this.roc_pVTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.roc_pVTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roc_pVTT.Location = new System.Drawing.Point(116, 151);
			this.roc_pVTT.Name = "roc_pVTT";
			this.roc_pVTT.Size = new System.Drawing.Size(40, 15);
			this.roc_pVTT.TabIndex = 133;
			this.roc_pVTT.Tag = "";
			this.roc_pVTT.Text = "0";
			this.roc_pVTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.roc_pVTT.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.roc_pVTT.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_VTT
			// 
			this.p_VTT.AccessibleDescription = "VTT pressure";
			this.p_VTT.BackColor = System.Drawing.Color.Silver;
			this.p_VTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_VTT.ClipMaximum = false;
			this.p_VTT.ClipMinimum = false;
			this.p_VTT.ContextMenuStrip = this.meterDisplayMenu;
			this.p_VTT.Device = null;
			this.p_VTT.DeviceOn = false;
			this.p_VTT.DeviceState = null;
			this.p_VTT.DisplayFormat = "0.000";
			this.p_VTT.Error = 0;
			this.p_VTT.LinkedControl = null;
			this.p_VTT.Location = new System.Drawing.Point(116, 133);
			this.p_VTT.Maximum = 10D;
			this.p_VTT.Minimum = 0D;
			this.p_VTT.Name = "p_VTT";
			this.p_VTT.OverRange = false;
			this.p_VTT.Prefix = null;
			this.p_VTT.SignificantDigits = 3;
			this.p_VTT.Size = new System.Drawing.Size(51, 18);
			this.p_VTT.Suffix = null;
			this.p_VTT.TabIndex = 12;
			this.p_VTT.Tag = "";
			this.p_VTT.Text = ">10.000";
			this.p_VTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_VTT.UnderRange = false;
			this.p_VTT.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_VTT.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_VTT.DeviceError += new System.EventHandler(this.RequestService);
			this.p_VTT.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_VTT.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_IM
			// 
			this.p_IM.AccessibleDescription = "IM pressure";
			this.p_IM.BackColor = System.Drawing.Color.Silver;
			this.p_IM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_IM.ClipMaximum = false;
			this.p_IM.ClipMinimum = false;
			this.p_IM.ContextMenuStrip = this.meterDisplayMenu;
			this.p_IM.Device = null;
			this.p_IM.DeviceOn = false;
			this.p_IM.DeviceState = null;
			this.p_IM.DisplayFormat = "0";
			this.p_IM.Error = 0;
			this.p_IM.LinkedControl = null;
			this.p_IM.Location = new System.Drawing.Point(29, 133);
			this.p_IM.Maximum = 2000D;
			this.p_IM.Minimum = 0D;
			this.p_IM.Name = "p_IM";
			this.p_IM.OverRange = false;
			this.p_IM.Prefix = null;
			this.p_IM.SignificantDigits = 3;
			this.p_IM.Size = new System.Drawing.Size(46, 18);
			this.p_IM.Suffix = null;
			this.p_IM.TabIndex = 14;
			this.p_IM.Tag = "";
			this.p_IM.Text = "0.0";
			this.p_IM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_IM.UnderRange = false;
			this.p_IM.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_IM.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_IM.DeviceError += new System.EventHandler(this.RequestService);
			this.p_IM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_IM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VMPictureBox
			// 
			this.VMPictureBox.AccessibleDescription = "Vacuum Manifold (VM)";
			this.VMPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.VMPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.VMPictureBox.ErrorImage = null;
			this.VMPictureBox.InitialImage = null;
			this.VMPictureBox.Location = new System.Drawing.Point(74, 106);
			this.VMPictureBox.Name = "VMPictureBox";
			this.VMPictureBox.Size = new System.Drawing.Size(421, 35);
			this.VMPictureBox.TabIndex = 554;
			this.VMPictureBox.TabStop = false;
			this.VMPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VMPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_CC_S
			// 
			this.t_CC_S.AccessibleDescription = "CC sample furnace temperature";
			this.t_CC_S.AccessibleName = "CC sample furnace";
			this.t_CC_S.BackColor = System.Drawing.Color.Silver;
			this.t_CC_S.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_CC_S.ClipMaximum = false;
			this.t_CC_S.ClipMinimum = false;
			this.t_CC_S.ContextMenuStrip = this.heaterMenu;
			this.t_CC_S.Device = null;
			this.t_CC_S.DeviceOn = false;
			this.t_CC_S.DeviceState = null;
			this.t_CC_S.DisplayFormat = "0.0";
			this.t_CC_S.Error = 0;
			this.t_CC_S.LinkedControl = this.sp_CC_S;
			this.t_CC_S.Location = new System.Drawing.Point(41, 305);
			this.t_CC_S.Maximum = 1500D;
			this.t_CC_S.MaximumSize = new System.Drawing.Size(46, 20);
			this.t_CC_S.Minimum = -196D;
			this.t_CC_S.MinimumSize = new System.Drawing.Size(46, 20);
			this.t_CC_S.Name = "t_CC_S";
			this.t_CC_S.OverRange = false;
			this.t_CC_S.Prefix = null;
			this.t_CC_S.SignificantDigits = 3;
			this.t_CC_S.Size = new System.Drawing.Size(46, 20);
			this.t_CC_S.Suffix = null;
			this.t_CC_S.TabIndex = 15;
			this.t_CC_S.Tag = "";
			this.t_CC_S.Text = "0";
			this.t_CC_S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_CC_S.UnderRange = false;
			this.t_CC_S.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_CC_S.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_CC_S.DeviceError += new System.EventHandler(this.RequestService);
			this.t_CC_S.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_CC_S.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_CC_S.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_IP_IM
			// 
			this.vi_IP_IM.AccessibleDescription = "IP-IM valve";
			this.vi_IP_IM.Actuator = null;
			this.vi_IP_IM.BackColor = System.Drawing.Color.Blue;
			this.vi_IP_IM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_IP_IM.ContextMenuStrip = this.valveMenu;
			this.vi_IP_IM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_IP_IM.Location = new System.Drawing.Point(55, 219);
			this.vi_IP_IM.Name = "vi_IP_IM";
			this.vi_IP_IM.Size = new System.Drawing.Size(19, 19);
			this.vi_IP_IM.TabIndex = 177;
			this.vi_IP_IM.TabStop = false;
			this.vi_IP_IM.Tag = "";
			this.vi_IP_IM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_IP_IM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_IP_IM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_IP_IM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_CC_Q
			// 
			this.d_CC_Q.AccessibleDescription = "CC quartz furnace";
			this.d_CC_Q.AccessibleName = "CC quartz furnace";
			this.d_CC_Q.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.d_CC_Q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_CC_Q.ContextMenuStrip = this.heaterMenu;
			this.d_CC_Q.ErrorImage = null;
			this.d_CC_Q.InitialImage = null;
			this.d_CC_Q.Location = new System.Drawing.Point(52, 254);
			this.d_CC_Q.Name = "d_CC_Q";
			this.d_CC_Q.Size = new System.Drawing.Size(25, 25);
			this.d_CC_Q.TabIndex = 146;
			this.d_CC_Q.TabStop = false;
			this.d_CC_Q.Tag = "";
			this.d_CC_Q.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_CC_Q.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// IPPictureBox
			// 
			this.IPPictureBox.AccessibleDescription = "Inlet Port (IP)";
			this.IPPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.IPPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.IPPictureBox.ErrorImage = null;
			this.IPPictureBox.InitialImage = null;
			this.IPPictureBox.Location = new System.Drawing.Point(52, 237);
			this.IPPictureBox.Name = "IPPictureBox";
			this.IPPictureBox.Size = new System.Drawing.Size(25, 69);
			this.IPPictureBox.TabIndex = 553;
			this.IPPictureBox.TabStop = false;
			this.IPPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.IPPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_He_IM
			// 
			this.vi_He_IM.AccessibleDescription = "He-IM valve";
			this.vi_He_IM.Actuator = null;
			this.vi_He_IM.BackColor = System.Drawing.Color.Blue;
			this.vi_He_IM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_He_IM.ContextMenuStrip = this.valveMenu;
			this.vi_He_IM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_He_IM.Location = new System.Drawing.Point(8, 219);
			this.vi_He_IM.Name = "vi_He_IM";
			this.vi_He_IM.Size = new System.Drawing.Size(19, 19);
			this.vi_He_IM.TabIndex = 176;
			this.vi_He_IM.TabStop = false;
			this.vi_He_IM.Tag = "";
			this.vi_He_IM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_He_IM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_He_IM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_He_IM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_IM_VTTL
			// 
			this.vi_IM_VTTL.AccessibleDescription = "IM-VTT valve";
			this.vi_IM_VTTL.Actuator = null;
			this.vi_IM_VTTL.BackColor = System.Drawing.Color.Blue;
			this.vi_IM_VTTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_IM_VTTL.ContextMenuStrip = this.valveMenu;
			this.vi_IM_VTTL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_IM_VTTL.Location = new System.Drawing.Point(97, 196);
			this.vi_IM_VTTL.Name = "vi_IM_VTTL";
			this.vi_IM_VTTL.Size = new System.Drawing.Size(19, 19);
			this.vi_IM_VTTL.TabIndex = 178;
			this.vi_IM_VTTL.TabStop = false;
			this.vi_IM_VTTL.Tag = "";
			this.vi_IM_VTTL.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_IM_VTTL.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_IM_VTTL.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_IM_VTTL.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_IM_VM
			// 
			this.vi_IM_VM.AccessibleDescription = "IM-VM valve";
			this.vi_IM_VM.Actuator = null;
			this.vi_IM_VM.BackColor = System.Drawing.Color.Blue;
			this.vi_IM_VM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_IM_VM.ContextMenuStrip = this.valveMenu;
			this.vi_IM_VM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_IM_VM.Location = new System.Drawing.Point(74, 173);
			this.vi_IM_VM.Name = "vi_IM_VM";
			this.vi_IM_VM.Size = new System.Drawing.Size(19, 19);
			this.vi_IM_VM.TabIndex = 202;
			this.vi_IM_VM.TabStop = false;
			this.vi_IM_VM.Tag = "";
			this.vi_IM_VM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_IM_VM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_IM_VM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_IM_VM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_O2_IM
			// 
			this.vi_O2_IM.AccessibleDescription = "O2-IM valve";
			this.vi_O2_IM.Actuator = null;
			this.vi_O2_IM.BackColor = System.Drawing.Color.Blue;
			this.vi_O2_IM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_O2_IM.ContextMenuStrip = this.valveMenu;
			this.vi_O2_IM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_O2_IM.Location = new System.Drawing.Point(8, 173);
			this.vi_O2_IM.Name = "vi_O2_IM";
			this.vi_O2_IM.Size = new System.Drawing.Size(19, 19);
			this.vi_O2_IM.TabIndex = 6;
			this.vi_O2_IM.TabStop = false;
			this.vi_O2_IM.Tag = "";
			this.vi_O2_IM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_O2_IM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_O2_IM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_O2_IM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// IMPictureBox
			// 
			this.IMPictureBox.AccessibleDescription = "Intake Manifold (IM)";
			this.IMPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.IMPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.IMPictureBox.ErrorImage = null;
			this.IMPictureBox.InitialImage = null;
			this.IMPictureBox.Location = new System.Drawing.Point(6, 192);
			this.IMPictureBox.Name = "IMPictureBox";
			this.IMPictureBox.Size = new System.Drawing.Size(93, 27);
			this.IMPictureBox.TabIndex = 552;
			this.IMPictureBox.TabStop = false;
			this.IMPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.IMPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GR1_GM
			// 
			this.vi_GR1_GM.AccessibleDescription = "GR1-GM valve";
			this.vi_GR1_GM.Actuator = null;
			this.vi_GR1_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_GR1_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GR1_GM.ContextMenuStrip = this.valveMenu;
			this.vi_GR1_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GR1_GM.Location = new System.Drawing.Point(503, 219);
			this.vi_GR1_GM.Name = "vi_GR1_GM";
			this.vi_GR1_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_GR1_GM.TabIndex = 195;
			this.vi_GR1_GM.TabStop = false;
			this.vi_GR1_GM.Tag = "";
			this.vi_GR1_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GR1_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GR1_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GR1_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR1PictureBox
			// 
			this.GR1PictureBox.AccessibleDescription = "Graphite Reactor 1";
			this.GR1PictureBox.AccessibleName = "GR1";
			this.GR1PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GR1PictureBox.ContextMenuStrip = this.GRMenu;
			this.GR1PictureBox.ErrorImage = null;
			this.GR1PictureBox.InitialImage = null;
			this.GR1PictureBox.Location = new System.Drawing.Point(499, 211);
			this.GR1PictureBox.Name = "GR1PictureBox";
			this.GR1PictureBox.Size = new System.Drawing.Size(27, 77);
			this.GR1PictureBox.TabIndex = 24;
			this.GR1PictureBox.TabStop = false;
			this.GR1PictureBox.Tag = "";
			this.GR1PictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.GR1PictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GR1PictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_GR1_F
			// 
			this.d_GR1_F.AccessibleDescription = "GR1 Furnace";
			this.d_GR1_F.AccessibleName = "GR1";
			this.d_GR1_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.d_GR1_F.ContextMenuStrip = this.heaterMenu;
			this.d_GR1_F.ErrorImage = null;
			this.d_GR1_F.InitialImage = null;
			this.d_GR1_F.Location = new System.Drawing.Point(502, 241);
			this.d_GR1_F.Name = "d_GR1_F";
			this.d_GR1_F.Size = new System.Drawing.Size(21, 21);
			this.d_GR1_F.TabIndex = 551;
			this.d_GR1_F.TabStop = false;
			this.d_GR1_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_GR1_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GR6_GM
			// 
			this.vi_GR6_GM.AccessibleDescription = "GR6-GM valve";
			this.vi_GR6_GM.Actuator = null;
			this.vi_GR6_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_GR6_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GR6_GM.ContextMenuStrip = this.valveMenu;
			this.vi_GR6_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GR6_GM.Location = new System.Drawing.Point(638, 219);
			this.vi_GR6_GM.Name = "vi_GR6_GM";
			this.vi_GR6_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_GR6_GM.TabIndex = 200;
			this.vi_GR6_GM.TabStop = false;
			this.vi_GR6_GM.Tag = "";
			this.vi_GR6_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GR6_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GR6_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GR6_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR6PictureBox
			// 
			this.GR6PictureBox.AccessibleDescription = "Graphite Reactor 6";
			this.GR6PictureBox.AccessibleName = "GR6";
			this.GR6PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GR6PictureBox.ContextMenuStrip = this.GRMenu;
			this.GR6PictureBox.ErrorImage = null;
			this.GR6PictureBox.InitialImage = null;
			this.GR6PictureBox.Location = new System.Drawing.Point(634, 211);
			this.GR6PictureBox.Name = "GR6PictureBox";
			this.GR6PictureBox.Size = new System.Drawing.Size(27, 77);
			this.GR6PictureBox.TabIndex = 49;
			this.GR6PictureBox.TabStop = false;
			this.GR6PictureBox.Tag = "";
			this.GR6PictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.GR6PictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GR6PictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GR5_GM
			// 
			this.vi_GR5_GM.AccessibleDescription = "GR5-GM valve";
			this.vi_GR5_GM.Actuator = null;
			this.vi_GR5_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_GR5_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GR5_GM.ContextMenuStrip = this.valveMenu;
			this.vi_GR5_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GR5_GM.Location = new System.Drawing.Point(611, 219);
			this.vi_GR5_GM.Name = "vi_GR5_GM";
			this.vi_GR5_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_GR5_GM.TabIndex = 199;
			this.vi_GR5_GM.TabStop = false;
			this.vi_GR5_GM.Tag = "";
			this.vi_GR5_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GR5_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GR5_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GR5_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR5PictureBox
			// 
			this.GR5PictureBox.AccessibleDescription = "Graphite Reactor 5";
			this.GR5PictureBox.AccessibleName = "GR5";
			this.GR5PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GR5PictureBox.ContextMenuStrip = this.GRMenu;
			this.GR5PictureBox.ErrorImage = null;
			this.GR5PictureBox.InitialImage = null;
			this.GR5PictureBox.Location = new System.Drawing.Point(607, 211);
			this.GR5PictureBox.Name = "GR5PictureBox";
			this.GR5PictureBox.Size = new System.Drawing.Size(27, 77);
			this.GR5PictureBox.TabIndex = 48;
			this.GR5PictureBox.TabStop = false;
			this.GR5PictureBox.Tag = "";
			this.GR5PictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.GR5PictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GR5PictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GR4_GM
			// 
			this.vi_GR4_GM.AccessibleDescription = "GR4-GM valve";
			this.vi_GR4_GM.Actuator = null;
			this.vi_GR4_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_GR4_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GR4_GM.ContextMenuStrip = this.valveMenu;
			this.vi_GR4_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GR4_GM.Location = new System.Drawing.Point(584, 219);
			this.vi_GR4_GM.Name = "vi_GR4_GM";
			this.vi_GR4_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_GR4_GM.TabIndex = 198;
			this.vi_GR4_GM.TabStop = false;
			this.vi_GR4_GM.Tag = "";
			this.vi_GR4_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GR4_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GR4_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GR4_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR4PictureBox
			// 
			this.GR4PictureBox.AccessibleDescription = "Graphite Reactor 4";
			this.GR4PictureBox.AccessibleName = "GR4";
			this.GR4PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GR4PictureBox.ContextMenuStrip = this.GRMenu;
			this.GR4PictureBox.ErrorImage = null;
			this.GR4PictureBox.InitialImage = null;
			this.GR4PictureBox.Location = new System.Drawing.Point(580, 211);
			this.GR4PictureBox.Name = "GR4PictureBox";
			this.GR4PictureBox.Size = new System.Drawing.Size(27, 77);
			this.GR4PictureBox.TabIndex = 47;
			this.GR4PictureBox.TabStop = false;
			this.GR4PictureBox.Tag = "";
			this.GR4PictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.GR4PictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GR4PictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GR3_GM
			// 
			this.vi_GR3_GM.AccessibleDescription = "GR3-GM valve";
			this.vi_GR3_GM.Actuator = null;
			this.vi_GR3_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_GR3_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GR3_GM.ContextMenuStrip = this.valveMenu;
			this.vi_GR3_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GR3_GM.Location = new System.Drawing.Point(557, 219);
			this.vi_GR3_GM.Name = "vi_GR3_GM";
			this.vi_GR3_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_GR3_GM.TabIndex = 197;
			this.vi_GR3_GM.TabStop = false;
			this.vi_GR3_GM.Tag = "";
			this.vi_GR3_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GR3_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GR3_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GR3_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR3PictureBox
			// 
			this.GR3PictureBox.AccessibleDescription = "Graphite Reactor 3";
			this.GR3PictureBox.AccessibleName = "GR3";
			this.GR3PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GR3PictureBox.ContextMenuStrip = this.GRMenu;
			this.GR3PictureBox.ErrorImage = null;
			this.GR3PictureBox.InitialImage = null;
			this.GR3PictureBox.Location = new System.Drawing.Point(553, 211);
			this.GR3PictureBox.Name = "GR3PictureBox";
			this.GR3PictureBox.Size = new System.Drawing.Size(27, 77);
			this.GR3PictureBox.TabIndex = 46;
			this.GR3PictureBox.TabStop = false;
			this.GR3PictureBox.Tag = "";
			this.GR3PictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.GR3PictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GR3PictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_GR2_GM
			// 
			this.vi_GR2_GM.AccessibleDescription = "GR2-GM valve";
			this.vi_GR2_GM.Actuator = null;
			this.vi_GR2_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_GR2_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_GR2_GM.ContextMenuStrip = this.valveMenu;
			this.vi_GR2_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_GR2_GM.Location = new System.Drawing.Point(530, 219);
			this.vi_GR2_GM.Name = "vi_GR2_GM";
			this.vi_GR2_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_GR2_GM.TabIndex = 196;
			this.vi_GR2_GM.TabStop = false;
			this.vi_GR2_GM.Tag = "";
			this.vi_GR2_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_GR2_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_GR2_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_GR2_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR2PictureBox
			// 
			this.GR2PictureBox.AccessibleDescription = "Graphite Reactor 2";
			this.GR2PictureBox.AccessibleName = "GR2";
			this.GR2PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.GR2PictureBox.ContextMenuStrip = this.GRMenu;
			this.GR2PictureBox.ErrorImage = null;
			this.GR2PictureBox.InitialImage = null;
			this.GR2PictureBox.Location = new System.Drawing.Point(526, 211);
			this.GR2PictureBox.Name = "GR2PictureBox";
			this.GR2PictureBox.Size = new System.Drawing.Size(27, 77);
			this.GR2PictureBox.TabIndex = 45;
			this.GR2PictureBox.TabStop = false;
			this.GR2PictureBox.Tag = "";
			this.GR2PictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.GR2PictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GR2PictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// v_LN_supply
			// 
			this.v_LN_supply.AccessibleDescription = "Available liquid nitrogen";
			this.v_LN_supply.AutoSize = true;
			this.v_LN_supply.BackColor = System.Drawing.Color.Transparent;
			this.v_LN_supply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.v_LN_supply.ClipMaximum = false;
			this.v_LN_supply.ClipMinimum = false;
			this.v_LN_supply.ContextMenuStrip = this.meterDisplayMenu;
			this.v_LN_supply.Device = null;
			this.v_LN_supply.DeviceOn = false;
			this.v_LN_supply.DeviceState = null;
			this.v_LN_supply.DisplayFormat = "0.0";
			this.v_LN_supply.Error = 0;
			this.v_LN_supply.LinkedControl = null;
			this.v_LN_supply.Location = new System.Drawing.Point(472, 85);
			this.v_LN_supply.Maximum = 200D;
			this.v_LN_supply.Minimum = 0D;
			this.v_LN_supply.Name = "v_LN_supply";
			this.v_LN_supply.OverRange = false;
			this.v_LN_supply.Prefix = "LN supply: ";
			this.v_LN_supply.SignificantDigits = 4;
			this.v_LN_supply.Size = new System.Drawing.Size(95, 15);
			this.v_LN_supply.Suffix = " L";
			this.v_LN_supply.TabIndex = 510;
			this.v_LN_supply.Tag = "";
			this.v_LN_supply.Text = "LN supply:  90.0 L";
			this.v_LN_supply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.v_LN_supply.UnderRange = false;
			this.v_LN_supply.Decorate += new System.EventHandler(this.LNLevelChanged);
			this.v_LN_supply.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.v_LN_supply.DeviceError += new System.EventHandler(this.RequestService);
			this.v_LN_supply.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.v_LN_supply.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_GR6_F
			// 
			this.d_GR6_F.AccessibleDescription = "GR6 Furnace";
			this.d_GR6_F.AccessibleName = "GR6";
			this.d_GR6_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.d_GR6_F.ContextMenuStrip = this.heaterMenu;
			this.d_GR6_F.ErrorImage = null;
			this.d_GR6_F.InitialImage = null;
			this.d_GR6_F.Location = new System.Drawing.Point(637, 241);
			this.d_GR6_F.Name = "d_GR6_F";
			this.d_GR6_F.Size = new System.Drawing.Size(21, 21);
			this.d_GR6_F.TabIndex = 551;
			this.d_GR6_F.TabStop = false;
			this.d_GR6_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_GR6_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_GR5_F
			// 
			this.d_GR5_F.AccessibleDescription = "GR5 Furnace";
			this.d_GR5_F.AccessibleName = "GR5";
			this.d_GR5_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.d_GR5_F.ContextMenuStrip = this.heaterMenu;
			this.d_GR5_F.ErrorImage = null;
			this.d_GR5_F.InitialImage = null;
			this.d_GR5_F.Location = new System.Drawing.Point(610, 241);
			this.d_GR5_F.Name = "d_GR5_F";
			this.d_GR5_F.Size = new System.Drawing.Size(21, 21);
			this.d_GR5_F.TabIndex = 551;
			this.d_GR5_F.TabStop = false;
			this.d_GR5_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_GR5_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_GR4_F
			// 
			this.d_GR4_F.AccessibleDescription = "GR4 Furnace";
			this.d_GR4_F.AccessibleName = "GR4";
			this.d_GR4_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.d_GR4_F.ContextMenuStrip = this.heaterMenu;
			this.d_GR4_F.ErrorImage = null;
			this.d_GR4_F.InitialImage = null;
			this.d_GR4_F.Location = new System.Drawing.Point(583, 241);
			this.d_GR4_F.Name = "d_GR4_F";
			this.d_GR4_F.Size = new System.Drawing.Size(21, 21);
			this.d_GR4_F.TabIndex = 551;
			this.d_GR4_F.TabStop = false;
			this.d_GR4_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_GR4_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_GR3_F
			// 
			this.d_GR3_F.AccessibleDescription = "GR3 Furnace";
			this.d_GR3_F.AccessibleName = "GR3";
			this.d_GR3_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.d_GR3_F.ContextMenuStrip = this.heaterMenu;
			this.d_GR3_F.ErrorImage = null;
			this.d_GR3_F.InitialImage = null;
			this.d_GR3_F.Location = new System.Drawing.Point(556, 241);
			this.d_GR3_F.Name = "d_GR3_F";
			this.d_GR3_F.Size = new System.Drawing.Size(21, 21);
			this.d_GR3_F.TabIndex = 551;
			this.d_GR3_F.TabStop = false;
			this.d_GR3_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_GR3_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_GR2_F
			// 
			this.d_GR2_F.AccessibleDescription = "GR2 Furnace";
			this.d_GR2_F.AccessibleName = "GR2";
			this.d_GR2_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.d_GR2_F.ContextMenuStrip = this.heaterMenu;
			this.d_GR2_F.ErrorImage = null;
			this.d_GR2_F.InitialImage = null;
			this.d_GR2_F.Location = new System.Drawing.Point(529, 241);
			this.d_GR2_F.Name = "d_GR2_F";
			this.d_GR2_F.Size = new System.Drawing.Size(21, 21);
			this.d_GR2_F.TabIndex = 551;
			this.d_GR2_F.TabStop = false;
			this.d_GR2_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_GR2_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_VP_d13C
			// 
			this.vi_VP_d13C.AccessibleDescription = "VP-d13C valve";
			this.vi_VP_d13C.Actuator = null;
			this.vi_VP_d13C.BackColor = System.Drawing.Color.Blue;
			this.vi_VP_d13C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_VP_d13C.ContextMenuStrip = this.valveMenu;
			this.vi_VP_d13C.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_VP_d13C.Location = new System.Drawing.Point(692, 265);
			this.vi_VP_d13C.Name = "vi_VP_d13C";
			this.vi_VP_d13C.Size = new System.Drawing.Size(19, 19);
			this.vi_VP_d13C.TabIndex = 194;
			this.vi_VP_d13C.TabStop = false;
			this.vi_VP_d13C.Tag = "";
			this.vi_VP_d13C.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_VP_d13C.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_VP_d13C.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_VP_d13C.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d13CCFPictureBox
			// 
			this.d13CCFPictureBox.AccessibleDescription = "d13C coldfinger";
			this.d13CCFPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.d13CCFPictureBox.ErrorImage = null;
			this.d13CCFPictureBox.InitialImage = null;
			this.d13CCFPictureBox.Location = new System.Drawing.Point(729, 242);
			this.d13CCFPictureBox.Name = "d13CCFPictureBox";
			this.d13CCFPictureBox.Size = new System.Drawing.Size(35, 52);
			this.d13CCFPictureBox.TabIndex = 88;
			this.d13CCFPictureBox.TabStop = false;
			this.d13CCFPictureBox.Tag = "";
			this.d13CCFPictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.d13CCFPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d13CCFPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VPVPictureBox
			// 
			this.VPVPictureBox.AccessibleDescription = "Vial port vial";
			this.VPVPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.VPVPictureBox.ErrorImage = null;
			this.VPVPictureBox.InitialImage = null;
			this.VPVPictureBox.Location = new System.Drawing.Point(689, 264);
			this.VPVPictureBox.Name = "VPVPictureBox";
			this.VPVPictureBox.Size = new System.Drawing.Size(25, 64);
			this.VPVPictureBox.TabIndex = 88;
			this.VPVPictureBox.TabStop = false;
			this.VPVPictureBox.Tag = "";
			this.VPVPictureBox.Click += new System.EventHandler(this.toggleLinkedControlVisibility);
			this.VPVPictureBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VPVPictureBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_MC_MCU
			// 
			this.vi_MC_MCU.AccessibleDescription = "MC-MCU valve";
			this.vi_MC_MCU.Actuator = null;
			this.vi_MC_MCU.BackColor = System.Drawing.Color.Blue;
			this.vi_MC_MCU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_MC_MCU.ContextMenuStrip = this.valveMenu;
			this.vi_MC_MCU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_MC_MCU.Location = new System.Drawing.Point(384, 173);
			this.vi_MC_MCU.Name = "vi_MC_MCU";
			this.vi_MC_MCU.Size = new System.Drawing.Size(19, 19);
			this.vi_MC_MCU.TabIndex = 183;
			this.vi_MC_MCU.TabStop = false;
			this.vi_MC_MCU.Tag = "";
			this.vi_MC_MCU.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_MC_MCU.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_MC_MCU.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_MC_MCU.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_Ambient
			// 
			this.p_Ambient.AccessibleDescription = "Ambient atmospheric pressure";
			this.p_Ambient.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.GaugePressureColor;
			this.p_Ambient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_Ambient.ClipMaximum = false;
			this.p_Ambient.ClipMinimum = false;
			this.p_Ambient.Device = null;
			this.p_Ambient.DeviceOn = false;
			this.p_Ambient.DeviceState = null;
			this.p_Ambient.DisplayFormat = "0.0";
			this.p_Ambient.Error = 0;
			this.p_Ambient.LinkedControl = null;
			this.p_Ambient.Location = new System.Drawing.Point(365, 10);
			this.p_Ambient.Maximum = 1690D;
			this.p_Ambient.Minimum = 0D;
			this.p_Ambient.Name = "p_Ambient";
			this.p_Ambient.OverRange = false;
			this.p_Ambient.Prefix = null;
			this.p_Ambient.SignificantDigits = 3;
			this.p_Ambient.Size = new System.Drawing.Size(42, 18);
			this.p_Ambient.Suffix = null;
			this.p_Ambient.TabIndex = 119;
			this.p_Ambient.Tag = "";
			this.p_Ambient.Text = "0.0";
			this.p_Ambient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_Ambient.UnderRange = false;
			this.p_Ambient.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_Ambient.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_Ambient.DeviceError += new System.EventHandler(this.RequestService);
			this.p_Ambient.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_Ambient.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_muxAIN13
			// 
			this.t_muxAIN13.AccessibleDescription = "AIN13 mux temperature";
			this.t_muxAIN13.BackColor = System.Drawing.Color.Silver;
			this.t_muxAIN13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_muxAIN13.ClipMaximum = false;
			this.t_muxAIN13.ClipMinimum = false;
			this.t_muxAIN13.Device = null;
			this.t_muxAIN13.DeviceOn = false;
			this.t_muxAIN13.DeviceState = null;
			this.t_muxAIN13.DisplayFormat = "0.00";
			this.t_muxAIN13.Error = 0;
			this.t_muxAIN13.LinkedControl = null;
			this.t_muxAIN13.Location = new System.Drawing.Point(365, 28);
			this.t_muxAIN13.Maximum = 125D;
			this.t_muxAIN13.Minimum = 0D;
			this.t_muxAIN13.Name = "t_muxAIN13";
			this.t_muxAIN13.OverRange = false;
			this.t_muxAIN13.Prefix = null;
			this.t_muxAIN13.SignificantDigits = 3;
			this.t_muxAIN13.Size = new System.Drawing.Size(42, 18);
			this.t_muxAIN13.Suffix = null;
			this.t_muxAIN13.TabIndex = 150;
			this.t_muxAIN13.Tag = "";
			this.t_muxAIN13.Text = "25.00";
			this.t_muxAIN13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_muxAIN13.UnderRange = false;
			this.t_muxAIN13.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_muxAIN13.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_muxAIN13.DeviceError += new System.EventHandler(this.RequestService);
			this.t_muxAIN13.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_muxAIN13.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(599, 166);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 548;
			this.label6.Text = "GM °C";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// d_LN_Tank
			// 
			this.d_LN_Tank.AccessibleDescription = "LN Tank";
			this.d_LN_Tank.AutoSize = true;
			this.d_LN_Tank.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.d_LN_Tank.BackColor = System.Drawing.Color.PowderBlue;
			this.d_LN_Tank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_LN_Tank.ContextMenuStrip = this.tankMenu;
			this.d_LN_Tank.Controls.Add(this.label65);
			this.d_LN_Tank.Controls.Add(this.label64);
			this.d_LN_Tank.Controls.Add(this.label63);
			this.d_LN_Tank.Controls.Add(this.label62);
			this.d_LN_Tank.Controls.Add(this.label61);
			this.d_LN_Tank.Controls.Add(this.label40);
			this.d_LN_Tank.Controls.Add(this.label39);
			this.d_LN_Tank.Controls.Add(this.label16);
			this.d_LN_Tank.Controls.Add(this.label15);
			this.d_LN_Tank.Controls.Add(this.label14);
			this.d_LN_Tank.Controls.Add(this.label13);
			this.d_LN_Tank.Controls.Add(this.vi_LN_GR3);
			this.d_LN_Tank.Controls.Add(this.t_tank);
			this.d_LN_Tank.Controls.Add(this.vi_LN_CuAg);
			this.d_LN_Tank.Controls.Add(this.vi_LN_MC);
			this.d_LN_Tank.Controls.Add(this.vi_LN_VTT);
			this.d_LN_Tank.Controls.Add(this.vi_LN_GR1);
			this.d_LN_Tank.Controls.Add(this.vi_LN_d13C);
			this.d_LN_Tank.Controls.Add(this.vi_LN_GR2);
			this.d_LN_Tank.Controls.Add(this.vi_LN_VP);
			this.d_LN_Tank.Controls.Add(this.vi_LN_GR4);
			this.d_LN_Tank.Controls.Add(this.vi_LN_GR6);
			this.d_LN_Tank.Controls.Add(this.vi_LN_GR5);
			this.d_LN_Tank.Controls.Add(this.LNTankLabel);
			this.d_LN_Tank.Location = new System.Drawing.Point(472, 9);
			this.d_LN_Tank.Name = "d_LN_Tank";
			this.d_LN_Tank.Padding = new System.Windows.Forms.Padding(3);
			this.d_LN_Tank.Size = new System.Drawing.Size(232, 73);
			this.d_LN_Tank.TabIndex = 541;
			this.d_LN_Tank.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_LN_Tank.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// tankMenu
			// 
			this.tankMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tankTurnOnOffMenuItem,
            this.tankFillNowMenuItem});
			this.tankMenu.Name = "valveContextMenu";
			this.tankMenu.ShowImageMargin = false;
			this.tankMenu.Size = new System.Drawing.Size(94, 48);
			this.tankMenu.Tag = "";
			this.tankMenu.Opening += new System.ComponentModel.CancelEventHandler(this.tankMenu_Opening);
			// 
			// tankTurnOnOffMenuItem
			// 
			this.tankTurnOnOffMenuItem.Name = "tankTurnOnOffMenuItem";
			this.tankTurnOnOffMenuItem.Size = new System.Drawing.Size(93, 22);
			this.tankTurnOnOffMenuItem.Tag = "";
			this.tankTurnOnOffMenuItem.Text = "Turn On";
			this.tankTurnOnOffMenuItem.Click += new System.EventHandler(this.tankTurnOnOffMenuItem_Click);
			// 
			// tankFillNowMenuItem
			// 
			this.tankFillNowMenuItem.Name = "tankFillNowMenuItem";
			this.tankFillNowMenuItem.Size = new System.Drawing.Size(93, 22);
			this.tankFillNowMenuItem.Text = "Fill now";
			this.tankFillNowMenuItem.Click += new System.EventHandler(this.tankFillNowMenuItem_Click);
			// 
			// label65
			// 
			this.label65.AccessibleDescription = "LN Tank";
			this.label65.AccessibleName = "";
			this.label65.AutoSize = true;
			this.label65.BackColor = System.Drawing.Color.Transparent;
			this.label65.ContextMenuStrip = this.tankMenu;
			this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label65.Location = new System.Drawing.Point(203, 36);
			this.label65.Margin = new System.Windows.Forms.Padding(0);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(23, 9);
			this.label65.TabIndex = 550;
			this.label65.Text = "d13C";
			this.label65.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label65.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label65.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label64
			// 
			this.label64.AccessibleDescription = "LN Tank";
			this.label64.AccessibleName = "";
			this.label64.AutoSize = true;
			this.label64.BackColor = System.Drawing.Color.Transparent;
			this.label64.ContextMenuStrip = this.tankMenu;
			this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label64.Location = new System.Drawing.Point(187, 36);
			this.label64.Margin = new System.Windows.Forms.Padding(0);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(15, 9);
			this.label64.TabIndex = 550;
			this.label64.Text = "VP";
			this.label64.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label64.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label64.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label63
			// 
			this.label63.AccessibleDescription = "LN Tank";
			this.label63.AccessibleName = "";
			this.label63.AutoSize = true;
			this.label63.BackColor = System.Drawing.Color.Transparent;
			this.label63.ContextMenuStrip = this.tankMenu;
			this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label63.Location = new System.Drawing.Point(164, 36);
			this.label63.Margin = new System.Windows.Forms.Padding(0);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(21, 9);
			this.label63.TabIndex = 550;
			this.label63.Text = "GR6";
			this.label63.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label63.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label63.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label62
			// 
			this.label62.AccessibleDescription = "LN Tank";
			this.label62.AccessibleName = "";
			this.label62.AutoSize = true;
			this.label62.BackColor = System.Drawing.Color.Transparent;
			this.label62.ContextMenuStrip = this.tankMenu;
			this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label62.Location = new System.Drawing.Point(144, 36);
			this.label62.Margin = new System.Windows.Forms.Padding(0);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(21, 9);
			this.label62.TabIndex = 550;
			this.label62.Text = "GR5";
			this.label62.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label62.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label62.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label61
			// 
			this.label61.AccessibleDescription = "LN Tank";
			this.label61.AccessibleName = "";
			this.label61.AutoSize = true;
			this.label61.BackColor = System.Drawing.Color.Transparent;
			this.label61.ContextMenuStrip = this.tankMenu;
			this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label61.Location = new System.Drawing.Point(125, 36);
			this.label61.Margin = new System.Windows.Forms.Padding(0);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(21, 9);
			this.label61.TabIndex = 550;
			this.label61.Text = "GR4";
			this.label61.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label61.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label61.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label40
			// 
			this.label40.AccessibleDescription = "LN Tank";
			this.label40.AccessibleName = "";
			this.label40.AutoSize = true;
			this.label40.BackColor = System.Drawing.Color.Transparent;
			this.label40.ContextMenuStrip = this.tankMenu;
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(105, 36);
			this.label40.Margin = new System.Windows.Forms.Padding(0);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(21, 9);
			this.label40.TabIndex = 550;
			this.label40.Text = "GR3";
			this.label40.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label40.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label40.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label39
			// 
			this.label39.AccessibleDescription = "LN Tank";
			this.label39.AccessibleName = "";
			this.label39.AutoSize = true;
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.ContextMenuStrip = this.tankMenu;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(84, 36);
			this.label39.Margin = new System.Windows.Forms.Padding(0);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(21, 9);
			this.label39.TabIndex = 550;
			this.label39.Text = "GR2";
			this.label39.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label39.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label39.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label16
			// 
			this.label16.AccessibleDescription = "LN Tank";
			this.label16.AccessibleName = "";
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ContextMenuStrip = this.tankMenu;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(64, 36);
			this.label16.Margin = new System.Windows.Forms.Padding(0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(21, 9);
			this.label16.TabIndex = 550;
			this.label16.Text = "GR1";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label16.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label16.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label15
			// 
			this.label15.AccessibleDescription = "LN Tank";
			this.label15.AccessibleName = "";
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.ContextMenuStrip = this.tankMenu;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(46, 36);
			this.label15.Margin = new System.Windows.Forms.Padding(0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(18, 9);
			this.label15.TabIndex = 550;
			this.label15.Text = "MC";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label15.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label15.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label14
			// 
			this.label14.AccessibleDescription = "LN Tank";
			this.label14.AccessibleName = "";
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.ContextMenuStrip = this.tankMenu;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(23, 36);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(24, 9);
			this.label14.TabIndex = 550;
			this.label14.Text = "CuAg";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label14.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label14.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label13
			// 
			this.label13.AccessibleDescription = "LN Tank";
			this.label13.AccessibleName = "";
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ContextMenuStrip = this.tankMenu;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(5, 36);
			this.label13.Margin = new System.Windows.Forms.Padding(0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(20, 9);
			this.label13.TabIndex = 550;
			this.label13.Text = "VTT";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label13.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.label13.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_GR3
			// 
			this.vi_LN_GR3.AccessibleDescription = "LN-GR3 valve";
			this.vi_LN_GR3.Actuator = null;
			this.vi_LN_GR3.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_GR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_GR3.ContextMenuStrip = this.valveMenu;
			this.vi_LN_GR3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_GR3.Location = new System.Drawing.Point(105, 46);
			this.vi_LN_GR3.Name = "vi_LN_GR3";
			this.vi_LN_GR3.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_GR3.TabIndex = 534;
			this.vi_LN_GR3.TabStop = false;
			this.vi_LN_GR3.Tag = "";
			this.vi_LN_GR3.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_GR3.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_GR3.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_GR3.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_tank
			// 
			this.t_tank.AccessibleDescription = "Tank Full temperature sensor";
			this.t_tank.BackColor = System.Drawing.Color.Silver;
			this.t_tank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_tank.ClipMaximum = false;
			this.t_tank.ClipMinimum = false;
			this.t_tank.ContextMenuStrip = this.tankMenu;
			this.t_tank.Device = null;
			this.t_tank.DeviceOn = false;
			this.t_tank.DeviceState = null;
			this.t_tank.DisplayFormat = "0";
			this.t_tank.Error = 0;
			this.t_tank.LinkedControl = null;
			this.t_tank.Location = new System.Drawing.Point(178, 4);
			this.t_tank.Maximum = 500D;
			this.t_tank.Minimum = -196D;
			this.t_tank.Name = "t_tank";
			this.t_tank.OverRange = false;
			this.t_tank.Prefix = null;
			this.t_tank.SignificantDigits = 3;
			this.t_tank.Size = new System.Drawing.Size(46, 18);
			this.t_tank.Suffix = null;
			this.t_tank.TabIndex = 540;
			this.t_tank.Tag = "";
			this.t_tank.Text = "0";
			this.t_tank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_tank.UnderRange = false;
			this.t_tank.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_tank.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_tank.DeviceError += new System.EventHandler(this.RequestService);
			this.t_tank.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_tank.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_CuAg
			// 
			this.vi_LN_CuAg.AccessibleDescription = "LN-CuAg valve";
			this.vi_LN_CuAg.Actuator = null;
			this.vi_LN_CuAg.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_CuAg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_CuAg.ContextMenuStrip = this.valveMenu;
			this.vi_LN_CuAg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_CuAg.Location = new System.Drawing.Point(25, 46);
			this.vi_LN_CuAg.Name = "vi_LN_CuAg";
			this.vi_LN_CuAg.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_CuAg.TabIndex = 530;
			this.vi_LN_CuAg.TabStop = false;
			this.vi_LN_CuAg.Tag = "";
			this.vi_LN_CuAg.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_CuAg.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_CuAg.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_CuAg.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_MC
			// 
			this.vi_LN_MC.AccessibleDescription = "LN-MC valve";
			this.vi_LN_MC.Actuator = null;
			this.vi_LN_MC.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_MC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_MC.ContextMenuStrip = this.valveMenu;
			this.vi_LN_MC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_MC.Location = new System.Drawing.Point(45, 46);
			this.vi_LN_MC.Name = "vi_LN_MC";
			this.vi_LN_MC.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_MC.TabIndex = 531;
			this.vi_LN_MC.TabStop = false;
			this.vi_LN_MC.Tag = "";
			this.vi_LN_MC.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_MC.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_MC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_MC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_VTT
			// 
			this.vi_LN_VTT.AccessibleDescription = "LN-VTT valve";
			this.vi_LN_VTT.Actuator = null;
			this.vi_LN_VTT.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_VTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_VTT.ContextMenuStrip = this.valveMenu;
			this.vi_LN_VTT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_VTT.Location = new System.Drawing.Point(5, 46);
			this.vi_LN_VTT.Name = "vi_LN_VTT";
			this.vi_LN_VTT.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_VTT.TabIndex = 517;
			this.vi_LN_VTT.TabStop = false;
			this.vi_LN_VTT.Tag = "";
			this.vi_LN_VTT.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_VTT.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_VTT.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_VTT.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_GR1
			// 
			this.vi_LN_GR1.AccessibleDescription = "LN-GR1 valve";
			this.vi_LN_GR1.Actuator = null;
			this.vi_LN_GR1.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_GR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_GR1.ContextMenuStrip = this.valveMenu;
			this.vi_LN_GR1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_GR1.Location = new System.Drawing.Point(65, 46);
			this.vi_LN_GR1.Name = "vi_LN_GR1";
			this.vi_LN_GR1.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_GR1.TabIndex = 532;
			this.vi_LN_GR1.TabStop = false;
			this.vi_LN_GR1.Tag = "";
			this.vi_LN_GR1.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_GR1.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_GR1.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_GR1.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_d13C
			// 
			this.vi_LN_d13C.AccessibleDescription = "LN-d13C coldfinger valve";
			this.vi_LN_d13C.Actuator = null;
			this.vi_LN_d13C.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_d13C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_d13C.ContextMenuStrip = this.valveMenu;
			this.vi_LN_d13C.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_d13C.Location = new System.Drawing.Point(205, 46);
			this.vi_LN_d13C.Name = "vi_LN_d13C";
			this.vi_LN_d13C.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_d13C.TabIndex = 539;
			this.vi_LN_d13C.TabStop = false;
			this.vi_LN_d13C.Tag = "";
			this.vi_LN_d13C.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_d13C.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_d13C.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_d13C.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_GR2
			// 
			this.vi_LN_GR2.AccessibleDescription = "LN-GR2 valve";
			this.vi_LN_GR2.Actuator = null;
			this.vi_LN_GR2.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_GR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_GR2.ContextMenuStrip = this.valveMenu;
			this.vi_LN_GR2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_GR2.Location = new System.Drawing.Point(85, 46);
			this.vi_LN_GR2.Name = "vi_LN_GR2";
			this.vi_LN_GR2.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_GR2.TabIndex = 533;
			this.vi_LN_GR2.TabStop = false;
			this.vi_LN_GR2.Tag = "";
			this.vi_LN_GR2.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_GR2.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_GR2.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_GR2.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_VP
			// 
			this.vi_LN_VP.AccessibleDescription = "LN-VP valve";
			this.vi_LN_VP.Actuator = null;
			this.vi_LN_VP.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_VP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_VP.ContextMenuStrip = this.valveMenu;
			this.vi_LN_VP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_VP.Location = new System.Drawing.Point(185, 46);
			this.vi_LN_VP.Name = "vi_LN_VP";
			this.vi_LN_VP.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_VP.TabIndex = 538;
			this.vi_LN_VP.TabStop = false;
			this.vi_LN_VP.Tag = "";
			this.vi_LN_VP.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_VP.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_VP.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_VP.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_GR4
			// 
			this.vi_LN_GR4.AccessibleDescription = "LN-GR4 valve";
			this.vi_LN_GR4.Actuator = null;
			this.vi_LN_GR4.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_GR4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_GR4.ContextMenuStrip = this.valveMenu;
			this.vi_LN_GR4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_GR4.Location = new System.Drawing.Point(125, 46);
			this.vi_LN_GR4.Name = "vi_LN_GR4";
			this.vi_LN_GR4.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_GR4.TabIndex = 535;
			this.vi_LN_GR4.TabStop = false;
			this.vi_LN_GR4.Tag = "";
			this.vi_LN_GR4.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_GR4.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_GR4.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_GR4.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_GR6
			// 
			this.vi_LN_GR6.AccessibleDescription = "LN-GR6 valve";
			this.vi_LN_GR6.Actuator = null;
			this.vi_LN_GR6.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_GR6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_GR6.ContextMenuStrip = this.valveMenu;
			this.vi_LN_GR6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_GR6.Location = new System.Drawing.Point(165, 46);
			this.vi_LN_GR6.Name = "vi_LN_GR6";
			this.vi_LN_GR6.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_GR6.TabIndex = 537;
			this.vi_LN_GR6.TabStop = false;
			this.vi_LN_GR6.Tag = "";
			this.vi_LN_GR6.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_GR6.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_GR6.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_GR6.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LN_GR5
			// 
			this.vi_LN_GR5.AccessibleDescription = "LN-GR5 valve";
			this.vi_LN_GR5.Actuator = null;
			this.vi_LN_GR5.BackColor = System.Drawing.Color.Blue;
			this.vi_LN_GR5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LN_GR5.ContextMenuStrip = this.valveMenu;
			this.vi_LN_GR5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LN_GR5.Location = new System.Drawing.Point(145, 46);
			this.vi_LN_GR5.Name = "vi_LN_GR5";
			this.vi_LN_GR5.Size = new System.Drawing.Size(19, 19);
			this.vi_LN_GR5.TabIndex = 536;
			this.vi_LN_GR5.TabStop = false;
			this.vi_LN_GR5.Tag = "";
			this.vi_LN_GR5.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LN_GR5.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LN_GR5.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LN_GR5.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// LNTankLabel
			// 
			this.LNTankLabel.AccessibleDescription = "LN Tank";
			this.LNTankLabel.AutoSize = true;
			this.LNTankLabel.BackColor = System.Drawing.Color.Transparent;
			this.LNTankLabel.ContextMenuStrip = this.tankMenu;
			this.LNTankLabel.Location = new System.Drawing.Point(85, 17);
			this.LNTankLabel.Name = "LNTankLabel";
			this.LNTankLabel.Size = new System.Drawing.Size(64, 13);
			this.LNTankLabel.TabIndex = 541;
			this.LNTankLabel.Text = "LN Manifold";
			this.LNTankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LNTankLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.LNTankLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VP_ContentsLabel
			// 
			this.VP_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.VP_ContentsLabel.Location = new System.Drawing.Point(678, 363);
			this.VP_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.VP_ContentsLabel.Name = "VP_ContentsLabel";
			this.VP_ContentsLabel.Size = new System.Drawing.Size(46, 20);
			this.VP_ContentsLabel.TabIndex = 352;
			this.VP_ContentsLabel.Text = "-";
			this.VP_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// debugLabel3
			// 
			this.debugLabel3.AccessibleDescription = "";
			this.debugLabel3.BackColor = System.Drawing.Color.LightGray;
			this.debugLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.debugLabel3.Location = new System.Drawing.Point(122, 318);
			this.debugLabel3.Margin = new System.Windows.Forms.Padding(0);
			this.debugLabel3.Name = "debugLabel3";
			this.debugLabel3.Size = new System.Drawing.Size(244, 12);
			this.debugLabel3.TabIndex = 521;
			// 
			// debugLabel2
			// 
			this.debugLabel2.AccessibleDescription = "";
			this.debugLabel2.BackColor = System.Drawing.Color.LightGray;
			this.debugLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.debugLabel2.Location = new System.Drawing.Point(122, 306);
			this.debugLabel2.Margin = new System.Windows.Forms.Padding(0);
			this.debugLabel2.Name = "debugLabel2";
			this.debugLabel2.Size = new System.Drawing.Size(244, 12);
			this.debugLabel2.TabIndex = 520;
			// 
			// debugLabel1
			// 
			this.debugLabel1.AccessibleDescription = "";
			this.debugLabel1.BackColor = System.Drawing.Color.LightGray;
			this.debugLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.debugLabel1.Location = new System.Drawing.Point(122, 294);
			this.debugLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.debugLabel1.Name = "debugLabel1";
			this.debugLabel1.Size = new System.Drawing.Size(244, 12);
			this.debugLabel1.TabIndex = 519;
			// 
			// t_tabletop
			// 
			this.t_tabletop.AccessibleDescription = "LN overflow temperature sensor";
			this.t_tabletop.AutoSize = true;
			this.t_tabletop.BackColor = System.Drawing.Color.Transparent;
			this.t_tabletop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_tabletop.ClipMaximum = false;
			this.t_tabletop.ClipMinimum = false;
			this.t_tabletop.Device = null;
			this.t_tabletop.DeviceOn = false;
			this.t_tabletop.DeviceState = null;
			this.t_tabletop.DisplayFormat = "0";
			this.t_tabletop.Error = 0;
			this.t_tabletop.LinkedControl = null;
			this.t_tabletop.Location = new System.Drawing.Point(602, 85);
			this.t_tabletop.Maximum = 500D;
			this.t_tabletop.Minimum = -196D;
			this.t_tabletop.Name = "t_tabletop";
			this.t_tabletop.OverRange = false;
			this.t_tabletop.Prefix = "LN overflow:  ";
			this.t_tabletop.SignificantDigits = 3;
			this.t_tabletop.Size = new System.Drawing.Size(103, 15);
			this.t_tabletop.Suffix = " °C";
			this.t_tabletop.TabIndex = 510;
			this.t_tabletop.Tag = "";
			this.t_tabletop.Text = "LN Overflow:  25 °C";
			this.t_tabletop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.t_tabletop.UnderRange = false;
			this.t_tabletop.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_tabletop.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_tabletop.DeviceError += new System.EventHandler(this.RequestService);
			this.t_tabletop.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_tabletop.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label29
			// 
			this.label29.AccessibleDescription = "Compressed air heater state";
			this.label29.AutoSize = true;
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(715, 31);
			this.label29.Margin = new System.Windows.Forms.Padding(0);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(45, 13);
			this.label29.TabIndex = 506;
			this.label29.Text = "Air Heat";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Location = new System.Drawing.Point(362, 367);
			this.label30.Margin = new System.Windows.Forms.Padding(0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(67, 13);
			this.label30.TabIndex = 507;
			this.label30.Text = "Graphite No.";
			// 
			// roc_pIM
			// 
			this.roc_pIM.AccessibleDescription = "IM pressure rate of change (Torr/s)";
			this.roc_pIM.BackColor = System.Drawing.Color.Silver;
			this.roc_pIM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.roc_pIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roc_pIM.Location = new System.Drawing.Point(29, 152);
			this.roc_pIM.Name = "roc_pIM";
			this.roc_pIM.Size = new System.Drawing.Size(40, 15);
			this.roc_pIM.TabIndex = 365;
			this.roc_pIM.Tag = "";
			this.roc_pIM.Text = "0";
			this.roc_pIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.roc_pIM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.roc_pIM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(375, 346);
			this.label28.Margin = new System.Windows.Forms.Padding(0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(54, 13);
			this.label28.TabIndex = 364;
			this.label28.Text = "Coldfinger";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Location = new System.Drawing.Point(383, 325);
			this.label27.Margin = new System.Windows.Forms.Padding(0);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(46, 13);
			this.label27.TabIndex = 363;
			this.label27.Text = "Furnace";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(10, 6);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 362;
			this.label7.Text = "System Up time";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Location = new System.Drawing.Point(381, 306);
			this.label26.Margin = new System.Windows.Forms.Padding(0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(48, 13);
			this.label26.TabIndex = 362;
			this.label26.Text = "Pressure";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// d_FTC_air
			// 
			this.d_FTC_air.AccessibleDescription = "FTC air heater";
			this.d_FTC_air.AccessibleName = "FTC air heater";
			this.d_FTC_air.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.d_FTC_air.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_FTC_air.ContextMenuStrip = this.heaterMenu;
			this.d_FTC_air.ErrorImage = null;
			this.d_FTC_air.InitialImage = null;
			this.d_FTC_air.Location = new System.Drawing.Point(724, 44);
			this.d_FTC_air.Name = "d_FTC_air";
			this.d_FTC_air.Size = new System.Drawing.Size(25, 20);
			this.d_FTC_air.TabIndex = 353;
			this.d_FTC_air.TabStop = false;
			this.d_FTC_air.Tag = "";
			this.d_FTC_air.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_FTC_air.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR6_ContentsLabel
			// 
			this.GR6_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.GR6_ContentsLabel.Location = new System.Drawing.Point(608, 363);
			this.GR6_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.GR6_ContentsLabel.Name = "GR6_ContentsLabel";
			this.GR6_ContentsLabel.Size = new System.Drawing.Size(35, 20);
			this.GR6_ContentsLabel.TabIndex = 351;
			this.GR6_ContentsLabel.Text = "-";
			this.GR6_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GR5_ContentsLabel
			// 
			this.GR5_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.GR5_ContentsLabel.Location = new System.Drawing.Point(573, 363);
			this.GR5_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.GR5_ContentsLabel.Name = "GR5_ContentsLabel";
			this.GR5_ContentsLabel.Size = new System.Drawing.Size(35, 20);
			this.GR5_ContentsLabel.TabIndex = 350;
			this.GR5_ContentsLabel.Text = "-";
			this.GR5_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GR4_ContentsLabel
			// 
			this.GR4_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.GR4_ContentsLabel.Location = new System.Drawing.Point(538, 363);
			this.GR4_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.GR4_ContentsLabel.Name = "GR4_ContentsLabel";
			this.GR4_ContentsLabel.Size = new System.Drawing.Size(35, 20);
			this.GR4_ContentsLabel.TabIndex = 349;
			this.GR4_ContentsLabel.Text = "-";
			this.GR4_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GR3_ContentsLabel
			// 
			this.GR3_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.GR3_ContentsLabel.Location = new System.Drawing.Point(503, 363);
			this.GR3_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.GR3_ContentsLabel.Name = "GR3_ContentsLabel";
			this.GR3_ContentsLabel.Size = new System.Drawing.Size(35, 20);
			this.GR3_ContentsLabel.TabIndex = 348;
			this.GR3_ContentsLabel.Text = "-";
			this.GR3_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GR2_ContentsLabel
			// 
			this.GR2_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.GR2_ContentsLabel.Location = new System.Drawing.Point(468, 363);
			this.GR2_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.GR2_ContentsLabel.Name = "GR2_ContentsLabel";
			this.GR2_ContentsLabel.Size = new System.Drawing.Size(35, 20);
			this.GR2_ContentsLabel.TabIndex = 347;
			this.GR2_ContentsLabel.Text = "-";
			this.GR2_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GR1_ContentsLabel
			// 
			this.GR1_ContentsLabel.BackColor = System.Drawing.Color.Transparent;
			this.GR1_ContentsLabel.Location = new System.Drawing.Point(433, 363);
			this.GR1_ContentsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.GR1_ContentsLabel.Name = "GR1_ContentsLabel";
			this.GR1_ContentsLabel.Size = new System.Drawing.Size(35, 20);
			this.GR1_ContentsLabel.TabIndex = 346;
			this.GR1_ContentsLabel.Text = "-";
			this.GR1_ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProcessComboBox
			// 
			this.ProcessComboBox.AccessibleDescription = "Select a process to run";
			this.ProcessComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.ProcessComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ProcessComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ProcessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProcessComboBox.FormattingEnabled = true;
			this.ProcessComboBox.IntegralHeight = false;
			this.ProcessComboBox.Location = new System.Drawing.Point(434, 393);
			this.ProcessComboBox.MaxDropDownItems = 10;
			this.ProcessComboBox.Name = "ProcessComboBox";
			this.ProcessComboBox.Size = new System.Drawing.Size(290, 21);
			this.ProcessComboBox.TabIndex = 7;
			this.ProcessComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProcessListEnterKeyHandler);
			this.ProcessComboBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ProcessComboBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VP_StateLabel
			// 
			this.VP_StateLabel.AccessibleDescription = "Current state of the vial port";
			this.VP_StateLabel.AccessibleName = "Vial Port";
			this.VP_StateLabel.AutoSize = true;
			this.VP_StateLabel.BackColor = System.Drawing.Color.Transparent;
			this.VP_StateLabel.ContextMenuStrip = this.LinePortStateMenu;
			this.VP_StateLabel.Location = new System.Drawing.Point(728, 347);
			this.VP_StateLabel.Margin = new System.Windows.Forms.Padding(0);
			this.VP_StateLabel.Name = "VP_StateLabel";
			this.VP_StateLabel.Size = new System.Drawing.Size(54, 13);
			this.VP_StateLabel.TabIndex = 343;
			this.VP_StateLabel.Text = "InProcess";
			this.VP_StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.VP_StateLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VP_StateLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// LinePortStateMenu
			// 
			this.LinePortStateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinePortStateMenuTitle});
			this.LinePortStateMenu.Name = "valveContextMenu";
			this.LinePortStateMenu.ShowCheckMargin = true;
			this.LinePortStateMenu.ShowImageMargin = false;
			this.LinePortStateMenu.Size = new System.Drawing.Size(98, 26);
			this.LinePortStateMenu.Tag = "";
			this.LinePortStateMenu.Opening += new System.ComponentModel.CancelEventHandler(this.LinePortStateMenu_Opening);
			// 
			// LinePortStateMenuTitle
			// 
			this.LinePortStateMenuTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.LinePortStateMenuTitle.Name = "LinePortStateMenuTitle";
			this.LinePortStateMenuTitle.Size = new System.Drawing.Size(97, 22);
			this.LinePortStateMenuTitle.Tag = "";
			this.LinePortStateMenuTitle.Text = "Title";
			// 
			// IP_StateLabel
			// 
			this.IP_StateLabel.AccessibleDescription = "Current state of the inlet port";
			this.IP_StateLabel.AccessibleName = "Inlet Port";
			this.IP_StateLabel.BackColor = System.Drawing.Color.Transparent;
			this.IP_StateLabel.ContextMenuStrip = this.LinePortStateMenu;
			this.IP_StateLabel.Location = new System.Drawing.Point(34, 328);
			this.IP_StateLabel.Margin = new System.Windows.Forms.Padding(0);
			this.IP_StateLabel.Name = "IP_StateLabel";
			this.IP_StateLabel.Size = new System.Drawing.Size(60, 13);
			this.IP_StateLabel.TabIndex = 342;
			this.IP_StateLabel.Text = "Loaded";
			this.IP_StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IP_StateLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.IP_StateLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR2_panel
			// 
			this.GR2_panel.AutoSize = true;
			this.GR2_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GR2_panel.Controls.Add(this.sp_GR2_F);
			this.GR2_panel.Controls.Add(this.p_GR2);
			this.GR2_panel.Controls.Add(this.t_GR2_F);
			this.GR2_panel.Controls.Add(this.t_GR2_CF);
			this.GR2_panel.Location = new System.Drawing.Point(468, 303);
			this.GR2_panel.Margin = new System.Windows.Forms.Padding(0);
			this.GR2_panel.Name = "GR2_panel";
			this.GR2_panel.Size = new System.Drawing.Size(35, 60);
			this.GR2_panel.TabIndex = 83;
			this.GR2_panel.Tag = "";
			// 
			// p_GR2
			// 
			this.p_GR2.AccessibleDescription = "GR2 pressure";
			this.p_GR2.BackColor = System.Drawing.Color.Silver;
			this.p_GR2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GR2.ClipMaximum = false;
			this.p_GR2.ClipMinimum = true;
			this.p_GR2.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GR2.Device = null;
			this.p_GR2.DeviceOn = false;
			this.p_GR2.DeviceState = null;
			this.p_GR2.DisplayFormat = "0";
			this.p_GR2.Error = 0;
			this.p_GR2.LinkedControl = null;
			this.p_GR2.Location = new System.Drawing.Point(0, 0);
			this.p_GR2.Margin = new System.Windows.Forms.Padding(0);
			this.p_GR2.Maximum = 1690D;
			this.p_GR2.Minimum = 0D;
			this.p_GR2.Name = "p_GR2";
			this.p_GR2.OverRange = false;
			this.p_GR2.Prefix = null;
			this.p_GR2.SignificantDigits = 3;
			this.p_GR2.Size = new System.Drawing.Size(35, 20);
			this.p_GR2.Suffix = null;
			this.p_GR2.TabIndex = 25;
			this.p_GR2.Tag = "";
			this.p_GR2.Text = "0";
			this.p_GR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GR2.UnderRange = false;
			this.p_GR2.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GR2.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GR2.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GR2.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GR2.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR2_F
			// 
			this.t_GR2_F.AccessibleDescription = "GR2 furnace temperature";
			this.t_GR2_F.AccessibleName = "GR2";
			this.t_GR2_F.BackColor = System.Drawing.Color.Silver;
			this.t_GR2_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR2_F.ClipMaximum = false;
			this.t_GR2_F.ClipMinimum = false;
			this.t_GR2_F.ContextMenuStrip = this.heaterMenu;
			this.t_GR2_F.Device = null;
			this.t_GR2_F.DeviceOn = false;
			this.t_GR2_F.DeviceState = null;
			this.t_GR2_F.DisplayFormat = "0";
			this.t_GR2_F.Error = 0;
			this.t_GR2_F.LinkedControl = this.sp_GR2_F;
			this.t_GR2_F.Location = new System.Drawing.Point(0, 20);
			this.t_GR2_F.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR2_F.Maximum = 1500D;
			this.t_GR2_F.Minimum = -196D;
			this.t_GR2_F.Name = "t_GR2_F";
			this.t_GR2_F.OverRange = false;
			this.t_GR2_F.Prefix = null;
			this.t_GR2_F.SignificantDigits = 3;
			this.t_GR2_F.Size = new System.Drawing.Size(35, 20);
			this.t_GR2_F.Suffix = null;
			this.t_GR2_F.TabIndex = 26;
			this.t_GR2_F.Tag = "";
			this.t_GR2_F.Text = "0.0";
			this.t_GR2_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR2_F.UnderRange = false;
			this.t_GR2_F.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR2_F.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR2_F.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR2_F.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR2_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR2_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR2_CF
			// 
			this.t_GR2_CF.AccessibleDescription = "GR2 coldfinger temperature";
			this.t_GR2_CF.AccessibleName = "GR2 coldfinger";
			this.t_GR2_CF.BackColor = System.Drawing.Color.Silver;
			this.t_GR2_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR2_CF.ClipMaximum = false;
			this.t_GR2_CF.ClipMinimum = false;
			this.t_GR2_CF.ContextMenuStrip = this.ftcMenu;
			this.t_GR2_CF.Device = null;
			this.t_GR2_CF.DeviceOn = false;
			this.t_GR2_CF.DeviceState = null;
			this.t_GR2_CF.DisplayFormat = "0";
			this.t_GR2_CF.Error = 0;
			this.t_GR2_CF.LinkedControl = null;
			this.t_GR2_CF.Location = new System.Drawing.Point(0, 40);
			this.t_GR2_CF.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR2_CF.Maximum = 500D;
			this.t_GR2_CF.Minimum = -196D;
			this.t_GR2_CF.Name = "t_GR2_CF";
			this.t_GR2_CF.OverRange = false;
			this.t_GR2_CF.Prefix = null;
			this.t_GR2_CF.SignificantDigits = 3;
			this.t_GR2_CF.Size = new System.Drawing.Size(35, 20);
			this.t_GR2_CF.Suffix = null;
			this.t_GR2_CF.TabIndex = 28;
			this.t_GR2_CF.Tag = "";
			this.t_GR2_CF.Text = "0";
			this.t_GR2_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR2_CF.UnderRange = false;
			this.t_GR2_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR2_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR2_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR2_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR2_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR2_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// roc_pGM
			// 
			this.roc_pGM.AccessibleDescription = "GM pressure rate of change (Torr/s)";
			this.roc_pGM.BackColor = System.Drawing.Color.Silver;
			this.roc_pGM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.roc_pGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roc_pGM.Location = new System.Drawing.Point(641, 167);
			this.roc_pGM.Name = "roc_pGM";
			this.roc_pGM.Size = new System.Drawing.Size(40, 15);
			this.roc_pGM.TabIndex = 341;
			this.roc_pGM.Tag = "";
			this.roc_pGM.Text = "0";
			this.roc_pGM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.roc_pGM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.roc_pGM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// roc_pForeline
			// 
			this.roc_pForeline.AccessibleDescription = "Foreline pressure rate of change (mTorr/s)";
			this.roc_pForeline.AccessibleName = "Foreline pressure rate of change (mTorr/s)";
			this.roc_pForeline.BackColor = System.Drawing.Color.Silver;
			this.roc_pForeline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.roc_pForeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roc_pForeline.Location = new System.Drawing.Point(365, 88);
			this.roc_pForeline.Name = "roc_pForeline";
			this.roc_pForeline.Size = new System.Drawing.Size(40, 15);
			this.roc_pForeline.TabIndex = 340;
			this.roc_pForeline.Tag = "";
			this.roc_pForeline.Text = "0";
			this.roc_pForeline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RunTimeLabel
			// 
			this.RunTimeLabel.AccessibleDescription = "System up time";
			this.RunTimeLabel.BackColor = System.Drawing.Color.Silver;
			this.RunTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.RunTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RunTimeLabel.Location = new System.Drawing.Point(7, 21);
			this.RunTimeLabel.Name = "RunTimeLabel";
			this.RunTimeLabel.Size = new System.Drawing.Size(87, 18);
			this.RunTimeLabel.TabIndex = 330;
			this.RunTimeLabel.Tag = "";
			this.RunTimeLabel.Text = "365 24:00:00.0";
			this.RunTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RunTimeLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.RunTimeLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ProcessTimeLabel
			// 
			this.ProcessTimeLabel.AccessibleDescription = "Active or most recent process time";
			this.ProcessTimeLabel.BackColor = System.Drawing.Color.Silver;
			this.ProcessTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProcessTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessTimeLabel.Location = new System.Drawing.Point(353, 395);
			this.ProcessTimeLabel.Name = "ProcessTimeLabel";
			this.ProcessTimeLabel.Size = new System.Drawing.Size(75, 19);
			this.ProcessTimeLabel.TabIndex = 329;
			this.ProcessTimeLabel.Tag = "";
			this.ProcessTimeLabel.Text = "24:00:00.000";
			this.ProcessTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ProcessTimeLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ProcessTimeLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ProcessStepTimeLabel
			// 
			this.ProcessStepTimeLabel.AccessibleDescription = "Active or most recent process step time";
			this.ProcessStepTimeLabel.BackColor = System.Drawing.Color.Silver;
			this.ProcessStepTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProcessStepTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessStepTimeLabel.Location = new System.Drawing.Point(353, 415);
			this.ProcessStepTimeLabel.Name = "ProcessStepTimeLabel";
			this.ProcessStepTimeLabel.Size = new System.Drawing.Size(75, 19);
			this.ProcessStepTimeLabel.TabIndex = 328;
			this.ProcessStepTimeLabel.Tag = "";
			this.ProcessStepTimeLabel.Text = "24:00:00.000";
			this.ProcessStepTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ProcessStepTimeLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ProcessStepTimeLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ProcessSubStepTimeLabel
			// 
			this.ProcessSubStepTimeLabel.AccessibleDescription = "Active or most recent process substep time";
			this.ProcessSubStepTimeLabel.BackColor = System.Drawing.Color.Silver;
			this.ProcessSubStepTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProcessSubStepTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessSubStepTimeLabel.Location = new System.Drawing.Point(353, 435);
			this.ProcessSubStepTimeLabel.Name = "ProcessSubStepTimeLabel";
			this.ProcessSubStepTimeLabel.Size = new System.Drawing.Size(75, 19);
			this.ProcessSubStepTimeLabel.TabIndex = 327;
			this.ProcessSubStepTimeLabel.Tag = "";
			this.ProcessSubStepTimeLabel.Text = "24:00:00.000";
			this.ProcessSubStepTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ProcessSubStepTimeLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ProcessSubStepTimeLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_d13C_CF
			// 
			this.t_d13C_CF.AccessibleDescription = "VP vial temperature";
			this.t_d13C_CF.BackColor = System.Drawing.Color.Silver;
			this.t_d13C_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_d13C_CF.ClipMaximum = false;
			this.t_d13C_CF.ClipMinimum = false;
			this.t_d13C_CF.ContextMenuStrip = this.ftcMenu;
			this.t_d13C_CF.Device = null;
			this.t_d13C_CF.DeviceOn = false;
			this.t_d13C_CF.DeviceState = null;
			this.t_d13C_CF.DisplayFormat = "0";
			this.t_d13C_CF.Error = 0;
			this.t_d13C_CF.LinkedControl = null;
			this.t_d13C_CF.Location = new System.Drawing.Point(726, 294);
			this.t_d13C_CF.Maximum = 500D;
			this.t_d13C_CF.Minimum = -196D;
			this.t_d13C_CF.Name = "t_d13C_CF";
			this.t_d13C_CF.OverRange = false;
			this.t_d13C_CF.Prefix = null;
			this.t_d13C_CF.SignificantDigits = 3;
			this.t_d13C_CF.Size = new System.Drawing.Size(46, 18);
			this.t_d13C_CF.Suffix = null;
			this.t_d13C_CF.TabIndex = 51;
			this.t_d13C_CF.Tag = "";
			this.t_d13C_CF.Text = "0";
			this.t_d13C_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_d13C_CF.UnderRange = false;
			this.t_d13C_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_d13C_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_d13C_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_d13C_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_d13C_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_d13C_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_VP
			// 
			this.t_VP.AccessibleDescription = "VP vial temperature";
			this.t_VP.BackColor = System.Drawing.Color.Silver;
			this.t_VP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_VP.ClipMaximum = false;
			this.t_VP.ClipMinimum = false;
			this.t_VP.ContextMenuStrip = this.ftcMenu;
			this.t_VP.Device = null;
			this.t_VP.DeviceOn = false;
			this.t_VP.DeviceState = null;
			this.t_VP.DisplayFormat = "0";
			this.t_VP.Error = 0;
			this.t_VP.LinkedControl = null;
			this.t_VP.Location = new System.Drawing.Point(680, 343);
			this.t_VP.Maximum = 500D;
			this.t_VP.Minimum = -196D;
			this.t_VP.Name = "t_VP";
			this.t_VP.OverRange = false;
			this.t_VP.Prefix = null;
			this.t_VP.SignificantDigits = 3;
			this.t_VP.Size = new System.Drawing.Size(46, 18);
			this.t_VP.Suffix = null;
			this.t_VP.TabIndex = 51;
			this.t_VP.Tag = "";
			this.t_VP.Text = "0";
			this.t_VP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_VP.UnderRange = false;
			this.t_VP.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_VP.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_VP.DeviceError += new System.EventHandler(this.RequestService);
			this.t_VP.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_VP.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_VP.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_He_VTTL
			// 
			this.vi_He_VTTL.AccessibleDescription = "He-VTTL valve";
			this.vi_He_VTTL.Actuator = null;
			this.vi_He_VTTL.BackColor = System.Drawing.Color.Blue;
			this.vi_He_VTTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_He_VTTL.ContextMenuStrip = this.valveMenu;
			this.vi_He_VTTL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_He_VTTL.Location = new System.Drawing.Point(120, 219);
			this.vi_He_VTTL.Name = "vi_He_VTTL";
			this.vi_He_VTTL.Size = new System.Drawing.Size(19, 19);
			this.vi_He_VTTL.TabIndex = 302;
			this.vi_He_VTTL.TabStop = false;
			this.vi_He_VTTL.Tag = "";
			this.vi_He_VTTL.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_He_VTTL.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_He_VTTL.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_He_VTTL.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ProcessSubStepLabel
			// 
			this.ProcessSubStepLabel.AccessibleDescription = "Current process sub-step";
			this.ProcessSubStepLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProcessSubStepLabel.Location = new System.Drawing.Point(434, 435);
			this.ProcessSubStepLabel.Name = "ProcessSubStepLabel";
			this.ProcessSubStepLabel.Size = new System.Drawing.Size(290, 19);
			this.ProcessSubStepLabel.TabIndex = 212;
			this.ProcessSubStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProcessSubStepLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ProcessSubStepLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ProcessStepLabel
			// 
			this.ProcessStepLabel.AccessibleDescription = "Current process step";
			this.ProcessStepLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProcessStepLabel.Location = new System.Drawing.Point(434, 415);
			this.ProcessStepLabel.Name = "ProcessStepLabel";
			this.ProcessStepLabel.Size = new System.Drawing.Size(290, 19);
			this.ProcessStepLabel.TabIndex = 211;
			this.ProcessStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ProcessStepLabel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ProcessStepLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// startButton
			// 
			this.startButton.AutoSize = true;
			this.startButton.Location = new System.Drawing.Point(731, 393);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 8;
			this.startButton.Tag = "";
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			this.startButton.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.startButton.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_B
			// 
			this.vi_B.AccessibleDescription = "Turbo pump backing valve";
			this.vi_B.Actuator = null;
			this.vi_B.BackColor = System.Drawing.Color.Blue;
			this.vi_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_B.ContextMenuStrip = this.valveMenu;
			this.vi_B.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_B.Location = new System.Drawing.Point(282, 64);
			this.vi_B.Name = "vi_B";
			this.vi_B.Size = new System.Drawing.Size(19, 19);
			this.vi_B.TabIndex = 208;
			this.vi_B.TabStop = false;
			this.vi_B.Tag = "";
			this.vi_B.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_B.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_B.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_B.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_LV
			// 
			this.vi_LV.AccessibleDescription = "Low Vacuum (roughing) valve";
			this.vi_LV.Actuator = null;
			this.vi_LV.BackColor = System.Drawing.Color.Blue;
			this.vi_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_LV.ContextMenuStrip = this.valveMenu;
			this.vi_LV.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_LV.Location = new System.Drawing.Point(305, 87);
			this.vi_LV.Name = "vi_LV";
			this.vi_LV.Size = new System.Drawing.Size(19, 19);
			this.vi_LV.TabIndex = 207;
			this.vi_LV.TabStop = false;
			this.vi_LV.Tag = "";
			this.vi_LV.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_LV.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_LV.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_LV.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_HV
			// 
			this.vi_HV.AccessibleDescription = "High Vacuum valve";
			this.vi_HV.Actuator = null;
			this.vi_HV.BackColor = System.Drawing.Color.Blue;
			this.vi_HV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_HV.ContextMenuStrip = this.valveMenu;
			this.vi_HV.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_HV.Location = new System.Drawing.Point(247, 87);
			this.vi_HV.Name = "vi_HV";
			this.vi_HV.Size = new System.Drawing.Size(19, 19);
			this.vi_HV.TabIndex = 206;
			this.vi_HV.TabStop = false;
			this.vi_HV.Tag = "";
			this.vi_HV.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_HV.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_HV.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_HV.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_CO2_GM_flow
			// 
			this.vi_CO2_GM_flow.AccessibleDescription = "CO2-GM flow valve";
			this.vi_CO2_GM_flow.Actuator = null;
			this.vi_CO2_GM_flow.BackColor = System.Drawing.Color.Blue;
			this.vi_CO2_GM_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_CO2_GM_flow.ContextMenuStrip = this.valveMenu;
			this.vi_CO2_GM_flow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_CO2_GM_flow.Location = new System.Drawing.Point(718, 146);
			this.vi_CO2_GM_flow.Name = "vi_CO2_GM_flow";
			this.vi_CO2_GM_flow.Size = new System.Drawing.Size(19, 19);
			this.vi_CO2_GM_flow.TabIndex = 192;
			this.vi_CO2_GM_flow.TabStop = false;
			this.vi_CO2_GM_flow.Tag = "";
			this.vi_CO2_GM_flow.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_CO2_GM_flow.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_CO2_GM_flow.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_CO2_GM_flow.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_H2_GM_flow
			// 
			this.vi_H2_GM_flow.AccessibleDescription = "H2-GM flow valve";
			this.vi_H2_GM_flow.Actuator = null;
			this.vi_H2_GM_flow.BackColor = System.Drawing.Color.Blue;
			this.vi_H2_GM_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_H2_GM_flow.ContextMenuStrip = this.valveMenu;
			this.vi_H2_GM_flow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_H2_GM_flow.Location = new System.Drawing.Point(741, 169);
			this.vi_H2_GM_flow.Name = "vi_H2_GM_flow";
			this.vi_H2_GM_flow.Size = new System.Drawing.Size(19, 19);
			this.vi_H2_GM_flow.TabIndex = 190;
			this.vi_H2_GM_flow.TabStop = false;
			this.vi_H2_GM_flow.Tag = "";
			this.vi_H2_GM_flow.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_H2_GM_flow.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_H2_GM_flow.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_H2_GM_flow.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_He_GM_flow
			// 
			this.vi_He_GM_flow.AccessibleDescription = "He-GM flow valve";
			this.vi_He_GM_flow.Actuator = null;
			this.vi_He_GM_flow.BackColor = System.Drawing.Color.Blue;
			this.vi_He_GM_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_He_GM_flow.ContextMenuStrip = this.valveMenu;
			this.vi_He_GM_flow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_He_GM_flow.Location = new System.Drawing.Point(745, 219);
			this.vi_He_GM_flow.Name = "vi_He_GM_flow";
			this.vi_He_GM_flow.Size = new System.Drawing.Size(19, 19);
			this.vi_He_GM_flow.TabIndex = 188;
			this.vi_He_GM_flow.TabStop = false;
			this.vi_He_GM_flow.Tag = "";
			this.vi_He_GM_flow.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_He_GM_flow.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_He_GM_flow.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_He_GM_flow.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_He_GM
			// 
			this.vi_He_GM.AccessibleDescription = "He-GM valve";
			this.vi_He_GM.Actuator = null;
			this.vi_He_GM.BackColor = System.Drawing.Color.Blue;
			this.vi_He_GM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_He_GM.ContextMenuStrip = this.valveMenu;
			this.vi_He_GM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_He_GM.Location = new System.Drawing.Point(718, 219);
			this.vi_He_GM.Name = "vi_He_GM";
			this.vi_He_GM.Size = new System.Drawing.Size(19, 19);
			this.vi_He_GM.TabIndex = 187;
			this.vi_He_GM.TabStop = false;
			this.vi_He_GM.Tag = "";
			this.vi_He_GM.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_He_GM.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_He_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_He_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// vi_VTT_flow
			// 
			this.vi_VTT_flow.AccessibleDescription = "VTT flow valve";
			this.vi_VTT_flow.Actuator = null;
			this.vi_VTT_flow.BackColor = System.Drawing.Color.Blue;
			this.vi_VTT_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vi_VTT_flow.ContextMenuStrip = this.valveMenu;
			this.vi_VTT_flow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vi_VTT_flow.Location = new System.Drawing.Point(120, 173);
			this.vi_VTT_flow.Name = "vi_VTT_flow";
			this.vi_VTT_flow.Size = new System.Drawing.Size(19, 19);
			this.vi_VTT_flow.TabIndex = 180;
			this.vi_VTT_flow.TabStop = false;
			this.vi_VTT_flow.Tag = "";
			this.vi_VTT_flow.DeviceStateChanged += new System.EventHandler(this.RequestService);
			this.vi_VTT_flow.DoubleClick += new System.EventHandler(this.valveDoubleClick);
			this.vi_VTT_flow.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.vi_VTT_flow.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// roc_ugC
			// 
			this.roc_ugC.AccessibleDescription = "MC sample mass rate of change (μgC/s)";
			this.roc_ugC.BackColor = System.Drawing.Color.Silver;
			this.roc_ugC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.roc_ugC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roc_ugC.Location = new System.Drawing.Point(501, 167);
			this.roc_ugC.Name = "roc_ugC";
			this.roc_ugC.Size = new System.Drawing.Size(40, 15);
			this.roc_ugC.TabIndex = 172;
			this.roc_ugC.Tag = "";
			this.roc_ugC.Text = "0";
			this.roc_ugC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.roc_ugC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.roc_ugC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ugCLabel
			// 
			this.ugCLabel.AutoSize = true;
			this.ugCLabel.BackColor = System.Drawing.Color.Transparent;
			this.ugCLabel.Location = new System.Drawing.Point(500, 133);
			this.ugCLabel.Margin = new System.Windows.Forms.Padding(0);
			this.ugCLabel.Name = "ugCLabel";
			this.ugCLabel.Size = new System.Drawing.Size(56, 13);
			this.ugCLabel.TabIndex = 166;
			this.ugCLabel.Text = "µgC in MC";
			// 
			// ugC
			// 
			this.ugC.AccessibleDescription = "Micrograms of carbon in the measurement chamber";
			this.ugC.BackColor = System.Drawing.Color.Silver;
			this.ugC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ugC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ugC.Location = new System.Drawing.Point(501, 148);
			this.ugC.Name = "ugC";
			this.ugC.Size = new System.Drawing.Size(55, 18);
			this.ugC.TabIndex = 164;
			this.ugC.Tag = "";
			this.ugC.Text = "0";
			this.ugC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ugC.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ugC.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label66
			// 
			this.label66.AutoSize = true;
			this.label66.BackColor = System.Drawing.Color.Transparent;
			this.label66.Location = new System.Drawing.Point(406, 13);
			this.label66.Margin = new System.Windows.Forms.Padding(0);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(26, 13);
			this.label66.TabIndex = 152;
			this.label66.Text = "Torr";
			this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(406, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 152;
			this.label1.Text = "°C";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HeLabel4
			// 
			this.HeLabel4.AutoSize = true;
			this.HeLabel4.BackColor = System.Drawing.Color.Transparent;
			this.HeLabel4.Location = new System.Drawing.Point(792, 222);
			this.HeLabel4.Margin = new System.Windows.Forms.Padding(0);
			this.HeLabel4.Name = "HeLabel4";
			this.HeLabel4.Size = new System.Drawing.Size(21, 13);
			this.HeLabel4.TabIndex = 127;
			this.HeLabel4.Text = "He";
			// 
			// HeLabel2
			// 
			this.HeLabel2.AutoSize = true;
			this.HeLabel2.BackColor = System.Drawing.Color.Transparent;
			this.HeLabel2.Location = new System.Drawing.Point(119, 264);
			this.HeLabel2.Margin = new System.Windows.Forms.Padding(0);
			this.HeLabel2.Name = "HeLabel2";
			this.HeLabel2.Size = new System.Drawing.Size(21, 13);
			this.HeLabel2.TabIndex = 125;
			this.HeLabel2.Text = "He";
			// 
			// HeLabel1
			// 
			this.HeLabel1.AutoSize = true;
			this.HeLabel1.BackColor = System.Drawing.Color.Transparent;
			this.HeLabel1.Location = new System.Drawing.Point(7, 264);
			this.HeLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.HeLabel1.Name = "HeLabel1";
			this.HeLabel1.Size = new System.Drawing.Size(21, 13);
			this.HeLabel1.TabIndex = 124;
			this.HeLabel1.Text = "He";
			// 
			// H2Label
			// 
			this.H2Label.AutoSize = true;
			this.H2Label.BackColor = System.Drawing.Color.Transparent;
			this.H2Label.Location = new System.Drawing.Point(741, 128);
			this.H2Label.Margin = new System.Windows.Forms.Padding(0);
			this.H2Label.Name = "H2Label";
			this.H2Label.Size = new System.Drawing.Size(21, 13);
			this.H2Label.TabIndex = 123;
			this.H2Label.Text = "H2";
			// 
			// CO2Label
			// 
			this.CO2Label.AutoSize = true;
			this.CO2Label.BackColor = System.Drawing.Color.Transparent;
			this.CO2Label.Location = new System.Drawing.Point(713, 105);
			this.CO2Label.Margin = new System.Windows.Forms.Padding(0);
			this.CO2Label.Name = "CO2Label";
			this.CO2Label.Size = new System.Drawing.Size(28, 13);
			this.CO2Label.TabIndex = 122;
			this.CO2Label.Text = "CO2";
			// 
			// O2Label1
			// 
			this.O2Label1.AutoSize = true;
			this.O2Label1.BackColor = System.Drawing.Color.Transparent;
			this.O2Label1.Location = new System.Drawing.Point(8, 132);
			this.O2Label1.Margin = new System.Windows.Forms.Padding(0);
			this.O2Label1.Name = "O2Label1";
			this.O2Label1.Size = new System.Drawing.Size(21, 13);
			this.O2Label1.TabIndex = 120;
			this.O2Label1.Text = "O2";
			// 
			// d_Pump_HV
			// 
			this.d_Pump_HV.AccessibleDescription = "Turbo pump";
			this.d_Pump_HV.AccessibleName = "Turbo pump";
			this.d_Pump_HV.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.d_Pump_HV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_Pump_HV.ContextMenuStrip = this.OnOffMenu;
			this.d_Pump_HV.ErrorImage = null;
			this.d_Pump_HV.InitialImage = null;
			this.d_Pump_HV.Location = new System.Drawing.Point(239, 60);
			this.d_Pump_HV.Name = "d_Pump_HV";
			this.d_Pump_HV.Size = new System.Drawing.Size(35, 27);
			this.d_Pump_HV.TabIndex = 102;
			this.d_Pump_HV.TabStop = false;
			this.d_Pump_HV.Tag = "";
			this.d_Pump_HV.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_Pump_HV.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// d_RoughingPump
			// 
			this.d_RoughingPump.AccessibleDescription = "Roughing pump";
			this.d_RoughingPump.AccessibleName = "Roughing pump";
			this.d_RoughingPump.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.d_RoughingPump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.d_RoughingPump.ErrorImage = null;
			this.d_RoughingPump.InitialImage = null;
			this.d_RoughingPump.Location = new System.Drawing.Point(297, 6);
			this.d_RoughingPump.Name = "d_RoughingPump";
			this.d_RoughingPump.Size = new System.Drawing.Size(35, 27);
			this.d_RoughingPump.TabIndex = 101;
			this.d_RoughingPump.TabStop = false;
			this.d_RoughingPump.Tag = "";
			this.d_RoughingPump.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.d_RoughingPump.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR6_panel
			// 
			this.GR6_panel.AutoSize = true;
			this.GR6_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GR6_panel.Controls.Add(this.sp_GR6_F);
			this.GR6_panel.Controls.Add(this.p_GR6);
			this.GR6_panel.Controls.Add(this.t_GR6_F);
			this.GR6_panel.Controls.Add(this.t_GR6_CF);
			this.GR6_panel.Location = new System.Drawing.Point(608, 303);
			this.GR6_panel.Margin = new System.Windows.Forms.Padding(0);
			this.GR6_panel.Name = "GR6_panel";
			this.GR6_panel.Size = new System.Drawing.Size(35, 60);
			this.GR6_panel.TabIndex = 85;
			this.GR6_panel.Tag = "";
			// 
			// p_GR6
			// 
			this.p_GR6.AccessibleDescription = "GR6 pressure";
			this.p_GR6.BackColor = System.Drawing.Color.Silver;
			this.p_GR6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GR6.ClipMaximum = false;
			this.p_GR6.ClipMinimum = true;
			this.p_GR6.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GR6.Device = null;
			this.p_GR6.DeviceOn = false;
			this.p_GR6.DeviceState = null;
			this.p_GR6.DisplayFormat = "0";
			this.p_GR6.Error = 0;
			this.p_GR6.LinkedControl = null;
			this.p_GR6.Location = new System.Drawing.Point(0, 0);
			this.p_GR6.Margin = new System.Windows.Forms.Padding(0);
			this.p_GR6.Maximum = 1690D;
			this.p_GR6.Minimum = 0D;
			this.p_GR6.Name = "p_GR6";
			this.p_GR6.OverRange = false;
			this.p_GR6.Prefix = null;
			this.p_GR6.SignificantDigits = 3;
			this.p_GR6.Size = new System.Drawing.Size(35, 20);
			this.p_GR6.Suffix = null;
			this.p_GR6.TabIndex = 41;
			this.p_GR6.Tag = "";
			this.p_GR6.Text = "0";
			this.p_GR6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GR6.UnderRange = false;
			this.p_GR6.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GR6.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GR6.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GR6.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GR6.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR6_F
			// 
			this.t_GR6_F.AccessibleDescription = "GR6 furnace temperature";
			this.t_GR6_F.AccessibleName = "GR6";
			this.t_GR6_F.BackColor = System.Drawing.Color.Silver;
			this.t_GR6_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR6_F.ClipMaximum = false;
			this.t_GR6_F.ClipMinimum = false;
			this.t_GR6_F.ContextMenuStrip = this.heaterMenu;
			this.t_GR6_F.Device = null;
			this.t_GR6_F.DeviceOn = false;
			this.t_GR6_F.DeviceState = null;
			this.t_GR6_F.DisplayFormat = "0";
			this.t_GR6_F.Error = 0;
			this.t_GR6_F.LinkedControl = this.sp_GR6_F;
			this.t_GR6_F.Location = new System.Drawing.Point(0, 20);
			this.t_GR6_F.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR6_F.Maximum = 1500D;
			this.t_GR6_F.Minimum = -196D;
			this.t_GR6_F.Name = "t_GR6_F";
			this.t_GR6_F.OverRange = false;
			this.t_GR6_F.Prefix = null;
			this.t_GR6_F.SignificantDigits = 3;
			this.t_GR6_F.Size = new System.Drawing.Size(35, 20);
			this.t_GR6_F.Suffix = null;
			this.t_GR6_F.TabIndex = 42;
			this.t_GR6_F.Tag = "";
			this.t_GR6_F.Text = "0.0";
			this.t_GR6_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR6_F.UnderRange = false;
			this.t_GR6_F.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR6_F.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR6_F.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR6_F.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR6_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR6_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR6_CF
			// 
			this.t_GR6_CF.AccessibleDescription = "GR6 coldfinger temperature";
			this.t_GR6_CF.AccessibleName = "GR6 coldfinger";
			this.t_GR6_CF.BackColor = System.Drawing.Color.Silver;
			this.t_GR6_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR6_CF.ClipMaximum = false;
			this.t_GR6_CF.ClipMinimum = false;
			this.t_GR6_CF.ContextMenuStrip = this.ftcMenu;
			this.t_GR6_CF.Device = null;
			this.t_GR6_CF.DeviceOn = false;
			this.t_GR6_CF.DeviceState = null;
			this.t_GR6_CF.DisplayFormat = "0";
			this.t_GR6_CF.Error = 0;
			this.t_GR6_CF.LinkedControl = null;
			this.t_GR6_CF.Location = new System.Drawing.Point(0, 40);
			this.t_GR6_CF.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR6_CF.Maximum = 500D;
			this.t_GR6_CF.Minimum = -196D;
			this.t_GR6_CF.Name = "t_GR6_CF";
			this.t_GR6_CF.OverRange = false;
			this.t_GR6_CF.Prefix = null;
			this.t_GR6_CF.SignificantDigits = 3;
			this.t_GR6_CF.Size = new System.Drawing.Size(35, 20);
			this.t_GR6_CF.Suffix = null;
			this.t_GR6_CF.TabIndex = 44;
			this.t_GR6_CF.Tag = "";
			this.t_GR6_CF.Text = "0";
			this.t_GR6_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR6_CF.UnderRange = false;
			this.t_GR6_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR6_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR6_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR6_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR6_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR6_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR5_panel
			// 
			this.GR5_panel.AutoSize = true;
			this.GR5_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GR5_panel.Controls.Add(this.sp_GR5_F);
			this.GR5_panel.Controls.Add(this.p_GR5);
			this.GR5_panel.Controls.Add(this.t_GR5_F);
			this.GR5_panel.Controls.Add(this.t_GR5_CF);
			this.GR5_panel.Location = new System.Drawing.Point(573, 303);
			this.GR5_panel.Margin = new System.Windows.Forms.Padding(0);
			this.GR5_panel.Name = "GR5_panel";
			this.GR5_panel.Size = new System.Drawing.Size(35, 60);
			this.GR5_panel.TabIndex = 85;
			this.GR5_panel.Tag = "";
			// 
			// p_GR5
			// 
			this.p_GR5.AccessibleDescription = "GR5 pressure";
			this.p_GR5.BackColor = System.Drawing.Color.Silver;
			this.p_GR5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GR5.ClipMaximum = false;
			this.p_GR5.ClipMinimum = true;
			this.p_GR5.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GR5.Device = null;
			this.p_GR5.DeviceOn = false;
			this.p_GR5.DeviceState = null;
			this.p_GR5.DisplayFormat = "0";
			this.p_GR5.Error = 0;
			this.p_GR5.LinkedControl = null;
			this.p_GR5.Location = new System.Drawing.Point(0, 0);
			this.p_GR5.Margin = new System.Windows.Forms.Padding(0);
			this.p_GR5.Maximum = 1690D;
			this.p_GR5.Minimum = 0D;
			this.p_GR5.Name = "p_GR5";
			this.p_GR5.OverRange = false;
			this.p_GR5.Prefix = null;
			this.p_GR5.SignificantDigits = 3;
			this.p_GR5.Size = new System.Drawing.Size(35, 20);
			this.p_GR5.Suffix = null;
			this.p_GR5.TabIndex = 37;
			this.p_GR5.Tag = "";
			this.p_GR5.Text = "0";
			this.p_GR5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GR5.UnderRange = false;
			this.p_GR5.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GR5.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GR5.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GR5.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GR5.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR5_F
			// 
			this.t_GR5_F.AccessibleDescription = "GR5 furnace temperature";
			this.t_GR5_F.AccessibleName = "GR5";
			this.t_GR5_F.BackColor = System.Drawing.Color.Silver;
			this.t_GR5_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR5_F.ClipMaximum = false;
			this.t_GR5_F.ClipMinimum = false;
			this.t_GR5_F.ContextMenuStrip = this.heaterMenu;
			this.t_GR5_F.Device = null;
			this.t_GR5_F.DeviceOn = false;
			this.t_GR5_F.DeviceState = null;
			this.t_GR5_F.DisplayFormat = "0";
			this.t_GR5_F.Error = 0;
			this.t_GR5_F.LinkedControl = this.sp_GR5_F;
			this.t_GR5_F.Location = new System.Drawing.Point(0, 20);
			this.t_GR5_F.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR5_F.Maximum = 1500D;
			this.t_GR5_F.Minimum = -196D;
			this.t_GR5_F.Name = "t_GR5_F";
			this.t_GR5_F.OverRange = false;
			this.t_GR5_F.Prefix = null;
			this.t_GR5_F.SignificantDigits = 3;
			this.t_GR5_F.Size = new System.Drawing.Size(35, 20);
			this.t_GR5_F.Suffix = null;
			this.t_GR5_F.TabIndex = 38;
			this.t_GR5_F.Tag = "";
			this.t_GR5_F.Text = "0.0";
			this.t_GR5_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR5_F.UnderRange = false;
			this.t_GR5_F.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR5_F.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR5_F.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR5_F.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR5_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR5_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR5_CF
			// 
			this.t_GR5_CF.AccessibleDescription = "GR5 coldfinger temperature";
			this.t_GR5_CF.AccessibleName = "GR5 coldfinger";
			this.t_GR5_CF.BackColor = System.Drawing.Color.Silver;
			this.t_GR5_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR5_CF.ClipMaximum = false;
			this.t_GR5_CF.ClipMinimum = false;
			this.t_GR5_CF.ContextMenuStrip = this.ftcMenu;
			this.t_GR5_CF.Device = null;
			this.t_GR5_CF.DeviceOn = false;
			this.t_GR5_CF.DeviceState = null;
			this.t_GR5_CF.DisplayFormat = "0";
			this.t_GR5_CF.Error = 0;
			this.t_GR5_CF.LinkedControl = null;
			this.t_GR5_CF.Location = new System.Drawing.Point(0, 40);
			this.t_GR5_CF.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR5_CF.Maximum = 500D;
			this.t_GR5_CF.Minimum = -196D;
			this.t_GR5_CF.Name = "t_GR5_CF";
			this.t_GR5_CF.OverRange = false;
			this.t_GR5_CF.Prefix = null;
			this.t_GR5_CF.SignificantDigits = 3;
			this.t_GR5_CF.Size = new System.Drawing.Size(35, 20);
			this.t_GR5_CF.Suffix = null;
			this.t_GR5_CF.TabIndex = 40;
			this.t_GR5_CF.Tag = "";
			this.t_GR5_CF.Text = "0";
			this.t_GR5_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR5_CF.UnderRange = false;
			this.t_GR5_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR5_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR5_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR5_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR5_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR5_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR4_panel
			// 
			this.GR4_panel.AutoSize = true;
			this.GR4_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GR4_panel.Controls.Add(this.sp_GR4_F);
			this.GR4_panel.Controls.Add(this.p_GR4);
			this.GR4_panel.Controls.Add(this.t_GR4_F);
			this.GR4_panel.Controls.Add(this.t_GR4_CF);
			this.GR4_panel.Location = new System.Drawing.Point(538, 303);
			this.GR4_panel.Margin = new System.Windows.Forms.Padding(0);
			this.GR4_panel.Name = "GR4_panel";
			this.GR4_panel.Size = new System.Drawing.Size(35, 60);
			this.GR4_panel.TabIndex = 85;
			this.GR4_panel.Tag = "";
			// 
			// p_GR4
			// 
			this.p_GR4.AccessibleDescription = "GR4 pressure";
			this.p_GR4.BackColor = System.Drawing.Color.Silver;
			this.p_GR4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GR4.ClipMaximum = false;
			this.p_GR4.ClipMinimum = true;
			this.p_GR4.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GR4.Device = null;
			this.p_GR4.DeviceOn = false;
			this.p_GR4.DeviceState = null;
			this.p_GR4.DisplayFormat = "0";
			this.p_GR4.Error = 0;
			this.p_GR4.LinkedControl = null;
			this.p_GR4.Location = new System.Drawing.Point(0, 0);
			this.p_GR4.Margin = new System.Windows.Forms.Padding(0);
			this.p_GR4.Maximum = 1690D;
			this.p_GR4.Minimum = 0D;
			this.p_GR4.Name = "p_GR4";
			this.p_GR4.OverRange = false;
			this.p_GR4.Prefix = null;
			this.p_GR4.SignificantDigits = 3;
			this.p_GR4.Size = new System.Drawing.Size(35, 20);
			this.p_GR4.Suffix = null;
			this.p_GR4.TabIndex = 33;
			this.p_GR4.Tag = "";
			this.p_GR4.Text = "0";
			this.p_GR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GR4.UnderRange = false;
			this.p_GR4.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GR4.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GR4.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GR4.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GR4.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR4_F
			// 
			this.t_GR4_F.AccessibleDescription = "GR4 furnace temperature";
			this.t_GR4_F.AccessibleName = "GR4";
			this.t_GR4_F.BackColor = System.Drawing.Color.Silver;
			this.t_GR4_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR4_F.ClipMaximum = false;
			this.t_GR4_F.ClipMinimum = false;
			this.t_GR4_F.ContextMenuStrip = this.heaterMenu;
			this.t_GR4_F.Device = null;
			this.t_GR4_F.DeviceOn = false;
			this.t_GR4_F.DeviceState = null;
			this.t_GR4_F.DisplayFormat = "0";
			this.t_GR4_F.Error = 0;
			this.t_GR4_F.LinkedControl = this.sp_GR4_F;
			this.t_GR4_F.Location = new System.Drawing.Point(0, 20);
			this.t_GR4_F.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR4_F.Maximum = 1500D;
			this.t_GR4_F.Minimum = -196D;
			this.t_GR4_F.Name = "t_GR4_F";
			this.t_GR4_F.OverRange = false;
			this.t_GR4_F.Prefix = null;
			this.t_GR4_F.SignificantDigits = 3;
			this.t_GR4_F.Size = new System.Drawing.Size(35, 20);
			this.t_GR4_F.Suffix = null;
			this.t_GR4_F.TabIndex = 34;
			this.t_GR4_F.Tag = "";
			this.t_GR4_F.Text = "0.0";
			this.t_GR4_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR4_F.UnderRange = false;
			this.t_GR4_F.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR4_F.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR4_F.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR4_F.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR4_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR4_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR4_CF
			// 
			this.t_GR4_CF.AccessibleDescription = "GR4 coldfinger temperature";
			this.t_GR4_CF.AccessibleName = "GR4 coldfinger";
			this.t_GR4_CF.BackColor = System.Drawing.Color.Silver;
			this.t_GR4_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR4_CF.ClipMaximum = false;
			this.t_GR4_CF.ClipMinimum = false;
			this.t_GR4_CF.ContextMenuStrip = this.ftcMenu;
			this.t_GR4_CF.Device = null;
			this.t_GR4_CF.DeviceOn = false;
			this.t_GR4_CF.DeviceState = null;
			this.t_GR4_CF.DisplayFormat = "0";
			this.t_GR4_CF.Error = 0;
			this.t_GR4_CF.LinkedControl = null;
			this.t_GR4_CF.Location = new System.Drawing.Point(0, 40);
			this.t_GR4_CF.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR4_CF.Maximum = 500D;
			this.t_GR4_CF.Minimum = -196D;
			this.t_GR4_CF.Name = "t_GR4_CF";
			this.t_GR4_CF.OverRange = false;
			this.t_GR4_CF.Prefix = null;
			this.t_GR4_CF.SignificantDigits = 3;
			this.t_GR4_CF.Size = new System.Drawing.Size(35, 20);
			this.t_GR4_CF.Suffix = null;
			this.t_GR4_CF.TabIndex = 36;
			this.t_GR4_CF.Tag = "";
			this.t_GR4_CF.Text = "0";
			this.t_GR4_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR4_CF.UnderRange = false;
			this.t_GR4_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR4_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR4_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR4_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR4_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR4_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR3_panel
			// 
			this.GR3_panel.AutoSize = true;
			this.GR3_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GR3_panel.Controls.Add(this.sp_GR3_F);
			this.GR3_panel.Controls.Add(this.p_GR3);
			this.GR3_panel.Controls.Add(this.t_GR3_F);
			this.GR3_panel.Controls.Add(this.t_GR3_CF);
			this.GR3_panel.Location = new System.Drawing.Point(503, 303);
			this.GR3_panel.Margin = new System.Windows.Forms.Padding(0);
			this.GR3_panel.Name = "GR3_panel";
			this.GR3_panel.Size = new System.Drawing.Size(35, 60);
			this.GR3_panel.TabIndex = 84;
			this.GR3_panel.Tag = "";
			// 
			// p_GR3
			// 
			this.p_GR3.AccessibleDescription = "GR3 pressure";
			this.p_GR3.BackColor = System.Drawing.Color.Silver;
			this.p_GR3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GR3.ClipMaximum = false;
			this.p_GR3.ClipMinimum = true;
			this.p_GR3.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GR3.Device = null;
			this.p_GR3.DeviceOn = false;
			this.p_GR3.DeviceState = null;
			this.p_GR3.DisplayFormat = "0";
			this.p_GR3.Error = 0;
			this.p_GR3.LinkedControl = null;
			this.p_GR3.Location = new System.Drawing.Point(0, 0);
			this.p_GR3.Margin = new System.Windows.Forms.Padding(0);
			this.p_GR3.Maximum = 1690D;
			this.p_GR3.Minimum = 0D;
			this.p_GR3.Name = "p_GR3";
			this.p_GR3.OverRange = false;
			this.p_GR3.Prefix = null;
			this.p_GR3.SignificantDigits = 3;
			this.p_GR3.Size = new System.Drawing.Size(35, 20);
			this.p_GR3.Suffix = null;
			this.p_GR3.TabIndex = 29;
			this.p_GR3.Tag = "";
			this.p_GR3.Text = "0";
			this.p_GR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GR3.UnderRange = false;
			this.p_GR3.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GR3.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GR3.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GR3.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GR3.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR3_F
			// 
			this.t_GR3_F.AccessibleDescription = "GR3 furnace temperature";
			this.t_GR3_F.AccessibleName = "GR3";
			this.t_GR3_F.BackColor = System.Drawing.Color.Silver;
			this.t_GR3_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR3_F.ClipMaximum = false;
			this.t_GR3_F.ClipMinimum = false;
			this.t_GR3_F.ContextMenuStrip = this.heaterMenu;
			this.t_GR3_F.Device = null;
			this.t_GR3_F.DeviceOn = false;
			this.t_GR3_F.DeviceState = null;
			this.t_GR3_F.DisplayFormat = "0";
			this.t_GR3_F.Error = 0;
			this.t_GR3_F.LinkedControl = this.sp_GR3_F;
			this.t_GR3_F.Location = new System.Drawing.Point(0, 20);
			this.t_GR3_F.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR3_F.Maximum = 1500D;
			this.t_GR3_F.Minimum = -196D;
			this.t_GR3_F.Name = "t_GR3_F";
			this.t_GR3_F.OverRange = false;
			this.t_GR3_F.Prefix = null;
			this.t_GR3_F.SignificantDigits = 3;
			this.t_GR3_F.Size = new System.Drawing.Size(35, 20);
			this.t_GR3_F.Suffix = null;
			this.t_GR3_F.TabIndex = 30;
			this.t_GR3_F.Tag = "";
			this.t_GR3_F.Text = "0.0";
			this.t_GR3_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR3_F.UnderRange = false;
			this.t_GR3_F.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR3_F.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR3_F.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR3_F.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR3_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR3_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR3_CF
			// 
			this.t_GR3_CF.AccessibleDescription = "GR3 coldfinger temperature";
			this.t_GR3_CF.AccessibleName = "GR3 coldfinger";
			this.t_GR3_CF.BackColor = System.Drawing.Color.Silver;
			this.t_GR3_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR3_CF.ClipMaximum = false;
			this.t_GR3_CF.ClipMinimum = false;
			this.t_GR3_CF.ContextMenuStrip = this.ftcMenu;
			this.t_GR3_CF.Device = null;
			this.t_GR3_CF.DeviceOn = false;
			this.t_GR3_CF.DeviceState = null;
			this.t_GR3_CF.DisplayFormat = "0";
			this.t_GR3_CF.Error = 0;
			this.t_GR3_CF.LinkedControl = null;
			this.t_GR3_CF.Location = new System.Drawing.Point(0, 40);
			this.t_GR3_CF.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR3_CF.Maximum = 500D;
			this.t_GR3_CF.Minimum = -196D;
			this.t_GR3_CF.Name = "t_GR3_CF";
			this.t_GR3_CF.OverRange = false;
			this.t_GR3_CF.Prefix = null;
			this.t_GR3_CF.SignificantDigits = 3;
			this.t_GR3_CF.Size = new System.Drawing.Size(35, 20);
			this.t_GR3_CF.Suffix = null;
			this.t_GR3_CF.TabIndex = 32;
			this.t_GR3_CF.Tag = "";
			this.t_GR3_CF.Text = "0";
			this.t_GR3_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR3_CF.UnderRange = false;
			this.t_GR3_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR3_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR3_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR3_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR3_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR3_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GR1_panel
			// 
			this.GR1_panel.AutoSize = true;
			this.GR1_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GR1_panel.Controls.Add(this.p_GR1);
			this.GR1_panel.Controls.Add(this.sp_GR1_F);
			this.GR1_panel.Controls.Add(this.t_GR1_F);
			this.GR1_panel.Controls.Add(this.t_GR1_CF);
			this.GR1_panel.Location = new System.Drawing.Point(433, 303);
			this.GR1_panel.Margin = new System.Windows.Forms.Padding(0);
			this.GR1_panel.Name = "GR1_panel";
			this.GR1_panel.Size = new System.Drawing.Size(35, 60);
			this.GR1_panel.TabIndex = 82;
			this.GR1_panel.Tag = "";
			// 
			// p_GR1
			// 
			this.p_GR1.AccessibleDescription = "GR1 pressure";
			this.p_GR1.BackColor = System.Drawing.Color.Silver;
			this.p_GR1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GR1.ClipMaximum = false;
			this.p_GR1.ClipMinimum = true;
			this.p_GR1.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GR1.Device = null;
			this.p_GR1.DeviceOn = false;
			this.p_GR1.DeviceState = null;
			this.p_GR1.DisplayFormat = "0";
			this.p_GR1.Error = 0;
			this.p_GR1.LinkedControl = null;
			this.p_GR1.Location = new System.Drawing.Point(0, 0);
			this.p_GR1.Margin = new System.Windows.Forms.Padding(0);
			this.p_GR1.Maximum = 1690D;
			this.p_GR1.Minimum = 0D;
			this.p_GR1.Name = "p_GR1";
			this.p_GR1.OverRange = false;
			this.p_GR1.Prefix = null;
			this.p_GR1.SignificantDigits = 3;
			this.p_GR1.Size = new System.Drawing.Size(35, 20);
			this.p_GR1.Suffix = null;
			this.p_GR1.TabIndex = 8;
			this.p_GR1.Tag = "";
			this.p_GR1.Text = "0";
			this.p_GR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GR1.UnderRange = false;
			this.p_GR1.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GR1.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GR1.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GR1.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GR1.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR1_F
			// 
			this.t_GR1_F.AccessibleDescription = "GR1 furnace temperature";
			this.t_GR1_F.AccessibleName = "GR1";
			this.t_GR1_F.BackColor = System.Drawing.Color.Silver;
			this.t_GR1_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR1_F.ClipMaximum = false;
			this.t_GR1_F.ClipMinimum = false;
			this.t_GR1_F.ContextMenuStrip = this.heaterMenu;
			this.t_GR1_F.Device = null;
			this.t_GR1_F.DeviceOn = false;
			this.t_GR1_F.DeviceState = null;
			this.t_GR1_F.DisplayFormat = "0";
			this.t_GR1_F.Error = 0;
			this.t_GR1_F.LinkedControl = this.sp_GR1_F;
			this.t_GR1_F.Location = new System.Drawing.Point(0, 20);
			this.t_GR1_F.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR1_F.Maximum = 1500D;
			this.t_GR1_F.Minimum = -196D;
			this.t_GR1_F.Name = "t_GR1_F";
			this.t_GR1_F.OverRange = false;
			this.t_GR1_F.Prefix = null;
			this.t_GR1_F.SignificantDigits = 3;
			this.t_GR1_F.Size = new System.Drawing.Size(35, 20);
			this.t_GR1_F.Suffix = null;
			this.t_GR1_F.TabIndex = 21;
			this.t_GR1_F.Tag = "";
			this.t_GR1_F.Text = "0.0";
			this.t_GR1_F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR1_F.UnderRange = false;
			this.t_GR1_F.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR1_F.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR1_F.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR1_F.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR1_F.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR1_F.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_GR1_CF
			// 
			this.t_GR1_CF.AccessibleDescription = "GR1 coldfinger temperature";
			this.t_GR1_CF.AccessibleName = "GR1 coldfinger";
			this.t_GR1_CF.BackColor = System.Drawing.Color.Silver;
			this.t_GR1_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_GR1_CF.ClipMaximum = false;
			this.t_GR1_CF.ClipMinimum = false;
			this.t_GR1_CF.ContextMenuStrip = this.ftcMenu;
			this.t_GR1_CF.Device = null;
			this.t_GR1_CF.DeviceOn = false;
			this.t_GR1_CF.DeviceState = null;
			this.t_GR1_CF.DisplayFormat = "0";
			this.t_GR1_CF.Error = 0;
			this.t_GR1_CF.LinkedControl = null;
			this.t_GR1_CF.Location = new System.Drawing.Point(0, 40);
			this.t_GR1_CF.Margin = new System.Windows.Forms.Padding(0);
			this.t_GR1_CF.Maximum = 500D;
			this.t_GR1_CF.Minimum = -196D;
			this.t_GR1_CF.Name = "t_GR1_CF";
			this.t_GR1_CF.OverRange = false;
			this.t_GR1_CF.Prefix = null;
			this.t_GR1_CF.SignificantDigits = 3;
			this.t_GR1_CF.Size = new System.Drawing.Size(35, 20);
			this.t_GR1_CF.Suffix = null;
			this.t_GR1_CF.TabIndex = 23;
			this.t_GR1_CF.Tag = "";
			this.t_GR1_CF.Text = "0";
			this.t_GR1_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_GR1_CF.UnderRange = false;
			this.t_GR1_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_GR1_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_GR1_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_GR1_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_GR1_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_GR1_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_CuAg_CF
			// 
			this.t_CuAg_CF.AccessibleDescription = "Cu/Ag coldfinger temperature";
			this.t_CuAg_CF.AccessibleName = "";
			this.t_CuAg_CF.BackColor = System.Drawing.Color.Silver;
			this.t_CuAg_CF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_CuAg_CF.ClipMaximum = false;
			this.t_CuAg_CF.ClipMinimum = false;
			this.t_CuAg_CF.ContextMenuStrip = this.ftcMenu;
			this.t_CuAg_CF.Device = null;
			this.t_CuAg_CF.DeviceOn = false;
			this.t_CuAg_CF.DeviceState = null;
			this.t_CuAg_CF.DisplayFormat = "0";
			this.t_CuAg_CF.Error = 0;
			this.t_CuAg_CF.LinkedControl = null;
			this.t_CuAg_CF.Location = new System.Drawing.Point(258, 266);
			this.t_CuAg_CF.Maximum = 500D;
			this.t_CuAg_CF.Minimum = -196D;
			this.t_CuAg_CF.Name = "t_CuAg_CF";
			this.t_CuAg_CF.OverRange = false;
			this.t_CuAg_CF.Prefix = null;
			this.t_CuAg_CF.SignificantDigits = 3;
			this.t_CuAg_CF.Size = new System.Drawing.Size(40, 18);
			this.t_CuAg_CF.Suffix = null;
			this.t_CuAg_CF.TabIndex = 80;
			this.t_CuAg_CF.Tag = "";
			this.t_CuAg_CF.Text = "0";
			this.t_CuAg_CF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_CuAg_CF.UnderRange = false;
			this.t_CuAg_CF.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_CuAg_CF.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_CuAg_CF.DeviceError += new System.EventHandler(this.RequestService);
			this.t_CuAg_CF.Click += new System.EventHandler(this.jumpToLinkedControl);
			this.t_CuAg_CF.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_CuAg_CF.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_Foreline
			// 
			this.p_Foreline.AccessibleDescription = "Foreline pressure";
			this.p_Foreline.AccessibleName = "Foreline pressure";
			this.p_Foreline.BackColor = System.Drawing.Color.Silver;
			this.p_Foreline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_Foreline.ClipMaximum = false;
			this.p_Foreline.ClipMinimum = false;
			this.p_Foreline.ContextMenuStrip = this.meterDisplayMenu;
			this.p_Foreline.Device = null;
			this.p_Foreline.DeviceOn = false;
			this.p_Foreline.DeviceState = null;
			this.p_Foreline.DisplayFormat = "0.000";
			this.p_Foreline.Error = 0;
			this.p_Foreline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p_Foreline.LinkedControl = null;
			this.p_Foreline.Location = new System.Drawing.Point(365, 63);
			this.p_Foreline.Maximum = 10D;
			this.p_Foreline.Minimum = 0D;
			this.p_Foreline.Name = "p_Foreline";
			this.p_Foreline.OverRange = false;
			this.p_Foreline.Prefix = null;
			this.p_Foreline.SignificantDigits = 3;
			this.p_Foreline.Size = new System.Drawing.Size(70, 24);
			this.p_Foreline.Suffix = null;
			this.p_Foreline.TabIndex = 9;
			this.p_Foreline.Tag = "";
			this.p_Foreline.Text = "0.000";
			this.p_Foreline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_Foreline.UnderRange = false;
			this.p_Foreline.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_Foreline.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_Foreline.DeviceError += new System.EventHandler(this.RequestService);
			this.p_Foreline.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_Foreline.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_GM
			// 
			this.p_GM.AccessibleDescription = "GM pressure";
			this.p_GM.BackColor = System.Drawing.Color.Silver;
			this.p_GM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_GM.ClipMaximum = false;
			this.p_GM.ClipMinimum = false;
			this.p_GM.ContextMenuStrip = this.meterDisplayMenu;
			this.p_GM.Device = null;
			this.p_GM.DeviceOn = false;
			this.p_GM.DeviceState = null;
			this.p_GM.DisplayFormat = "0.0";
			this.p_GM.Error = 0;
			this.p_GM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p_GM.LinkedControl = null;
			this.p_GM.Location = new System.Drawing.Point(641, 142);
			this.p_GM.Maximum = 2000D;
			this.p_GM.Minimum = 0D;
			this.p_GM.Name = "p_GM";
			this.p_GM.OverRange = false;
			this.p_GM.Prefix = null;
			this.p_GM.SignificantDigits = 3;
			this.p_GM.Size = new System.Drawing.Size(70, 24);
			this.p_GM.Suffix = null;
			this.p_GM.TabIndex = 10;
			this.p_GM.Tag = "";
			this.p_GM.Text = "0.0";
			this.p_GM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_GM.UnderRange = false;
			this.p_GM.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_GM.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_GM.DeviceError += new System.EventHandler(this.RequestService);
			this.p_GM.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_GM.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label25
			// 
			this.label25.AccessibleDescription = "Compressed air heater state";
			this.label25.AutoSize = true;
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(172, 52);
			this.label25.Margin = new System.Windows.Forms.Padding(0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(59, 13);
			this.label25.TabIndex = 361;
			this.label25.Text = "pVM target";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pVM_targetTextBox
			// 
			this.pVM_targetTextBox.AccessibleDescription = "Desired process VM pressure";
			this.pVM_targetTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.pVM_targetTextBox.Location = new System.Drawing.Point(231, 49);
			this.pVM_targetTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.pVM_targetTextBox.Name = "pVM_targetTextBox";
			this.pVM_targetTextBox.Size = new System.Drawing.Size(45, 20);
			this.pVM_targetTextBox.TabIndex = 360;
			this.pVM_targetTextBox.Tag = "";
			this.pVM_targetTextBox.Text = "2.0e-4";
			this.pVM_targetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.pVM_targetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.pVM_targetTextBox.Leave += new System.EventHandler(this.Leave_pVM_targetTextBox);
			this.pVM_targetTextBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.pVM_targetTextBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// v_SPS
			// 
			this.v_SPS.AccessibleDescription = "Servo actuator power supply voltage";
			this.v_SPS.BackColor = System.Drawing.Color.Silver;
			this.v_SPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.v_SPS.Location = new System.Drawing.Point(85, 26);
			this.v_SPS.Name = "v_SPS";
			this.v_SPS.Size = new System.Drawing.Size(42, 20);
			this.v_SPS.TabIndex = 322;
			this.v_SPS.Text = "0.000";
			this.v_SPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.v_SPS.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.v_SPS.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(14, 30);
			this.label18.Margin = new System.Windows.Forms.Padding(0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 13);
			this.label18.TabIndex = 320;
			this.label18.Text = "Servo Power";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(17, 110);
			this.label12.Margin = new System.Windows.Forms.Padding(0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 13);
			this.label12.TabIndex = 306;
			this.label12.Text = "T TC2 mux1";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(17, 90);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 13);
			this.label11.TabIndex = 304;
			this.label11.Text = "T TC2 mux0";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(17, 70);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 159;
			this.label5.Text = "T TC1 mux0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(17, 50);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 158;
			this.label4.Text = "T TC0 mux0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(455, 10);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 155;
			this.label3.Text = "Bakeout Line Pressure";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(56, 10);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 153;
			this.label2.Text = "+5V";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ClipTemperatureCheckBox
			// 
			this.ClipTemperatureCheckBox.AccessibleDescription = "Limit low temperature indication to -196.8 °C";
			this.ClipTemperatureCheckBox.AutoSize = true;
			this.ClipTemperatureCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ClipTemperatureCheckBox.Checked = true;
			this.ClipTemperatureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ClipTemperatureCheckBox.Location = new System.Drawing.Point(141, 137);
			this.ClipTemperatureCheckBox.Name = "ClipTemperatureCheckBox";
			this.ClipTemperatureCheckBox.Size = new System.Drawing.Size(137, 17);
			this.ClipTemperatureCheckBox.TabIndex = 9;
			this.ClipTemperatureCheckBox.Text = "Clip Temperatures < LN";
			this.ClipTemperatureCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ClipTemperatureCheckBox.UseVisualStyleBackColor = true;
			this.ClipTemperatureCheckBox.CheckedChanged += new System.EventHandler(this.ClipTemperatureCheckBox_CheckedChanged);
			this.ClipTemperatureCheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ClipTemperatureCheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ClipPressureCheckBox
			// 
			this.ClipPressureCheckBox.AccessibleDescription = "Indicate certain negative pressures as 0";
			this.ClipPressureCheckBox.AutoSize = true;
			this.ClipPressureCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ClipPressureCheckBox.Checked = true;
			this.ClipPressureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ClipPressureCheckBox.Location = new System.Drawing.Point(168, 119);
			this.ClipPressureCheckBox.Name = "ClipPressureCheckBox";
			this.ClipPressureCheckBox.Size = new System.Drawing.Size(110, 17);
			this.ClipPressureCheckBox.TabIndex = 8;
			this.ClipPressureCheckBox.Text = "Clip Pressures < 0";
			this.ClipPressureCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ClipPressureCheckBox.UseVisualStyleBackColor = true;
			this.ClipPressureCheckBox.CheckedChanged += new System.EventHandler(this.ClipPressureCheckBox_CheckedChanged);
			this.ClipPressureCheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ClipPressureCheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabControlPanel);
			this.tabControl1.Controls.Add(this.tabBackPanel);
			this.tabControl1.Controls.Add(this.tabSettings);
			this.tabControl1.Controls.Add(this.tabDeviceSettings);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(960, 633);
			this.tabControl1.TabIndex = 66;
			this.tabControl1.TabStop = false;
			// 
			// tabControlPanel
			// 
			this.tabControlPanel.AutoScroll = true;
			this.tabControlPanel.BackColor = System.Drawing.Color.Silver;
			this.tabControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabControlPanel.Controls.Add(this.mainPanel);
			this.tabControlPanel.Location = new System.Drawing.Point(4, 22);
			this.tabControlPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tabControlPanel.Name = "tabControlPanel";
			this.tabControlPanel.Size = new System.Drawing.Size(952, 607);
			this.tabControlPanel.TabIndex = 0;
			this.tabControlPanel.Text = "Control Panel";
			// 
			// tabBackPanel
			// 
			this.tabBackPanel.BackColor = System.Drawing.Color.Silver;
			this.tabBackPanel.Controls.Add(this.label9);
			this.tabBackPanel.Controls.Add(this.sbTextBox);
			this.tabBackPanel.Controls.Add(this.LastGRTextBox);
			this.tabBackPanel.Controls.Add(this.ljTextBox);
			this.tabBackPanel.Controls.Add(this.label34);
			this.tabBackPanel.Controls.Add(this.t_TC2mux0);
			this.tabBackPanel.Controls.Add(this.label25);
			this.tabBackPanel.Controls.Add(this.v_SPS);
			this.tabBackPanel.Controls.Add(this.pVM_targetTextBox);
			this.tabBackPanel.Controls.Add(this.label4);
			this.tabBackPanel.Controls.Add(this.label18);
			this.tabBackPanel.Controls.Add(this.label12);
			this.tabBackPanel.Controls.Add(this.label11);
			this.tabBackPanel.Controls.Add(this.label5);
			this.tabBackPanel.Controls.Add(this.label2);
			this.tabBackPanel.Controls.Add(this.label3);
			this.tabBackPanel.Controls.Add(this.t_TC2mux1);
			this.tabBackPanel.Controls.Add(this.v_5VSupply);
			this.tabBackPanel.Controls.Add(this.t_TC1mux0);
			this.tabBackPanel.Controls.Add(this.t_TC0mux0);
			this.tabBackPanel.Controls.Add(this.p_Bakeout);
			this.tabBackPanel.Controls.Add(this.GraphiteNumberTextBox);
			this.tabBackPanel.Location = new System.Drawing.Point(4, 22);
			this.tabBackPanel.Name = "tabBackPanel";
			this.tabBackPanel.Size = new System.Drawing.Size(952, 607);
			this.tabBackPanel.TabIndex = 3;
			this.tabBackPanel.Text = "Back Panel";
			// 
			// sbTextBox
			// 
			this.sbTextBox.BackColor = System.Drawing.Color.Silver;
			this.sbTextBox.Location = new System.Drawing.Point(8, 129);
			this.sbTextBox.Multiline = true;
			this.sbTextBox.Name = "sbTextBox";
			this.sbTextBox.ReadOnly = true;
			this.sbTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.sbTextBox.Size = new System.Drawing.Size(325, 40);
			this.sbTextBox.TabIndex = 519;
			// 
			// ljTextBox
			// 
			this.ljTextBox.BackColor = System.Drawing.Color.Silver;
			this.ljTextBox.Location = new System.Drawing.Point(8, 175);
			this.ljTextBox.Multiline = true;
			this.ljTextBox.Name = "ljTextBox";
			this.ljTextBox.ReadOnly = true;
			this.ljTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ljTextBox.Size = new System.Drawing.Size(326, 222);
			this.ljTextBox.TabIndex = 518;
			// 
			// t_TC2mux0
			// 
			this.t_TC2mux0.AccessibleDescription = "TC2 mux0 temperature";
			this.t_TC2mux0.BackColor = System.Drawing.Color.Silver;
			this.t_TC2mux0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_TC2mux0.ClipMaximum = false;
			this.t_TC2mux0.ClipMinimum = false;
			this.t_TC2mux0.Device = null;
			this.t_TC2mux0.DeviceOn = false;
			this.t_TC2mux0.DeviceState = null;
			this.t_TC2mux0.DisplayFormat = "0.0";
			this.t_TC2mux0.Error = 0;
			this.t_TC2mux0.LinkedControl = null;
			this.t_TC2mux0.Location = new System.Drawing.Point(85, 86);
			this.t_TC2mux0.Maximum = 125D;
			this.t_TC2mux0.Minimum = 0D;
			this.t_TC2mux0.Name = "t_TC2mux0";
			this.t_TC2mux0.OverRange = false;
			this.t_TC2mux0.Prefix = null;
			this.t_TC2mux0.SignificantDigits = 3;
			this.t_TC2mux0.Size = new System.Drawing.Size(42, 20);
			this.t_TC2mux0.Suffix = null;
			this.t_TC2mux0.TabIndex = 303;
			this.t_TC2mux0.Tag = "";
			this.t_TC2mux0.Text = "25.0";
			this.t_TC2mux0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_TC2mux0.UnderRange = false;
			this.t_TC2mux0.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_TC2mux0.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_TC2mux0.DeviceError += new System.EventHandler(this.RequestService);
			this.t_TC2mux0.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_TC2mux0.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_TC2mux1
			// 
			this.t_TC2mux1.AccessibleDescription = "TC2 mux1 temperature";
			this.t_TC2mux1.BackColor = System.Drawing.Color.Silver;
			this.t_TC2mux1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_TC2mux1.ClipMaximum = false;
			this.t_TC2mux1.ClipMinimum = false;
			this.t_TC2mux1.Device = null;
			this.t_TC2mux1.DeviceOn = false;
			this.t_TC2mux1.DeviceState = null;
			this.t_TC2mux1.DisplayFormat = "0.0";
			this.t_TC2mux1.Error = 0;
			this.t_TC2mux1.LinkedControl = null;
			this.t_TC2mux1.Location = new System.Drawing.Point(85, 106);
			this.t_TC2mux1.Maximum = 125D;
			this.t_TC2mux1.Minimum = 0D;
			this.t_TC2mux1.Name = "t_TC2mux1";
			this.t_TC2mux1.OverRange = false;
			this.t_TC2mux1.Prefix = null;
			this.t_TC2mux1.SignificantDigits = 3;
			this.t_TC2mux1.Size = new System.Drawing.Size(42, 20);
			this.t_TC2mux1.Suffix = null;
			this.t_TC2mux1.TabIndex = 305;
			this.t_TC2mux1.Tag = "";
			this.t_TC2mux1.Text = "25.0";
			this.t_TC2mux1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_TC2mux1.UnderRange = false;
			this.t_TC2mux1.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_TC2mux1.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_TC2mux1.DeviceError += new System.EventHandler(this.RequestService);
			this.t_TC2mux1.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_TC2mux1.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// v_5VSupply
			// 
			this.v_5VSupply.AccessibleDescription = "+5V power supply voltage";
			this.v_5VSupply.BackColor = System.Drawing.Color.Silver;
			this.v_5VSupply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.v_5VSupply.ClipMaximum = false;
			this.v_5VSupply.ClipMinimum = false;
			this.v_5VSupply.Device = null;
			this.v_5VSupply.DeviceOn = false;
			this.v_5VSupply.DeviceState = null;
			this.v_5VSupply.DisplayFormat = "0.000";
			this.v_5VSupply.Error = 0;
			this.v_5VSupply.LinkedControl = null;
			this.v_5VSupply.Location = new System.Drawing.Point(85, 6);
			this.v_5VSupply.Maximum = 7.5D;
			this.v_5VSupply.Minimum = 0D;
			this.v_5VSupply.Name = "v_5VSupply";
			this.v_5VSupply.OverRange = false;
			this.v_5VSupply.Prefix = null;
			this.v_5VSupply.SignificantDigits = 3;
			this.v_5VSupply.Size = new System.Drawing.Size(42, 20);
			this.v_5VSupply.Suffix = null;
			this.v_5VSupply.TabIndex = 151;
			this.v_5VSupply.Tag = "";
			this.v_5VSupply.Text = "5.000";
			this.v_5VSupply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.v_5VSupply.UnderRange = false;
			this.v_5VSupply.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.v_5VSupply.DeviceError += new System.EventHandler(this.RequestService);
			this.v_5VSupply.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.v_5VSupply.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_TC1mux0
			// 
			this.t_TC1mux0.AccessibleDescription = "TC1 mux0 temperature";
			this.t_TC1mux0.BackColor = System.Drawing.Color.Silver;
			this.t_TC1mux0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_TC1mux0.ClipMaximum = false;
			this.t_TC1mux0.ClipMinimum = false;
			this.t_TC1mux0.Device = null;
			this.t_TC1mux0.DeviceOn = false;
			this.t_TC1mux0.DeviceState = null;
			this.t_TC1mux0.DisplayFormat = "0.0";
			this.t_TC1mux0.Error = 0;
			this.t_TC1mux0.LinkedControl = null;
			this.t_TC1mux0.Location = new System.Drawing.Point(85, 66);
			this.t_TC1mux0.Maximum = 125D;
			this.t_TC1mux0.Minimum = 0D;
			this.t_TC1mux0.Name = "t_TC1mux0";
			this.t_TC1mux0.OverRange = false;
			this.t_TC1mux0.Prefix = null;
			this.t_TC1mux0.SignificantDigits = 3;
			this.t_TC1mux0.Size = new System.Drawing.Size(42, 20);
			this.t_TC1mux0.Suffix = null;
			this.t_TC1mux0.TabIndex = 157;
			this.t_TC1mux0.Tag = "";
			this.t_TC1mux0.Text = "25.0";
			this.t_TC1mux0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_TC1mux0.UnderRange = false;
			this.t_TC1mux0.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_TC1mux0.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_TC1mux0.DeviceError += new System.EventHandler(this.RequestService);
			this.t_TC1mux0.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_TC1mux0.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// t_TC0mux0
			// 
			this.t_TC0mux0.AccessibleDescription = "TC0 mux0 temperature";
			this.t_TC0mux0.BackColor = System.Drawing.Color.Silver;
			this.t_TC0mux0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.t_TC0mux0.ClipMaximum = false;
			this.t_TC0mux0.ClipMinimum = false;
			this.t_TC0mux0.Device = null;
			this.t_TC0mux0.DeviceOn = false;
			this.t_TC0mux0.DeviceState = null;
			this.t_TC0mux0.DisplayFormat = "0.0";
			this.t_TC0mux0.Error = 0;
			this.t_TC0mux0.LinkedControl = null;
			this.t_TC0mux0.Location = new System.Drawing.Point(85, 46);
			this.t_TC0mux0.Maximum = 125D;
			this.t_TC0mux0.Minimum = 0D;
			this.t_TC0mux0.Name = "t_TC0mux0";
			this.t_TC0mux0.OverRange = false;
			this.t_TC0mux0.Prefix = null;
			this.t_TC0mux0.SignificantDigits = 3;
			this.t_TC0mux0.Size = new System.Drawing.Size(42, 20);
			this.t_TC0mux0.Suffix = null;
			this.t_TC0mux0.TabIndex = 156;
			this.t_TC0mux0.Tag = "";
			this.t_TC0mux0.Text = "25.0";
			this.t_TC0mux0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.t_TC0mux0.UnderRange = false;
			this.t_TC0mux0.Decorate += new System.EventHandler(this.temperatureChanged);
			this.t_TC0mux0.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.t_TC0mux0.DeviceError += new System.EventHandler(this.RequestService);
			this.t_TC0mux0.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.t_TC0mux0.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// p_Bakeout
			// 
			this.p_Bakeout.AccessibleDescription = "Bakeout line pressure";
			this.p_Bakeout.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.GaugePressureColor;
			this.p_Bakeout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_Bakeout.ClipMaximum = false;
			this.p_Bakeout.ClipMinimum = false;
			this.p_Bakeout.ContextMenuStrip = this.meterDisplayMenu;
			this.p_Bakeout.Device = null;
			this.p_Bakeout.DeviceOn = false;
			this.p_Bakeout.DeviceState = null;
			this.p_Bakeout.DisplayFormat = "0.0";
			this.p_Bakeout.Error = 0;
			this.p_Bakeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p_Bakeout.LinkedControl = null;
			this.p_Bakeout.Location = new System.Drawing.Point(457, 23);
			this.p_Bakeout.Maximum = 1690D;
			this.p_Bakeout.Minimum = 0D;
			this.p_Bakeout.Name = "p_Bakeout";
			this.p_Bakeout.OverRange = false;
			this.p_Bakeout.Prefix = null;
			this.p_Bakeout.SignificantDigits = 3;
			this.p_Bakeout.Size = new System.Drawing.Size(111, 31);
			this.p_Bakeout.Suffix = null;
			this.p_Bakeout.TabIndex = 154;
			this.p_Bakeout.Tag = "";
			this.p_Bakeout.Text = "700.0";
			this.p_Bakeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.p_Bakeout.UnderRange = false;
			this.p_Bakeout.Decorate += new System.EventHandler(this.pressureChanged);
			this.p_Bakeout.DisplayValueChanged += new System.EventHandler(this.RequestService);
			this.p_Bakeout.DeviceError += new System.EventHandler(this.RequestService);
			this.p_Bakeout.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.p_Bakeout.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// tabSettings
			// 
			this.tabSettings.AutoScroll = true;
			this.tabSettings.BackColor = System.Drawing.Color.Silver;
			this.tabSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabSettings.Controls.Add(this.DevicePopupsCheckBox);
			this.tabSettings.Controls.Add(this.EnableAutozeroCheckBox);
			this.tabSettings.Controls.Add(this.EnableWatchdogsCheckBox);
			this.tabSettings.Controls.Add(this.label35);
			this.tabSettings.Controls.Add(this.AlertRecipientsTextBox);
			this.tabSettings.Controls.Add(this.WarningColorLabel);
			this.tabSettings.Controls.Add(this.ClipPressureCheckBox);
			this.tabSettings.Controls.Add(this.ClipTemperatureCheckBox);
			this.tabSettings.Controls.Add(this.ApplicationBackColorLabel);
			this.tabSettings.Controls.Add(this.OpenedColorLabel);
			this.tabSettings.Controls.Add(this.UnknownColorLabel);
			this.tabSettings.Controls.Add(this.NeutralColorLabel);
			this.tabSettings.Controls.Add(this.ClosedColorLabel);
			this.tabSettings.Controls.Add(this.ErrorColorLabel);
			this.tabSettings.Controls.Add(this.GaugePressureColorLabel);
			this.tabSettings.Controls.Add(this.ClosingColorLabel);
			this.tabSettings.Controls.Add(this.VacuumColorLabel);
			this.tabSettings.Controls.Add(this.OpeningColorLabel);
			this.tabSettings.Controls.Add(this.HighVacuumColorLabel);
			this.tabSettings.Controls.Add(this.CoolColorLabel);
			this.tabSettings.Controls.Add(this.ColdColorLabel);
			this.tabSettings.Controls.Add(this.WarmColorLabel);
			this.tabSettings.Controls.Add(this.HotColorLabel);
			this.tabSettings.Controls.Add(this.OffColorLabel);
			this.tabSettings.Controls.Add(this.OnColorLabel);
			this.tabSettings.Controls.Add(this.WarningColor);
			this.tabSettings.Controls.Add(this.ApplicationBackColor);
			this.tabSettings.Controls.Add(this.OpenedColor);
			this.tabSettings.Controls.Add(this.UnknownColor);
			this.tabSettings.Controls.Add(this.GaugePressureColor);
			this.tabSettings.Controls.Add(this.NeutralColor);
			this.tabSettings.Controls.Add(this.ClosingColor);
			this.tabSettings.Controls.Add(this.ClosedColor);
			this.tabSettings.Controls.Add(this.OpeningColor);
			this.tabSettings.Controls.Add(this.ErrorColor);
			this.tabSettings.Controls.Add(this.VacuumColor);
			this.tabSettings.Controls.Add(this.HighVacuumColor);
			this.tabSettings.Controls.Add(this.CoolColor);
			this.tabSettings.Controls.Add(this.ColdColor);
			this.tabSettings.Controls.Add(this.WarmColor);
			this.tabSettings.Controls.Add(this.HotColor);
			this.tabSettings.Controls.Add(this.OffColor);
			this.tabSettings.Controls.Add(this.OnColor);
			this.tabSettings.Location = new System.Drawing.Point(4, 22);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabSettings.Size = new System.Drawing.Size(952, 607);
			this.tabSettings.TabIndex = 1;
			this.tabSettings.Text = "Settings";
			this.tabSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseClick);
			this.tabSettings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseDoubleClick);
			// 
			// DevicePopupsCheckBox
			// 
			this.DevicePopupsCheckBox.AccessibleDescription = "Show device state popup on mouse hover";
			this.DevicePopupsCheckBox.AutoSize = true;
			this.DevicePopupsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DevicePopupsCheckBox.Checked = true;
			this.DevicePopupsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DevicePopupsCheckBox.Location = new System.Drawing.Point(180, 101);
			this.DevicePopupsCheckBox.Name = "DevicePopupsCheckBox";
			this.DevicePopupsCheckBox.Size = new System.Drawing.Size(98, 17);
			this.DevicePopupsCheckBox.TabIndex = 7;
			this.DevicePopupsCheckBox.Text = "Device popups";
			this.DevicePopupsCheckBox.UseVisualStyleBackColor = true;
			this.DevicePopupsCheckBox.CheckedChanged += new System.EventHandler(this.EnableAutozeroCheckBox_CheckedChanged);
			this.DevicePopupsCheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.DevicePopupsCheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// EnableAutozeroCheckBox
			// 
			this.EnableAutozeroCheckBox.AccessibleDescription = "Automatically zero evacuated pressure gauges";
			this.EnableAutozeroCheckBox.AutoSize = true;
			this.EnableAutozeroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.EnableAutozeroCheckBox.Checked = true;
			this.EnableAutozeroCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableAutozeroCheckBox.Location = new System.Drawing.Point(174, 83);
			this.EnableAutozeroCheckBox.Name = "EnableAutozeroCheckBox";
			this.EnableAutozeroCheckBox.Size = new System.Drawing.Size(104, 17);
			this.EnableAutozeroCheckBox.TabIndex = 6;
			this.EnableAutozeroCheckBox.Text = "Enable Autozero";
			this.EnableAutozeroCheckBox.UseVisualStyleBackColor = true;
			this.EnableAutozeroCheckBox.CheckedChanged += new System.EventHandler(this.EnableAutozeroCheckBox_CheckedChanged);
			this.EnableAutozeroCheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.EnableAutozeroCheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// EnableWatchdogsCheckBox
			// 
			this.EnableWatchdogsCheckBox.AccessibleDescription = "Monitor & protect against dangerous system configurations";
			this.EnableWatchdogsCheckBox.AutoSize = true;
			this.EnableWatchdogsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.EnableWatchdogsCheckBox.Checked = true;
			this.EnableWatchdogsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableWatchdogsCheckBox.Location = new System.Drawing.Point(161, 65);
			this.EnableWatchdogsCheckBox.Name = "EnableWatchdogsCheckBox";
			this.EnableWatchdogsCheckBox.Size = new System.Drawing.Size(117, 17);
			this.EnableWatchdogsCheckBox.TabIndex = 5;
			this.EnableWatchdogsCheckBox.Text = "Enable Watchdogs";
			this.EnableWatchdogsCheckBox.UseVisualStyleBackColor = true;
			this.EnableWatchdogsCheckBox.CheckedChanged += new System.EventHandler(this.EnableWatchdogsCheckBox_CheckedChanged);
			this.EnableWatchdogsCheckBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.EnableWatchdogsCheckBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label35
			// 
			this.label35.AccessibleDescription = "Compressed air heater state";
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Location = new System.Drawing.Point(189, 15);
			this.label35.Margin = new System.Windows.Forms.Padding(0);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(76, 13);
			this.label35.TabIndex = 513;
			this.label35.Text = "Alert recipients";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AlertRecipientsTextBox
			// 
			this.AlertRecipientsTextBox.AccessibleDescription = "List of alert recipients";
			this.AlertRecipientsTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.AlertRecipientsTextBox.Location = new System.Drawing.Point(265, 12);
			this.AlertRecipientsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.AlertRecipientsTextBox.Multiline = true;
			this.AlertRecipientsTextBox.Name = "AlertRecipientsTextBox";
			this.AlertRecipientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.AlertRecipientsTextBox.Size = new System.Drawing.Size(217, 52);
			this.AlertRecipientsTextBox.TabIndex = 4;
			this.AlertRecipientsTextBox.Tag = "";
			this.AlertRecipientsTextBox.WordWrap = false;
			this.AlertRecipientsTextBox.Leave += new System.EventHandler(this.LeaveAlertRecipientsTextBox);
			this.AlertRecipientsTextBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.AlertRecipientsTextBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(164, 30);
			this.label34.Margin = new System.Windows.Forms.Padding(0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(67, 13);
			this.label34.TabIndex = 511;
			this.label34.Text = "Previous GR";
			// 
			// LastGRTextBox
			// 
			this.LastGRTextBox.AccessibleDescription = "Enter the last GR used";
			this.LastGRTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.LastGRTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LastGRTextBox.Location = new System.Drawing.Point(231, 28);
			this.LastGRTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.LastGRTextBox.Name = "LastGRTextBox";
			this.LastGRTextBox.Size = new System.Drawing.Size(45, 20);
			this.LastGRTextBox.TabIndex = 1;
			this.LastGRTextBox.Tag = "";
			this.LastGRTextBox.Text = "6";
			this.LastGRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.LastGRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.LastGRTextBox.Leave += new System.EventHandler(this.LeaveLastGRTextBox);
			this.LastGRTextBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.LastGRTextBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// WarningColorLabel
			// 
			this.WarningColorLabel.AccessibleDescription = "Color for warning condition";
			this.WarningColorLabel.AutoSize = true;
			this.WarningColorLabel.Location = new System.Drawing.Point(32, 87);
			this.WarningColorLabel.Name = "WarningColorLabel";
			this.WarningColorLabel.Size = new System.Drawing.Size(47, 13);
			this.WarningColorLabel.TabIndex = 509;
			this.WarningColorLabel.Text = "Warning";
			this.WarningColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(144, 10);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 13);
			this.label9.TabIndex = 505;
			this.label9.Text = "Graphite Number";
			// 
			// ApplicationBackColorLabel
			// 
			this.ApplicationBackColorLabel.AccessibleDescription = "Background color for application";
			this.ApplicationBackColorLabel.AutoSize = true;
			this.ApplicationBackColorLabel.Location = new System.Drawing.Point(32, 320);
			this.ApplicationBackColorLabel.Name = "ApplicationBackColorLabel";
			this.ApplicationBackColorLabel.Size = new System.Drawing.Size(120, 13);
			this.ApplicationBackColorLabel.TabIndex = 140;
			this.ApplicationBackColorLabel.Text = "Application Background";
			this.ApplicationBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OpenedColorLabel
			// 
			this.OpenedColorLabel.AccessibleDescription = "Color for opened valve";
			this.OpenedColorLabel.AutoSize = true;
			this.OpenedColorLabel.Location = new System.Drawing.Point(32, 105);
			this.OpenedColorLabel.Name = "OpenedColorLabel";
			this.OpenedColorLabel.Size = new System.Drawing.Size(45, 13);
			this.OpenedColorLabel.TabIndex = 104;
			this.OpenedColorLabel.Text = "Opened";
			this.OpenedColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OpenedColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// UnknownColorLabel
			// 
			this.UnknownColorLabel.AccessibleDescription = "Color for unknown state";
			this.UnknownColorLabel.AutoSize = true;
			this.UnknownColorLabel.Location = new System.Drawing.Point(32, 51);
			this.UnknownColorLabel.Name = "UnknownColorLabel";
			this.UnknownColorLabel.Size = new System.Drawing.Size(53, 13);
			this.UnknownColorLabel.TabIndex = 112;
			this.UnknownColorLabel.Text = "Unknown";
			this.UnknownColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.UnknownColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// NeutralColorLabel
			// 
			this.NeutralColorLabel.AccessibleDescription = "Color for device with unremarkable condition.";
			this.NeutralColorLabel.AutoSize = true;
			this.NeutralColorLabel.Location = new System.Drawing.Point(32, 176);
			this.NeutralColorLabel.Name = "NeutralColorLabel";
			this.NeutralColorLabel.Size = new System.Drawing.Size(41, 13);
			this.NeutralColorLabel.TabIndex = 137;
			this.NeutralColorLabel.Text = "Neutral";
			this.NeutralColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NeutralColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ClosedColorLabel
			// 
			this.ClosedColorLabel.AccessibleDescription = "Color for closed valve";
			this.ClosedColorLabel.AutoSize = true;
			this.ClosedColorLabel.Location = new System.Drawing.Point(32, 140);
			this.ClosedColorLabel.Name = "ClosedColorLabel";
			this.ClosedColorLabel.Size = new System.Drawing.Size(39, 13);
			this.ClosedColorLabel.TabIndex = 106;
			this.ClosedColorLabel.Text = "Closed";
			this.ClosedColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClosedColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ErrorColorLabel
			// 
			this.ErrorColorLabel.AccessibleDescription = "Color for error condition";
			this.ErrorColorLabel.AutoSize = true;
			this.ErrorColorLabel.Location = new System.Drawing.Point(32, 69);
			this.ErrorColorLabel.Name = "ErrorColorLabel";
			this.ErrorColorLabel.Size = new System.Drawing.Size(29, 13);
			this.ErrorColorLabel.TabIndex = 135;
			this.ErrorColorLabel.Text = "Error";
			this.ErrorColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ErrorColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GaugePressureColorLabel
			// 
			this.GaugePressureColorLabel.AccessibleDescription = "Color for pressure > ambient atmospheric pressure";
			this.GaugePressureColorLabel.AutoSize = true;
			this.GaugePressureColorLabel.Location = new System.Drawing.Point(32, 302);
			this.GaugePressureColorLabel.Name = "GaugePressureColorLabel";
			this.GaugePressureColorLabel.Size = new System.Drawing.Size(83, 13);
			this.GaugePressureColorLabel.TabIndex = 133;
			this.GaugePressureColorLabel.Text = "Gauge Pressure";
			this.GaugePressureColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.GaugePressureColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ClosingColorLabel
			// 
			this.ClosingColorLabel.AccessibleDescription = "Color for closing valve";
			this.ClosingColorLabel.AutoSize = true;
			this.ClosingColorLabel.Location = new System.Drawing.Point(32, 158);
			this.ClosingColorLabel.Name = "ClosingColorLabel";
			this.ClosingColorLabel.Size = new System.Drawing.Size(41, 13);
			this.ClosingColorLabel.TabIndex = 110;
			this.ClosingColorLabel.Text = "Closing";
			this.ClosingColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClosingColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VacuumColorLabel
			// 
			this.VacuumColorLabel.AccessibleDescription = "Color for pressure between 0.3 Torr and ambient atmospheric pressure";
			this.VacuumColorLabel.AutoSize = true;
			this.VacuumColorLabel.Location = new System.Drawing.Point(33, 284);
			this.VacuumColorLabel.Name = "VacuumColorLabel";
			this.VacuumColorLabel.Size = new System.Drawing.Size(46, 13);
			this.VacuumColorLabel.TabIndex = 131;
			this.VacuumColorLabel.Text = "Vacuum";
			this.VacuumColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.VacuumColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OpeningColorLabel
			// 
			this.OpeningColorLabel.AccessibleDescription = "Color for opening valve";
			this.OpeningColorLabel.AutoSize = true;
			this.OpeningColorLabel.Location = new System.Drawing.Point(32, 122);
			this.OpeningColorLabel.Name = "OpeningColorLabel";
			this.OpeningColorLabel.Size = new System.Drawing.Size(47, 13);
			this.OpeningColorLabel.TabIndex = 108;
			this.OpeningColorLabel.Text = "Opening";
			this.OpeningColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OpeningColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// HighVacuumColorLabel
			// 
			this.HighVacuumColorLabel.AccessibleDescription = "Color for pressure < 0.2 Torr";
			this.HighVacuumColorLabel.AutoSize = true;
			this.HighVacuumColorLabel.Location = new System.Drawing.Point(32, 266);
			this.HighVacuumColorLabel.Name = "HighVacuumColorLabel";
			this.HighVacuumColorLabel.Size = new System.Drawing.Size(71, 13);
			this.HighVacuumColorLabel.TabIndex = 127;
			this.HighVacuumColorLabel.Text = "High Vacuum";
			this.HighVacuumColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HighVacuumColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// CoolColorLabel
			// 
			this.CoolColorLabel.AccessibleDescription = "Color for cool temperature";
			this.CoolColorLabel.AutoSize = true;
			this.CoolColorLabel.Location = new System.Drawing.Point(32, 248);
			this.CoolColorLabel.Name = "CoolColorLabel";
			this.CoolColorLabel.Size = new System.Drawing.Size(28, 13);
			this.CoolColorLabel.TabIndex = 125;
			this.CoolColorLabel.Text = "Cool";
			this.CoolColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CoolColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ColdColorLabel
			// 
			this.ColdColorLabel.AccessibleDescription = "Color for cryogenic temperature";
			this.ColdColorLabel.AutoSize = true;
			this.ColdColorLabel.Location = new System.Drawing.Point(33, 230);
			this.ColdColorLabel.Name = "ColdColorLabel";
			this.ColdColorLabel.Size = new System.Drawing.Size(28, 13);
			this.ColdColorLabel.TabIndex = 123;
			this.ColdColorLabel.Text = "Cold";
			this.ColdColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ColdColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// WarmColorLabel
			// 
			this.WarmColorLabel.AccessibleDescription = "Color for warm device";
			this.WarmColorLabel.AutoSize = true;
			this.WarmColorLabel.Location = new System.Drawing.Point(32, 212);
			this.WarmColorLabel.Name = "WarmColorLabel";
			this.WarmColorLabel.Size = new System.Drawing.Size(35, 13);
			this.WarmColorLabel.TabIndex = 121;
			this.WarmColorLabel.Text = "Warm";
			this.WarmColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WarmColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// HotColorLabel
			// 
			this.HotColorLabel.AccessibleDescription = "Color for high temperature";
			this.HotColorLabel.AutoSize = true;
			this.HotColorLabel.Location = new System.Drawing.Point(32, 194);
			this.HotColorLabel.Name = "HotColorLabel";
			this.HotColorLabel.Size = new System.Drawing.Size(24, 13);
			this.HotColorLabel.TabIndex = 119;
			this.HotColorLabel.Text = "Hot";
			this.HotColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HotColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OffColorLabel
			// 
			this.OffColorLabel.AccessibleDescription = "Color for device which is powered Off";
			this.OffColorLabel.AutoSize = true;
			this.OffColorLabel.Location = new System.Drawing.Point(32, 33);
			this.OffColorLabel.Name = "OffColorLabel";
			this.OffColorLabel.Size = new System.Drawing.Size(21, 13);
			this.OffColorLabel.TabIndex = 117;
			this.OffColorLabel.Text = "Off";
			this.OffColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OffColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OnColorLabel
			// 
			this.OnColorLabel.AccessibleDescription = "Color for device which is powered On";
			this.OnColorLabel.AutoSize = true;
			this.OnColorLabel.Location = new System.Drawing.Point(32, 15);
			this.OnColorLabel.Name = "OnColorLabel";
			this.OnColorLabel.Size = new System.Drawing.Size(21, 13);
			this.OnColorLabel.TabIndex = 115;
			this.OnColorLabel.Text = "On";
			this.OnColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OnColorLabel.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// WarningColor
			// 
			this.WarningColor.AccessibleDescription = "Color for warning condition";
			this.WarningColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.WarningColor;
			this.WarningColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WarningColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "WarningColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.WarningColor.Location = new System.Drawing.Point(8, 84);
			this.WarningColor.Name = "WarningColor";
			this.WarningColor.Size = new System.Drawing.Size(18, 18);
			this.WarningColor.TabIndex = 510;
			this.WarningColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WarningColor.Click += new System.EventHandler(this.color_Click);
			this.WarningColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.WarningColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ApplicationBackColor
			// 
			this.ApplicationBackColor.AccessibleDescription = "Background color for application";
			this.ApplicationBackColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.AppBackColor;
			this.ApplicationBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ApplicationBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "AppBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ApplicationBackColor.Location = new System.Drawing.Point(8, 317);
			this.ApplicationBackColor.Name = "ApplicationBackColor";
			this.ApplicationBackColor.Size = new System.Drawing.Size(18, 18);
			this.ApplicationBackColor.TabIndex = 141;
			this.ApplicationBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ApplicationBackColor.Click += new System.EventHandler(this.color_Click);
			this.ApplicationBackColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ApplicationBackColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OpenedColor
			// 
			this.OpenedColor.AccessibleDescription = "Color for opened valve";
			this.OpenedColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OpenedColor;
			this.OpenedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OpenedColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "OpenedColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.OpenedColor.Location = new System.Drawing.Point(8, 102);
			this.OpenedColor.Name = "OpenedColor";
			this.OpenedColor.Size = new System.Drawing.Size(18, 18);
			this.OpenedColor.TabIndex = 105;
			this.OpenedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OpenedColor.Click += new System.EventHandler(this.color_Click);
			this.OpenedColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.OpenedColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// UnknownColor
			// 
			this.UnknownColor.AccessibleDescription = "Color for unknown state";
			this.UnknownColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.UnknownColor;
			this.UnknownColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UnknownColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "UnknownColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.UnknownColor.Location = new System.Drawing.Point(8, 48);
			this.UnknownColor.Name = "UnknownColor";
			this.UnknownColor.Size = new System.Drawing.Size(18, 18);
			this.UnknownColor.TabIndex = 113;
			this.UnknownColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.UnknownColor.Click += new System.EventHandler(this.color_Click);
			this.UnknownColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.UnknownColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// GaugePressureColor
			// 
			this.GaugePressureColor.AccessibleDescription = "Color for pressure > ambient atmospheric pressure";
			this.GaugePressureColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.GaugePressureColor;
			this.GaugePressureColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GaugePressureColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "GaugePressureColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.GaugePressureColor.Location = new System.Drawing.Point(8, 299);
			this.GaugePressureColor.Name = "GaugePressureColor";
			this.GaugePressureColor.Size = new System.Drawing.Size(18, 18);
			this.GaugePressureColor.TabIndex = 139;
			this.GaugePressureColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.GaugePressureColor.Click += new System.EventHandler(this.color_Click);
			this.GaugePressureColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GaugePressureColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// NeutralColor
			// 
			this.NeutralColor.AccessibleDescription = "Color for device with unremarkable condition.";
			this.NeutralColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.NeutralColor;
			this.NeutralColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NeutralColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "NeutralColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.NeutralColor.Location = new System.Drawing.Point(8, 173);
			this.NeutralColor.Name = "NeutralColor";
			this.NeutralColor.Size = new System.Drawing.Size(18, 18);
			this.NeutralColor.TabIndex = 138;
			this.NeutralColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NeutralColor.Click += new System.EventHandler(this.color_Click);
			this.NeutralColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.NeutralColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ClosingColor
			// 
			this.ClosingColor.AccessibleDescription = "Color for closing valve";
			this.ClosingColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.ClosingColor;
			this.ClosingColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ClosingColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "ClosingColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ClosingColor.Location = new System.Drawing.Point(8, 155);
			this.ClosingColor.Name = "ClosingColor";
			this.ClosingColor.Size = new System.Drawing.Size(18, 18);
			this.ClosingColor.TabIndex = 111;
			this.ClosingColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClosingColor.Click += new System.EventHandler(this.color_Click);
			this.ClosingColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ClosingColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ClosedColor
			// 
			this.ClosedColor.AccessibleDescription = "Color for closed valve";
			this.ClosedColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.ClosedColor;
			this.ClosedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ClosedColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "ClosedColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ClosedColor.Location = new System.Drawing.Point(8, 137);
			this.ClosedColor.Name = "ClosedColor";
			this.ClosedColor.Size = new System.Drawing.Size(18, 18);
			this.ClosedColor.TabIndex = 107;
			this.ClosedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClosedColor.Click += new System.EventHandler(this.color_Click);
			this.ClosedColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ClosedColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OpeningColor
			// 
			this.OpeningColor.AccessibleDescription = "Color for opening valve";
			this.OpeningColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OpeningColor;
			this.OpeningColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OpeningColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "OpeningColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.OpeningColor.Location = new System.Drawing.Point(8, 119);
			this.OpeningColor.Name = "OpeningColor";
			this.OpeningColor.Size = new System.Drawing.Size(18, 18);
			this.OpeningColor.TabIndex = 109;
			this.OpeningColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OpeningColor.Click += new System.EventHandler(this.color_Click);
			this.OpeningColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.OpeningColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ErrorColor
			// 
			this.ErrorColor.AccessibleDescription = "Color for error condition";
			this.ErrorColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.ErrorColor;
			this.ErrorColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ErrorColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "ErrorColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ErrorColor.Location = new System.Drawing.Point(8, 66);
			this.ErrorColor.Name = "ErrorColor";
			this.ErrorColor.Size = new System.Drawing.Size(18, 18);
			this.ErrorColor.TabIndex = 136;
			this.ErrorColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ErrorColor.Click += new System.EventHandler(this.color_Click);
			this.ErrorColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ErrorColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// VacuumColor
			// 
			this.VacuumColor.AccessibleDescription = "Color for pressure between 0.3 Torr and ambient atmospheric pressure";
			this.VacuumColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.VacuumColor;
			this.VacuumColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VacuumColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "VacuumColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.VacuumColor.Location = new System.Drawing.Point(8, 281);
			this.VacuumColor.Name = "VacuumColor";
			this.VacuumColor.Size = new System.Drawing.Size(18, 18);
			this.VacuumColor.TabIndex = 132;
			this.VacuumColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.VacuumColor.Click += new System.EventHandler(this.color_Click);
			this.VacuumColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.VacuumColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// HighVacuumColor
			// 
			this.HighVacuumColor.AccessibleDescription = "Color for pressure < 0.3 Torr";
			this.HighVacuumColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.HighVacuumColor;
			this.HighVacuumColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HighVacuumColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "HighVacuumColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.HighVacuumColor.Location = new System.Drawing.Point(8, 263);
			this.HighVacuumColor.Name = "HighVacuumColor";
			this.HighVacuumColor.Size = new System.Drawing.Size(18, 18);
			this.HighVacuumColor.TabIndex = 128;
			this.HighVacuumColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HighVacuumColor.Click += new System.EventHandler(this.color_Click);
			this.HighVacuumColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.HighVacuumColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// CoolColor
			// 
			this.CoolColor.AccessibleDescription = "Color for cool temperature";
			this.CoolColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.CoolColor;
			this.CoolColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CoolColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "CoolColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.CoolColor.Location = new System.Drawing.Point(8, 245);
			this.CoolColor.Name = "CoolColor";
			this.CoolColor.Size = new System.Drawing.Size(18, 18);
			this.CoolColor.TabIndex = 126;
			this.CoolColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CoolColor.Click += new System.EventHandler(this.color_Click);
			this.CoolColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.CoolColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// ColdColor
			// 
			this.ColdColor.AccessibleDescription = "Color for cryogenic temperature";
			this.ColdColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.ColdColor;
			this.ColdColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ColdColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "ColdColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ColdColor.Location = new System.Drawing.Point(8, 227);
			this.ColdColor.Name = "ColdColor";
			this.ColdColor.Size = new System.Drawing.Size(18, 18);
			this.ColdColor.TabIndex = 124;
			this.ColdColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ColdColor.Click += new System.EventHandler(this.color_Click);
			this.ColdColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.ColdColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// WarmColor
			// 
			this.WarmColor.AccessibleDescription = "Color for warm device";
			this.WarmColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.WarmColor;
			this.WarmColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WarmColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "WarmColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.WarmColor.Location = new System.Drawing.Point(8, 209);
			this.WarmColor.Name = "WarmColor";
			this.WarmColor.Size = new System.Drawing.Size(18, 18);
			this.WarmColor.TabIndex = 122;
			this.WarmColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WarmColor.Click += new System.EventHandler(this.color_Click);
			this.WarmColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.WarmColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// HotColor
			// 
			this.HotColor.AccessibleDescription = "Color for high temperature";
			this.HotColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.HotColor;
			this.HotColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HotColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "HotColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.HotColor.Location = new System.Drawing.Point(8, 191);
			this.HotColor.Name = "HotColor";
			this.HotColor.Size = new System.Drawing.Size(18, 18);
			this.HotColor.TabIndex = 120;
			this.HotColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HotColor.Click += new System.EventHandler(this.color_Click);
			this.HotColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.HotColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OffColor
			// 
			this.OffColor.AccessibleDescription = "Color for device which is powered Off";
			this.OffColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OffColor;
			this.OffColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OffColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "OffColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.OffColor.Location = new System.Drawing.Point(8, 30);
			this.OffColor.Name = "OffColor";
			this.OffColor.Size = new System.Drawing.Size(18, 18);
			this.OffColor.TabIndex = 118;
			this.OffColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OffColor.Click += new System.EventHandler(this.color_Click);
			this.OffColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.OffColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// OnColor
			// 
			this.OnColor.AccessibleDescription = "Color for device which is powered On";
			this.OnColor.BackColor = global::CEGS_Aeon_Namespace.Properties.Settings.Default.OnColor;
			this.OnColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OnColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::CEGS_Aeon_Namespace.Properties.Settings.Default, "OnColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.OnColor.Location = new System.Drawing.Point(8, 12);
			this.OnColor.Name = "OnColor";
			this.OnColor.Size = new System.Drawing.Size(18, 18);
			this.OnColor.TabIndex = 116;
			this.OnColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OnColor.Click += new System.EventHandler(this.color_Click);
			this.OnColor.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.OnColor.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// tabDeviceSettings
			// 
			this.tabDeviceSettings.AutoScroll = true;
			this.tabDeviceSettings.AutoScrollMargin = new System.Drawing.Size(3, 3);
			this.tabDeviceSettings.BackColor = System.Drawing.Color.Silver;
			this.tabDeviceSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabDeviceSettings.Controls.Add(this.ScrollPanel);
			this.tabDeviceSettings.Controls.Add(this.DevicesPanel);
			this.tabDeviceSettings.Location = new System.Drawing.Point(4, 22);
			this.tabDeviceSettings.Name = "tabDeviceSettings";
			this.tabDeviceSettings.Size = new System.Drawing.Size(952, 607);
			this.tabDeviceSettings.TabIndex = 2;
			this.tabDeviceSettings.Text = "Devices";
			this.tabDeviceSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseClick);
			this.tabDeviceSettings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.blankArea_MouseDoubleClick);
			// 
			// ScrollPanel
			// 
			this.ScrollPanel.AutoScroll = true;
			this.ScrollPanel.Controls.Add(this.SettingsPanel);
			this.ScrollPanel.Controls.Add(this.DeviceLabel);
			this.ScrollPanel.Controls.Add(this.separator1);
			this.ScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ScrollPanel.Location = new System.Drawing.Point(231, 0);
			this.ScrollPanel.Name = "ScrollPanel";
			this.ScrollPanel.Size = new System.Drawing.Size(717, 603);
			this.ScrollPanel.TabIndex = 562;
			// 
			// SettingsPanel
			// 
			this.SettingsPanel.AutoSize = true;
			this.SettingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SettingsPanel.Location = new System.Drawing.Point(8, 42);
			this.SettingsPanel.MinimumSize = new System.Drawing.Size(330, 0);
			this.SettingsPanel.Name = "SettingsPanel";
			this.SettingsPanel.Size = new System.Drawing.Size(330, 0);
			this.SettingsPanel.TabIndex = 555;
			// 
			// DeviceLabel
			// 
			this.DeviceLabel.AutoSize = true;
			this.DeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeviceLabel.Location = new System.Drawing.Point(11, 14);
			this.DeviceLabel.Name = "DeviceLabel";
			this.DeviceLabel.Size = new System.Drawing.Size(0, 20);
			this.DeviceLabel.TabIndex = 558;
			// 
			// separator1
			// 
			this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.separator1.Location = new System.Drawing.Point(7, 36);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(333, 2);
			this.separator1.TabIndex = 556;
			this.separator1.Visible = false;
			// 
			// DevicesPanel
			// 
			this.DevicesPanel.Controls.Add(this.DeviceSearchBox);
			this.DevicesPanel.Controls.Add(this.DeviceNavTree);
			this.DevicesPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.DevicesPanel.Location = new System.Drawing.Point(0, 0);
			this.DevicesPanel.Margin = new System.Windows.Forms.Padding(0);
			this.DevicesPanel.Name = "DevicesPanel";
			this.DevicesPanel.Size = new System.Drawing.Size(231, 603);
			this.DevicesPanel.TabIndex = 561;
			// 
			// DeviceSearchBox
			// 
			this.DeviceSearchBox.Location = new System.Drawing.Point(12, 17);
			this.DeviceSearchBox.Name = "DeviceSearchBox";
			this.DeviceSearchBox.Size = new System.Drawing.Size(212, 20);
			this.DeviceSearchBox.TabIndex = 560;
			this.DeviceSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DeviceSearchBox_KeyUp);
			// 
			// DeviceNavTree
			// 
			this.DeviceNavTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.DeviceNavTree.Location = new System.Drawing.Point(12, 43);
			this.DeviceNavTree.Name = "DeviceNavTree";
			this.DeviceNavTree.Size = new System.Drawing.Size(212, 549);
			this.DeviceNavTree.TabIndex = 559;
			this.DeviceNavTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DeviceNavTree_AfterSelect);
			// 
			// UpdateTimer
			// 
			this.UpdateTimer.Interval = 50;
			this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
			// 
			// DeviceStatePopupLabel
			// 
			this.DeviceStatePopupLabel.AutoSize = true;
			this.DeviceStatePopupLabel.BackColor = System.Drawing.Color.Beige;
			this.DeviceStatePopupLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DeviceStatePopupLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeviceStatePopupLabel.Location = new System.Drawing.Point(6, 598);
			this.DeviceStatePopupLabel.Name = "DeviceStatePopupLabel";
			this.DeviceStatePopupLabel.Size = new System.Drawing.Size(105, 15);
			this.DeviceStatePopupLabel.TabIndex = 338;
			this.DeviceStatePopupLabel.Text = "DeviceStateLabel";
			this.DeviceStatePopupLabel.Visible = false;
			// 
			// GraphiteNumberTextBox
			// 
			this.GraphiteNumberTextBox.AccessibleDescription = "Enter the next Graphite Number to use";
			this.GraphiteNumberTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.GraphiteNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GraphiteNumberTextBox.Location = new System.Drawing.Point(231, 7);
			this.GraphiteNumberTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.GraphiteNumberTextBox.Name = "GraphiteNumberTextBox";
			this.GraphiteNumberTextBox.Size = new System.Drawing.Size(45, 20);
			this.GraphiteNumberTextBox.TabIndex = 0;
			this.GraphiteNumberTextBox.Tag = "";
			this.GraphiteNumberTextBox.Text = "1090";
			this.GraphiteNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.GraphiteNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.GraphiteNumberTextBox.Leave += new System.EventHandler(this.LeaveGraphiteNumberTextBox);
			this.GraphiteNumberTextBox.MouseLeave += new System.EventHandler(this.control_MouseLeave);
			this.GraphiteNumberTextBox.MouseHover += new System.EventHandler(this.control_MouseHover);
			// 
			// UserInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(960, 655);
			this.Controls.Add(this.DeviceStatePopupLabel);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.DoubleBuffered = true;
			this.Name = "UserInterface";
			this.Text = "Aeon CEGS";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInterface_FormClosing);
			this.Load += new System.EventHandler(this.UserInterface_Load);
			this.Shown += new System.EventHandler(this.UserInterface_Shown);
			((System.ComponentModel.ISupportInitialize)(this.DiagramPictureBox)).EndInit();
			this.valveMenu.ResumeLayout(false);
			this.GRMenu.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.d_fan_IP)).EndInit();
			this.OnOffMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vi_new_flow)).EndInit();
			this.meterDisplayMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VMPressurePictureBox)).EndInit();
			this.VM_Gauges_Panel.ResumeLayout(false);
			this.AutoManualMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.d_CC_S2)).EndInit();
			this.heaterMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vi_VTTR_VM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MCUPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_MC_MCL)).EndInit();
			this.ftcMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MCLPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTTL_VTTR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_CuAg_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CuAgPictureBox)).EndInit();
			this.VttPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VttPictureBox)).EndInit();
			this.vttMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VttLPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VttRPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_CO2_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_H2_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GM_VM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_split_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_BP_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_d13C_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_d13C_CF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GMPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d13CPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_split_VM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_MC_split)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_CuAg_MC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTTR_CuAg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitPictureBox)).EndInit();
			this.SampleGroupBox.ResumeLayout(false);
			this.SampleGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MCPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VMPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_IP_IM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_CC_Q)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IPPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_IM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_IM_VTTL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_IM_VM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_O2_IM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IMPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR1_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GR1PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR1_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR6_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GR6PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR5_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GR5PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR4_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GR4PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR3_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GR3PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_GR2_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GR2PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR6_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR5_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR4_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR3_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_GR2_F)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VP_d13C)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d13CCFPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VPVPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_MC_MCU)).EndInit();
			this.d_LN_Tank.ResumeLayout(false);
			this.d_LN_Tank.PerformLayout();
			this.tankMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_CuAg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_MC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_VTT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_d13C)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_VP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LN_GR5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_FTC_air)).EndInit();
			this.LinePortStateMenu.ResumeLayout(false);
			this.GR2_panel.ResumeLayout(false);
			this.GR2_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_VTTL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_B)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_LV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_HV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_CO2_GM_flow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_H2_GM_flow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_GM_flow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_He_GM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vi_VTT_flow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_Pump_HV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.d_RoughingPump)).EndInit();
			this.GR6_panel.ResumeLayout(false);
			this.GR6_panel.PerformLayout();
			this.GR5_panel.ResumeLayout(false);
			this.GR5_panel.PerformLayout();
			this.GR4_panel.ResumeLayout(false);
			this.GR4_panel.PerformLayout();
			this.GR3_panel.ResumeLayout(false);
			this.GR3_panel.PerformLayout();
			this.GR1_panel.ResumeLayout(false);
			this.GR1_panel.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabControlPanel.ResumeLayout(false);
			this.tabBackPanel.ResumeLayout(false);
			this.tabBackPanel.PerformLayout();
			this.tabSettings.ResumeLayout(false);
			this.tabSettings.PerformLayout();
			this.tabDeviceSettings.ResumeLayout(false);
			this.ScrollPanel.ResumeLayout(false);
			this.ScrollPanel.PerformLayout();
			this.DevicesPanel.ResumeLayout(false);
			this.DevicesPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox DiagramPictureBox;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
		public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ContextMenuStrip valveMenu;
        public System.Windows.Forms.ToolStripMenuItem valveStopMenuItem;
        public HACS.Components.Controls.ValveIndicator vi_O2_IM;
        public HACS.Components.Controls.Gauge p_MC;
        public HACS.Components.Controls.Gauge p_GR1;
        public HACS.Components.Controls.Gauge p_Foreline;
        public HACS.Components.Controls.Gauge p_GM;
        public HACS.Components.Controls.Gauge p_VTT;
        public HACS.Components.Controls.Gauge p_VM_IG;
        public HACS.Components.Controls.Gauge p_IM;
        public HACS.Components.Controls.Gauge t_CC_S;
        public HACS.Components.Controls.Gauge p_VM_HP;
        public HACS.Components.Controls.Gauge t_MC_CF;
        public HACS.Components.Controls.Gauge t_GR1_F;
		public HACS.Components.Controls.Gauge t_GR1_CF;
        public HACS.Components.Controls.Gauge t_GR2_CF;
        public HACS.Components.Controls.Gauge t_GR2_F;
        public HACS.Components.Controls.Gauge p_GR2;
        public HACS.Components.Controls.Gauge t_GR3_CF;
        public HACS.Components.Controls.Gauge t_GR3_F;
        public HACS.Components.Controls.Gauge p_GR3;
        public HACS.Components.Controls.Gauge t_GR4_CF;
        public HACS.Components.Controls.Gauge t_GR4_F;
        public HACS.Components.Controls.Gauge p_GR4;
        public HACS.Components.Controls.Gauge t_GR5_CF;
        public HACS.Components.Controls.Gauge t_GR5_F;
        public HACS.Components.Controls.Gauge p_GR5;
        public HACS.Components.Controls.Gauge t_GR6_CF;
        public HACS.Components.Controls.Gauge t_GR6_F;
		public HACS.Components.Controls.Gauge p_GR6;
        public HACS.Components.Controls.Gauge t_VP;
        public System.Windows.Forms.TextBox sp_GR1_F;
        public System.Windows.Forms.TextBox sp_GR2_F;
        public System.Windows.Forms.TextBox sp_GR3_F;
        public System.Windows.Forms.TextBox sp_GR4_F;
        public System.Windows.Forms.TextBox sp_GR5_F;
        public System.Windows.Forms.TextBox sp_GR6_F;
        public System.Windows.Forms.Label p_VMLabel;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TextBox sp_CC_S;
		public HACS.Components.Controls.Gauge t_CuAg_CF;
        public System.Windows.Forms.Panel GR1_panel;
        public System.Windows.Forms.Panel GR6_panel;
        public System.Windows.Forms.Panel GR5_panel;
        public System.Windows.Forms.Panel GR4_panel;
        public System.Windows.Forms.Panel GR3_panel;
		public System.Windows.Forms.Panel GR2_panel;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabControlPanel;
		public System.Windows.Forms.TabPage tabSettings;
        public System.Windows.Forms.Label ClosedColor;
        public System.Windows.Forms.Label ClosedColorLabel;
        public System.Windows.Forms.Label OpenedColor;
        public System.Windows.Forms.Label OpenedColorLabel;
        public System.Windows.Forms.Label UnknownColor;
        public System.Windows.Forms.Label UnknownColorLabel;
        public System.Windows.Forms.Label ClosingColor;
        public System.Windows.Forms.Label ClosingColorLabel;
        public System.Windows.Forms.Label OpeningColor;
		public System.Windows.Forms.Label OpeningColorLabel;
        public System.Windows.Forms.ContextMenuStrip GRMenu;
		public System.Windows.Forms.Timer UpdateTimer;
        public System.Windows.Forms.Label OnColor;
        public System.Windows.Forms.Label OnColorLabel;
        public System.Windows.Forms.Label HotColor;
        public System.Windows.Forms.Label HotColorLabel;
        public System.Windows.Forms.Label OffColor;
        public System.Windows.Forms.Label OffColorLabel;
        public System.Windows.Forms.Label ColdColor;
        public System.Windows.Forms.Label ColdColorLabel;
        public System.Windows.Forms.Label WarmColor;
        public System.Windows.Forms.Label WarmColorLabel;
        public System.Windows.Forms.Label CoolColor;
        public System.Windows.Forms.Label CoolColorLabel;
        public System.Windows.Forms.PictureBox d_Pump_HV;
		public System.Windows.Forms.PictureBox d_RoughingPump;
        public System.Windows.Forms.PictureBox d_CuAg_F;
        public System.Windows.Forms.Label ErrorColor;
        public System.Windows.Forms.Label ErrorColorLabel;
        public System.Windows.Forms.Label GaugePressureColorLabel;
        public System.Windows.Forms.Label VacuumColor;
        public System.Windows.Forms.Label VacuumColorLabel;
        public System.Windows.Forms.Label HighVacuumColor;
        public System.Windows.Forms.Label HighVacuumColorLabel;
        public HACS.Components.Controls.Gauge p_Ambient;
        public System.Windows.Forms.Label NeutralColor;
        public System.Windows.Forms.Label NeutralColorLabel;
        public System.Windows.Forms.Label O2Label1;
        public System.Windows.Forms.Label H2Label;
        public System.Windows.Forms.Label CO2Label;
        public System.Windows.Forms.Label HeLabel4;
        public System.Windows.Forms.Label HeLabel2;
        public System.Windows.Forms.Label HeLabel1;
        public System.Windows.Forms.Label GaugePressureColor;
        public System.Windows.Forms.Label d_AimPower;
		public System.Windows.Forms.ToolStripStatusLabel statusLabel2;
		public System.Windows.Forms.Label roc_pVTT;
        public System.Windows.Forms.ToolStripMenuItem GRMenuTitle;
        public System.Windows.Forms.PictureBox d_CC_Q;
        public System.Windows.Forms.Label ApplicationBackColor;
        public System.Windows.Forms.Label ApplicationBackColorLabel;
        public HACS.Components.Controls.Gauge t_MC;
        public HACS.Components.Controls.Gauge v_5VSupply;
        public HACS.Components.Controls.Gauge t_muxAIN13;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public HACS.Components.Controls.Gauge p_Bakeout;
        public HACS.Components.Controls.Gauge t_TC1mux0;
        public HACS.Components.Controls.Gauge t_TC0mux0;
        public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label ugCLabel;
		public System.Windows.Forms.Label ugC;
        public System.Windows.Forms.Label roc_ugC;
        public System.Windows.Forms.ContextMenuStrip meterDisplayMenu;
        public System.Windows.Forms.ToolStripMenuItem meterZeroNowMenuItem;
        public HACS.Components.Controls.ValveIndicator vi_MC_split;
        public HACS.Components.Controls.ValveIndicator vi_MC_MCL;
        public HACS.Components.Controls.ValveIndicator vi_MC_MCU;
        public HACS.Components.Controls.ValveIndicator vi_CuAg_MC;
        public HACS.Components.Controls.ValveIndicator vi_VTTR_CuAg;
        public HACS.Components.Controls.ValveIndicator vi_VTT_flow;
        public HACS.Components.Controls.ValveIndicator vi_VTTL_VTTR;
        public HACS.Components.Controls.ValveIndicator vi_IM_VTTL;
        public HACS.Components.Controls.ValveIndicator vi_IP_IM;
        public HACS.Components.Controls.ValveIndicator vi_He_IM;
        public HACS.Components.Controls.ValveIndicator vi_B;
        public HACS.Components.Controls.ValveIndicator vi_LV;
        public HACS.Components.Controls.ValveIndicator vi_HV;
        public HACS.Components.Controls.ValveIndicator vi_GM_VM;
        public HACS.Components.Controls.ValveIndicator vi_split_VM;
        public HACS.Components.Controls.ValveIndicator vi_VTTR_VM;
        public HACS.Components.Controls.ValveIndicator vi_IM_VM;
        public HACS.Components.Controls.ValveIndicator vi_GR6_GM;
        public HACS.Components.Controls.ValveIndicator vi_GR5_GM;
        public HACS.Components.Controls.ValveIndicator vi_GR4_GM;
        public HACS.Components.Controls.ValveIndicator vi_GR3_GM;
        public HACS.Components.Controls.ValveIndicator vi_GR2_GM;
        public HACS.Components.Controls.ValveIndicator vi_GR1_GM;
        public HACS.Components.Controls.ValveIndicator vi_VP_d13C;
        public HACS.Components.Controls.ValveIndicator vi_d13C_GM;
        public HACS.Components.Controls.ValveIndicator vi_CO2_GM_flow;
        public HACS.Components.Controls.ValveIndicator vi_CO2_GM;
        public HACS.Components.Controls.ValveIndicator vi_H2_GM_flow;
        public HACS.Components.Controls.ValveIndicator vi_H2_GM;
        public HACS.Components.Controls.ValveIndicator vi_He_GM_flow;
        public HACS.Components.Controls.ValveIndicator vi_He_GM;
        public HACS.Components.Controls.ValveIndicator vi_split_GM;
        public System.Windows.Forms.Button startButton;
        public System.Windows.Forms.Label ProcessSubStepLabel;
		public System.Windows.Forms.Label ProcessStepLabel;
		public HACS.Components.Controls.ValveIndicator vi_He_VTTL;
        public System.Windows.Forms.Label label12;
        public HACS.Components.Controls.Gauge t_TC2mux1;
        public System.Windows.Forms.Label label11;
		public HACS.Components.Controls.Gauge t_TC2mux0;
        public System.Windows.Forms.ContextMenuStrip ftcMenu;
        public System.Windows.Forms.ToolStripMenuItem ftcStandbyMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ftcFreezeMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ftcRaiseMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ftcThawMenuItem;
        public System.Windows.Forms.ContextMenuStrip tankMenu;
		public System.Windows.Forms.ToolStripMenuItem tankTurnOnOffMenuItem;
        public System.Windows.Forms.Label label18;
		public System.Windows.Forms.Label v_SPS;
        public System.Windows.Forms.Label ProcessTimeLabel;
        public System.Windows.Forms.Label ProcessStepTimeLabel;
		public System.Windows.Forms.Label ProcessSubStepTimeLabel;
		public System.Windows.Forms.Label RunTimeLabel;
		public MouseTransparentLabel DeviceStatePopupLabel;
        public System.Windows.Forms.Label roc_pGM;
        public System.Windows.Forms.Label roc_pForeline;
        public System.Windows.Forms.Label VP_StateLabel;
        public System.Windows.Forms.Label IP_StateLabel;
        public CustomComboBox ProcessComboBox;
        public System.Windows.Forms.Label GR6_ContentsLabel;
        public System.Windows.Forms.Label GR5_ContentsLabel;
        public System.Windows.Forms.Label GR4_ContentsLabel;
        public System.Windows.Forms.Label GR3_ContentsLabel;
        public System.Windows.Forms.Label GR2_ContentsLabel;
        public System.Windows.Forms.Label GR1_ContentsLabel;
		public System.Windows.Forms.PictureBox d_FTC_air;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label roc_pIM;
		public System.Windows.Forms.ToolStripMenuItem tankFillNowMenuItem;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label30;
		public System.Windows.Forms.TextBox pVM_targetTextBox;
		public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ContextMenuStrip heaterMenu;
		public System.Windows.Forms.ToolStripMenuItem HtrPowerMenuItem;
        public HACS.Components.Controls.Gauge t_tabletop;
        public System.Windows.Forms.Label ro_roc_ugC;
		public System.Windows.Forms.Label ro_roc_pGM;
        public System.Windows.Forms.ContextMenuStrip LinePortStateMenu;
		public System.Windows.Forms.ToolStripMenuItem LinePortStateMenuTitle;
		public System.Windows.Forms.Label WarningColorLabel;
		public System.Windows.Forms.Label WarningColor;
		public System.Windows.Forms.Label label34;
		public System.Windows.Forms.TextBox LastGRTextBox;
		public System.Windows.Forms.ToolStripStatusLabel statusLabel3;
		public System.Windows.Forms.Label label35;
		public System.Windows.Forms.TextBox AlertRecipientsTextBox;
		public HACS.Components.Controls.ValveIndicator vi_LN_VTT;
		public System.Windows.Forms.Label debugLabel1;
		public System.Windows.Forms.Label debugLabel3;
		public System.Windows.Forms.Label debugLabel2;
		public System.Windows.Forms.Label VP_ContentsLabel;
		public System.Windows.Forms.CheckBox ClipTemperatureCheckBox;
		public System.Windows.Forms.CheckBox ClipPressureCheckBox;
		public System.Windows.Forms.CheckBox EnableWatchdogsCheckBox;
		private System.Windows.Forms.TabPage tabDeviceSettings;
		public HACS.Components.Controls.ValveIndicator vi_LN_d13C;
		public HACS.Components.Controls.ValveIndicator vi_LN_VP;
		public HACS.Components.Controls.ValveIndicator vi_LN_GR6;
		public HACS.Components.Controls.ValveIndicator vi_LN_GR5;
		public HACS.Components.Controls.ValveIndicator vi_LN_GR4;
		public HACS.Components.Controls.ValveIndicator vi_LN_GR3;
		public HACS.Components.Controls.ValveIndicator vi_LN_GR2;
		public HACS.Components.Controls.ValveIndicator vi_LN_GR1;
		public HACS.Components.Controls.ValveIndicator vi_LN_MC;
		public HACS.Components.Controls.ValveIndicator vi_LN_CuAg;
		public HACS.Components.Controls.Gauge t_tank;
		public System.Windows.Forms.ToolStripMenuItem ftcStopMenuItem;
		private System.Windows.Forms.Panel d_LN_Tank;
		private System.Windows.Forms.Label LNTankLabel;
		public HACS.Components.Controls.Gauge t_VTT_wire;
		public HACS.Components.Controls.Gauge t_VTT_CF;
		public HACS.Components.Controls.Gauge t_VTT;
		public System.Windows.Forms.TextBox sp_VTT;
		public HACS.Components.Controls.Gauge t_GM;
		public System.Windows.Forms.Label label6;
		public HACS.Components.Controls.Gauge t_VTT_top;
		public System.Windows.Forms.Label label65;
		public System.Windows.Forms.Label label64;
		public System.Windows.Forms.Label label63;
		public System.Windows.Forms.Label label62;
		public System.Windows.Forms.Label label61;
		public System.Windows.Forms.Label label40;
		public System.Windows.Forms.Label label39;
		public System.Windows.Forms.Label label16;
		public System.Windows.Forms.Label label15;
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.Label label13;
		public System.Windows.Forms.Label label66;
		public System.Windows.Forms.Panel VttPanel;
		public HACS.Components.Controls.ValveIndicator vi_BP_GM;
		private System.Windows.Forms.TabPage tabBackPanel;
		public HACS.Components.Controls.ValveIndicator vi_d13C_CF;
		public System.Windows.Forms.ContextMenuStrip vttMenu;
		public System.Windows.Forms.ToolStripMenuItem vttRegulateMenuItem;
		public System.Windows.Forms.ToolStripMenuItem vttFreezeMenuItem;
		public System.Windows.Forms.ToolStripMenuItem vttThawMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vttStopMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vttStandbyMenuItem;
		public HACS.Components.Controls.Gauge t_d13C_CF;
		public System.Windows.Forms.Label label7;
		private OvalPictureBox d_GR1_F;
		private OvalPictureBox d_GR6_F;
		private OvalPictureBox d_GR5_F;
		private OvalPictureBox d_GR4_F;
		private OvalPictureBox d_GR3_F;
		private OvalPictureBox d_GR2_F;
		public System.Windows.Forms.CheckBox EnableAutozeroCheckBox;
		public System.Windows.Forms.CheckBox DevicePopupsCheckBox;
		private HACS.Components.Controls.Gauge v_LN_supply;
		public HACS.Components.Controls.Gauge t_FTC_air;
		public System.Windows.Forms.TextBox sp_FTC_air;
		public TransparentPictureBox GR1PictureBox;
		public TransparentPictureBox GR2PictureBox;
		public TransparentPictureBox GR3PictureBox;
		public TransparentPictureBox GR4PictureBox;
		public TransparentPictureBox GR5PictureBox;
		public TransparentPictureBox GR6PictureBox;
		public TransparentPictureBox VPVPictureBox;
		private TransparentPictureBox MCPictureBox;
		private TransparentPictureBox VttPictureBox;
		public TransparentPictureBox d13CCFPictureBox;
		private TransparentPictureBox IMPictureBox;
		private TransparentPictureBox IPPictureBox;
		private TransparentPictureBox VMPictureBox;
		private TransparentPictureBox CuAgPictureBox;
		private TransparentPictureBox SplitPictureBox;
		private TransparentPictureBox VttLPictureBox;
		private TransparentPictureBox VttRPictureBox;
		private TransparentPictureBox GMPictureBox;
		private TransparentPictureBox d13CPictureBox;
		private TransparentPictureBox MCUPictureBox;
		private TransparentPictureBox MCLPictureBox;
		public System.Windows.Forms.ContextMenuStrip OnOffMenu;
		public System.Windows.Forms.ToolStripMenuItem OnMenuItem;
		public System.Windows.Forms.ContextMenuStrip AutoManualMenu;
		public System.Windows.Forms.ToolStripMenuItem AutoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManualOnMenuItem;
		public System.Windows.Forms.PictureBox d_CC_S2;
		private System.Windows.Forms.ToolStripMenuItem vttRaiseMenuItem;
		private System.Windows.Forms.Label DeviceLabel;
		private System.Windows.Forms.Label separator1;
		private System.Windows.Forms.TextBox DeviceSearchBox;
		private System.Windows.Forms.Panel SettingsPanel;
		private System.Windows.Forms.TreeView DeviceNavTree;
		private CustomGroupBox SampleGroupBox;
		public System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label AliquotDisplay;
		public System.Windows.Forms.Label label17;
		public System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label ProcessDisplay;
		private System.Windows.Forms.Label MassDisplay;
		public System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label SampleIDDisplay;
		public System.Windows.Forms.CheckBox SulfurSuspectedCheckBox;
		public System.Windows.Forms.CheckBox Take_d13C_CheckBox;
		public System.Windows.Forms.TextBox FiltrationsTextBox;
		public System.Windows.Forms.CheckBox Only_d13C_CheckBox;
		public System.Windows.Forms.CheckBox NotifyCC_S_CheckBox;
		private TransparentPictureBox VMPressurePictureBox;
		private System.Windows.Forms.Panel VM_Gauges_Panel;
		private System.Windows.Forms.TextBox sbTextBox;
		private System.Windows.Forms.TextBox ljTextBox;
		public HACS.Components.Controls.ValveIndicator vi_new_flow;
		private System.Windows.Forms.Panel DevicesPanel;
		private System.Windows.Forms.Panel ScrollPanel;
		public System.Windows.Forms.PictureBox d_fan_IP;
		public System.Windows.Forms.TextBox GraphiteNumberTextBox;
	}
}

