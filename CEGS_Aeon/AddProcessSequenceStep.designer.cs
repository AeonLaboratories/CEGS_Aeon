namespace CEGS_Aeon_Namespace
{
	partial class AddProcessSequenceStep
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
			this.Add = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.ProcessStepsList = new global::CEGS_Aeon_Namespace.CustomListBox();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ButtonPanel.Controls.Add(this.Add);
			this.ButtonPanel.Controls.Add(this.Cancel);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 158);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(272, 50);
			this.ButtonPanel.TabIndex = 259;
			// 
			// Add
			// 
			this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Add.Enabled = false;
			this.Add.Location = new System.Drawing.Point(102, 12);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(76, 26);
			this.Add.TabIndex = 15;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(184, 12);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(76, 26);
			this.Cancel.TabIndex = 16;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// ProcessStepsList
			// 
			this.ProcessStepsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessStepsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ProcessStepsList.FormattingEnabled = true;
			this.ProcessStepsList.HorizontalScrollbar = true;
			this.ProcessStepsList.Location = new System.Drawing.Point(12, 12);
			this.ProcessStepsList.MinimumSize = new System.Drawing.Size(218, 134);
			this.ProcessStepsList.Name = "ProcessStepsList";
			this.ProcessStepsList.Size = new System.Drawing.Size(248, 134);
			this.ProcessStepsList.TabIndex = 260;
			this.ProcessStepsList.SelectedIndexChanged += new System.EventHandler(this.ProcessStepsList_SelectedIndexChanged);
			// 
			// AddProcessSequenceStep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 208);
			this.Controls.Add(this.ProcessStepsList);
			this.Controls.Add(this.ButtonPanel);
			this.MinimumSize = new System.Drawing.Size(288, 244);
			this.Name = "AddProcessSequenceStep";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Process Sequence Step";
			this.ButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Cancel;
		private CustomListBox ProcessStepsList;
	}
}