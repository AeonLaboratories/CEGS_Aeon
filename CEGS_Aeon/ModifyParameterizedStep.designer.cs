namespace CEGS_Aeon_Namespace
{
	partial class ModifyParameterizedStep
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
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.Save = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ButtonPanel.Controls.Add(this.Save);
			this.ButtonPanel.Controls.Add(this.Cancel);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 230);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(274, 50);
			this.ButtonPanel.TabIndex = 258;
			// 
			// Save
			// 
			this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Save.Location = new System.Drawing.Point(104, 12);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(76, 26);
			this.Save.TabIndex = 15;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(186, 12);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(76, 26);
			this.Cancel.TabIndex = 16;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// ModifyParameterizedStep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(274, 280);
			this.Controls.Add(this.ButtonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModifyParameterizedStep";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ModifyParameterizedStep";
			this.Shown += new System.EventHandler(this.ModifyParameterizedStep_Shown);
			this.ButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Cancel;
	}
}