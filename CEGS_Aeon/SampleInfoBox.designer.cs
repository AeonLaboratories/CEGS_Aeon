namespace CEGS_Aeon_Namespace
{
	partial class SampleInfoBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CheckBoxPanel = new System.Windows.Forms.Panel();
			this.Vial_loaded_CheckBox = new System.Windows.Forms.CheckBox();
			this.Sample_loaded_CheckBox = new System.Windows.Forms.CheckBox();
			this.Vial_FTC_CheckBox = new System.Windows.Forms.CheckBox();
			this.GR_furnace_CheckBox = new System.Windows.Forms.CheckBox();
			this.GR_FTC_CheckBox = new System.Windows.Forms.CheckBox();
			this.CC_CheckBox = new System.Windows.Forms.CheckBox();
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.NotifyCC_S_CheckBox = new System.Windows.Forms.CheckBox();
			this.Take_d13C_CheckBox = new System.Windows.Forms.CheckBox();
			this.SampleAliquotsTextBox = new System.Windows.Forms.TextBox();
			this.ProcessSequenceComboBox = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.SampleMassTextBox = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.SampleIDTextBox = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.Only_d13C_CheckBox = new System.Windows.Forms.CheckBox();
			this.SampleSourceComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.SulfurSuspectedCheckBox = new System.Windows.Forms.CheckBox();
			this.FiltrationsTextBox = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Air_Valve_CheckBox = new System.Windows.Forms.CheckBox();
			this.CheckBoxPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CheckBoxPanel
			// 
			this.CheckBoxPanel.Controls.Add(this.Vial_loaded_CheckBox);
			this.CheckBoxPanel.Controls.Add(this.Sample_loaded_CheckBox);
			this.CheckBoxPanel.Controls.Add(this.Vial_FTC_CheckBox);
			this.CheckBoxPanel.Controls.Add(this.GR_furnace_CheckBox);
			this.CheckBoxPanel.Controls.Add(this.GR_FTC_CheckBox);
			this.CheckBoxPanel.Controls.Add(this.Air_Valve_CheckBox);
			this.CheckBoxPanel.Controls.Add(this.CC_CheckBox);
			this.CheckBoxPanel.Location = new System.Drawing.Point(12, 107);
			this.CheckBoxPanel.Name = "CheckBoxPanel";
			this.CheckBoxPanel.Size = new System.Drawing.Size(400, 150);
			this.CheckBoxPanel.TabIndex = 255;
			// 
			// Vial_loaded_CheckBox
			// 
			this.Vial_loaded_CheckBox.AccessibleDescription = "";
			this.Vial_loaded_CheckBox.AutoSize = true;
			this.Vial_loaded_CheckBox.Location = new System.Drawing.Point(22, 101);
			this.Vial_loaded_CheckBox.Name = "Vial_loaded_CheckBox";
			this.Vial_loaded_CheckBox.Size = new System.Drawing.Size(78, 17);
			this.Vial_loaded_CheckBox.TabIndex = 14;
			this.Vial_loaded_CheckBox.Text = "Vial loaded";
			this.Vial_loaded_CheckBox.UseVisualStyleBackColor = true;
			this.Vial_loaded_CheckBox.CheckedChanged += new System.EventHandler(this.Vial_loaded_CheckBox_CheckedChanged);
			// 
			// Sample_loaded_CheckBox
			// 
			this.Sample_loaded_CheckBox.AccessibleDescription = "";
			this.Sample_loaded_CheckBox.AutoSize = true;
			this.Sample_loaded_CheckBox.Location = new System.Drawing.Point(22, 9);
			this.Sample_loaded_CheckBox.Name = "Sample_loaded_CheckBox";
			this.Sample_loaded_CheckBox.Size = new System.Drawing.Size(96, 17);
			this.Sample_loaded_CheckBox.TabIndex = 10;
			this.Sample_loaded_CheckBox.Text = "Sample loaded";
			this.Sample_loaded_CheckBox.UseVisualStyleBackColor = true;
			this.Sample_loaded_CheckBox.CheckedChanged += new System.EventHandler(this.Sample_loaded_CheckBox_CheckedChanged);
			// 
			// Vial_FTC_CheckBox
			// 
			this.Vial_FTC_CheckBox.AccessibleDescription = "";
			this.Vial_FTC_CheckBox.AutoSize = true;
			this.Vial_FTC_CheckBox.Location = new System.Drawing.Point(22, 124);
			this.Vial_FTC_CheckBox.Name = "Vial_FTC_CheckBox";
			this.Vial_FTC_CheckBox.Size = new System.Drawing.Size(116, 17);
			this.Vial_FTC_CheckBox.TabIndex = 15;
			this.Vial_FTC_CheckBox.Text = "Vial FTC is in place";
			this.Vial_FTC_CheckBox.UseVisualStyleBackColor = true;
			this.Vial_FTC_CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxListItem_CheckedChanged);
			// 
			// GR_furnace_CheckBox
			// 
			this.GR_furnace_CheckBox.AccessibleDescription = "";
			this.GR_furnace_CheckBox.AutoSize = true;
			this.GR_furnace_CheckBox.Location = new System.Drawing.Point(22, 78);
			this.GR_furnace_CheckBox.Name = "GR_furnace_CheckBox";
			this.GR_furnace_CheckBox.Size = new System.Drawing.Size(144, 17);
			this.GR_furnace_CheckBox.TabIndex = 13;
			this.GR_furnace_CheckBox.Text = "GR furnaces are lowered";
			this.GR_furnace_CheckBox.UseVisualStyleBackColor = true;
			this.GR_furnace_CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxListItem_CheckedChanged);
			// 
			// GR_FTC_CheckBox
			// 
			this.GR_FTC_CheckBox.AccessibleDescription = "";
			this.GR_FTC_CheckBox.AutoSize = true;
			this.GR_FTC_CheckBox.Location = new System.Drawing.Point(22, 55);
			this.GR_FTC_CheckBox.Name = "GR_FTC_CheckBox";
			this.GR_FTC_CheckBox.Size = new System.Drawing.Size(128, 17);
			this.GR_FTC_CheckBox.TabIndex = 12;
			this.GR_FTC_CheckBox.Text = "GR FTCs are in place";
			this.GR_FTC_CheckBox.UseVisualStyleBackColor = true;
			this.GR_FTC_CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxListItem_CheckedChanged);
			// 
			// CC_CheckBox
			// 
			this.CC_CheckBox.AccessibleDescription = "";
			this.CC_CheckBox.AutoSize = true;
			this.CC_CheckBox.Location = new System.Drawing.Point(22, 32);
			this.CC_CheckBox.Name = "CC_CheckBox";
			this.CC_CheckBox.Size = new System.Drawing.Size(227, 17);
			this.CC_CheckBox.TabIndex = 11;
			this.CC_CheckBox.Text = "Combustion chamber furnaces are in place";
			this.CC_CheckBox.UseVisualStyleBackColor = true;
			this.CC_CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxListItem_CheckedChanged);
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ButtonPanel.Controls.Add(this.OK);
			this.ButtonPanel.Controls.Add(this.Cancel);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 297);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(424, 50);
			this.ButtonPanel.TabIndex = 256;
			// 
			// OK
			// 
			this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OK.Enabled = false;
			this.OK.Location = new System.Drawing.Point(254, 12);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(76, 26);
			this.OK.TabIndex = 16;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.Location = new System.Drawing.Point(336, 12);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(76, 26);
			this.Cancel.TabIndex = 17;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// NotifyCC_S_CheckBox
			// 
			this.NotifyCC_S_CheckBox.AccessibleDescription = "Check if CC_S is not raised before starting sample.";
			this.NotifyCC_S_CheckBox.AutoSize = true;
			this.NotifyCC_S_CheckBox.Location = new System.Drawing.Point(254, 84);
			this.NotifyCC_S_CheckBox.Name = "NotifyCC_S_CheckBox";
			this.NotifyCC_S_CheckBox.Size = new System.Drawing.Size(120, 17);
			this.NotifyCC_S_CheckBox.TabIndex = 9;
			this.NotifyCC_S_CheckBox.Text = "Notify to raise CC_S";
			this.NotifyCC_S_CheckBox.UseVisualStyleBackColor = true;
			this.NotifyCC_S_CheckBox.CheckedChanged += new System.EventHandler(this.NotifyCC_S_CheckBox_CheckedChanged);
			// 
			// Take_d13C_CheckBox
			// 
			this.Take_d13C_CheckBox.AccessibleDescription = "Uncheck if no d13C aliquant should be taken from this sample.";
			this.Take_d13C_CheckBox.AutoSize = true;
			this.Take_d13C_CheckBox.Location = new System.Drawing.Point(254, 50);
			this.Take_d13C_CheckBox.Name = "Take_d13C_CheckBox";
			this.Take_d13C_CheckBox.Size = new System.Drawing.Size(79, 17);
			this.Take_d13C_CheckBox.TabIndex = 6;
			this.Take_d13C_CheckBox.Text = "Take d13C";
			this.Take_d13C_CheckBox.UseVisualStyleBackColor = true;
			this.Take_d13C_CheckBox.CheckedChanged += new System.EventHandler(this.Take_d13C_CheckBox_CheckedChanged);
			// 
			// SampleAliquotsTextBox
			// 
			this.SampleAliquotsTextBox.AccessibleDescription = "Enter the number of aliquots to graphitize";
			this.SampleAliquotsTextBox.Location = new System.Drawing.Point(284, 23);
			this.SampleAliquotsTextBox.MaxLength = 1;
			this.SampleAliquotsTextBox.Name = "SampleAliquotsTextBox";
			this.SampleAliquotsTextBox.Size = new System.Drawing.Size(55, 20);
			this.SampleAliquotsTextBox.TabIndex = 2;
			this.SampleAliquotsTextBox.Text = "1";
			this.SampleAliquotsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SampleAliquotsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneKeyTextBox_KeyPress);
			this.SampleAliquotsTextBox.Leave += new System.EventHandler(this.LeaveSampleAliquotsTextBox);
			// 
			// ProcessSequenceComboBox
			// 
			this.ProcessSequenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProcessSequenceComboBox.FormattingEnabled = true;
			this.ProcessSequenceComboBox.Location = new System.Drawing.Point(54, 77);
			this.ProcessSequenceComboBox.Name = "ProcessSequenceComboBox";
			this.ProcessSequenceComboBox.Size = new System.Drawing.Size(194, 21);
			this.ProcessSequenceComboBox.TabIndex = 5;
			this.ProcessSequenceComboBox.SelectionChangeCommitted += new System.EventHandler(this.ProcessComboBoxChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Location = new System.Drawing.Point(261, 27);
			this.label23.Margin = new System.Windows.Forms.Padding(0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(13, 13);
			this.label23.TabIndex = 347;
			this.label23.Text = "g";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(176, 9);
			this.label21.Margin = new System.Windows.Forms.Padding(0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(85, 13);
			this.label21.TabIndex = 346;
			this.label21.Text = "Mass";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SampleMassTextBox
			// 
			this.SampleMassTextBox.AccessibleDescription = "Enter the sample mass";
			this.SampleMassTextBox.BackColor = System.Drawing.Color.White;
			this.SampleMassTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SampleMassTextBox.Location = new System.Drawing.Point(176, 24);
			this.SampleMassTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.SampleMassTextBox.Name = "SampleMassTextBox";
			this.SampleMassTextBox.Size = new System.Drawing.Size(85, 20);
			this.SampleMassTextBox.TabIndex = 1;
			this.SampleMassTextBox.Tag = "";
			this.SampleMassTextBox.Text = "10000.000000";
			this.SampleMassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SampleMassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.SampleMassTextBox.Leave += new System.EventHandler(this.LeaveSampleMassTextBox);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(10, 9);
			this.label20.Margin = new System.Windows.Forms.Padding(0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(56, 13);
			this.label20.TabIndex = 345;
			this.label20.Text = "Sample ID";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SampleIDTextBox
			// 
			this.SampleIDTextBox.AccessibleDescription = "Enter the sample ID";
			this.SampleIDTextBox.BackColor = System.Drawing.Color.White;
			this.SampleIDTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SampleIDTextBox.Location = new System.Drawing.Point(13, 24);
			this.SampleIDTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.SampleIDTextBox.Name = "SampleIDTextBox";
			this.SampleIDTextBox.Size = new System.Drawing.Size(156, 20);
			this.SampleIDTextBox.TabIndex = 0;
			this.SampleIDTextBox.Tag = "";
			this.SampleIDTextBox.Text = "Dead CO2";
			this.SampleIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exitKeyHandler);
			this.SampleIDTextBox.Leave += new System.EventHandler(this.LeaveSampleIDTextBox);
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(284, 9);
			this.label19.Margin = new System.Windows.Forms.Padding(0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(55, 13);
			this.label19.TabIndex = 344;
			this.label19.Text = "Aliquots";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Only_d13C_CheckBox
			// 
			this.Only_d13C_CheckBox.AccessibleDescription = "Check ONLY if no graphite is to be made.";
			this.Only_d13C_CheckBox.AutoSize = true;
			this.Only_d13C_CheckBox.Location = new System.Drawing.Point(339, 50);
			this.Only_d13C_CheckBox.Name = "Only_d13C_CheckBox";
			this.Only_d13C_CheckBox.Size = new System.Drawing.Size(75, 17);
			this.Only_d13C_CheckBox.TabIndex = 7;
			this.Only_d13C_CheckBox.Text = "Only d13C";
			this.Only_d13C_CheckBox.UseVisualStyleBackColor = true;
			this.Only_d13C_CheckBox.CheckedChanged += new System.EventHandler(this.Only_d13C_CheckBox_CheckedChanged);
			// 
			// SampleSourceComboBox
			// 
			this.SampleSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SampleSourceComboBox.FormattingEnabled = true;
			this.SampleSourceComboBox.Location = new System.Drawing.Point(54, 50);
			this.SampleSourceComboBox.Name = "SampleSourceComboBox";
			this.SampleSourceComboBox.Size = new System.Drawing.Size(194, 21);
			this.SampleSourceComboBox.TabIndex = 4;
			this.SampleSourceComboBox.SelectionChangeCommitted += new System.EventHandler(this.SampleSourceComboBoxChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(10, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 349;
			this.label1.Text = "Source";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(6, 80);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 350;
			this.label2.Text = "Process";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.CheckBoxPanel);
			this.panel1.Controls.Add(this.NotifyCC_S_CheckBox);
			this.panel1.Controls.Add(this.SampleSourceComboBox);
			this.panel1.Controls.Add(this.Only_d13C_CheckBox);
			this.panel1.Controls.Add(this.ProcessSequenceComboBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.SampleIDTextBox);
			this.panel1.Controls.Add(this.SampleMassTextBox);
			this.panel1.Controls.Add(this.SulfurSuspectedCheckBox);
			this.panel1.Controls.Add(this.Take_d13C_CheckBox);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.FiltrationsTextBox);
			this.panel1.Controls.Add(this.SampleAliquotsTextBox);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.panel1.Size = new System.Drawing.Size(424, 265);
			this.panel1.TabIndex = 351;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(353, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 344;
			this.label3.Text = "Filtrations";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SulfurSuspectedCheckBox
			// 
			this.SulfurSuspectedCheckBox.AccessibleDescription = "Use an extra GR to trap sulfur before graphitizing.";
			this.SulfurSuspectedCheckBox.AutoSize = true;
			this.SulfurSuspectedCheckBox.Location = new System.Drawing.Point(254, 68);
			this.SulfurSuspectedCheckBox.Name = "SulfurSuspectedCheckBox";
			this.SulfurSuspectedCheckBox.Size = new System.Drawing.Size(105, 17);
			this.SulfurSuspectedCheckBox.TabIndex = 8;
			this.SulfurSuspectedCheckBox.Text = "Sulfur suspected";
			this.SulfurSuspectedCheckBox.UseVisualStyleBackColor = true;
			this.SulfurSuspectedCheckBox.CheckedChanged += new System.EventHandler(this.SulfurSuspectedCheckBox_CheckedChanged);
			// 
			// FiltrationsTextBox
			// 
			this.FiltrationsTextBox.AccessibleDescription = "Enter the number of aliquots to graphitize";
			this.FiltrationsTextBox.Location = new System.Drawing.Point(369, 23);
			this.FiltrationsTextBox.MaxLength = 1;
			this.FiltrationsTextBox.Name = "FiltrationsTextBox";
			this.FiltrationsTextBox.Size = new System.Drawing.Size(23, 20);
			this.FiltrationsTextBox.TabIndex = 3;
			this.FiltrationsTextBox.Text = "1";
			this.FiltrationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FiltrationsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneKeyTextBox_KeyPress);
			this.FiltrationsTextBox.Leave += new System.EventHandler(this.LeaveFiltrationsTextBox);
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(424, 0);
			this.panel2.TabIndex = 352;
			// 
			// Air_Valve_CheckBox
			// 
			this.Air_Valve_CheckBox.AccessibleDescription = "";
			this.Air_Valve_CheckBox.AutoSize = true;
			this.Air_Valve_CheckBox.Location = new System.Drawing.Point(22, 32);
			this.Air_Valve_CheckBox.Name = "Air_Valve_CheckBox";
			this.Air_Valve_CheckBox.Size = new System.Drawing.Size(160, 17);
			this.Air_Valve_CheckBox.TabIndex = 10;
			this.Air_Valve_CheckBox.Text = "TF Up-To-Air valve is closed";
			this.Air_Valve_CheckBox.UseVisualStyleBackColor = true;
			this.Air_Valve_CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxListItem_CheckedChanged);
			// 
			// SampleInfoBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(424, 347);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ButtonPanel);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SampleInfoBox";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Run Sample";
			this.CheckBoxPanel.ResumeLayout(false);
			this.CheckBoxPanel.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel CheckBoxPanel;
		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
		public System.Windows.Forms.CheckBox NotifyCC_S_CheckBox;
		public System.Windows.Forms.CheckBox Take_d13C_CheckBox;
		public System.Windows.Forms.TextBox SampleAliquotsTextBox;
		public System.Windows.Forms.ComboBox ProcessSequenceComboBox;
		public System.Windows.Forms.Label label23;
		public System.Windows.Forms.Label label21;
		public System.Windows.Forms.TextBox SampleMassTextBox;
		public System.Windows.Forms.Label label20;
		public System.Windows.Forms.TextBox SampleIDTextBox;
		public System.Windows.Forms.Label label19;
		public System.Windows.Forms.CheckBox Only_d13C_CheckBox;
		public System.Windows.Forms.CheckBox Vial_FTC_CheckBox;
		public System.Windows.Forms.CheckBox GR_furnace_CheckBox;
		public System.Windows.Forms.CheckBox GR_FTC_CheckBox;
		public System.Windows.Forms.CheckBox CC_CheckBox;
		public System.Windows.Forms.CheckBox Sample_loaded_CheckBox;
		public System.Windows.Forms.CheckBox Vial_loaded_CheckBox;
		public System.Windows.Forms.ComboBox SampleSourceComboBox;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.CheckBox SulfurSuspectedCheckBox;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox FiltrationsTextBox;
		public System.Windows.Forms.CheckBox Air_Valve_CheckBox;
	}
}