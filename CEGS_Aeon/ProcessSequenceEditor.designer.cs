namespace CEGS_Aeon_Namespace
{
	partial class ProcessSequenceEditor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessSequenceEditor));
			this.ProcessComboBox = new System.Windows.Forms.ComboBox();
			this.AddProcessButton = new System.Windows.Forms.Button();
			this.RemoveProcessButton = new System.Windows.Forms.Button();
			this.ProcessStepsList = new System.Windows.Forms.ListBox();
			this.ListBoxItemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewStepButton = new System.Windows.Forms.Button();
			this.RemoveStepButton = new System.Windows.Forms.Button();
			this.UpButton = new System.Windows.Forms.Button();
			this.DownButton = new System.Windows.Forms.Button();
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.Save = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.SourceComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.FocusPanel = new System.Windows.Forms.Panel();
			this.ListBoxItemContextMenu.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.FocusPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProcessComboBox
			// 
			this.ProcessComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessComboBox.FormattingEnabled = true;
			this.ProcessComboBox.Location = new System.Drawing.Point(12, 12);
			this.ProcessComboBox.MinimumSize = new System.Drawing.Size(136, 0);
			this.ProcessComboBox.Name = "ProcessComboBox";
			this.ProcessComboBox.Size = new System.Drawing.Size(186, 21);
			this.ProcessComboBox.TabIndex = 0;
			this.ProcessComboBox.SelectionChangeCommitted += new System.EventHandler(this.ProcessComboBoxChange);
			this.ProcessComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProcessComboBox_KeyPress);
			// 
			// AddProcessButton
			// 
			this.AddProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddProcessButton.Location = new System.Drawing.Point(209, 11);
			this.AddProcessButton.Name = "AddProcessButton";
			this.AddProcessButton.Size = new System.Drawing.Size(63, 23);
			this.AddProcessButton.TabIndex = 1;
			this.AddProcessButton.Text = "New...";
			this.AddProcessButton.UseVisualStyleBackColor = true;
			this.AddProcessButton.Click += new System.EventHandler(this.AddProcessButton_Click);
			// 
			// RemoveProcessButton
			// 
			this.RemoveProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveProcessButton.Location = new System.Drawing.Point(209, 39);
			this.RemoveProcessButton.Name = "RemoveProcessButton";
			this.RemoveProcessButton.Size = new System.Drawing.Size(63, 23);
			this.RemoveProcessButton.TabIndex = 2;
			this.RemoveProcessButton.Text = "Delete";
			this.RemoveProcessButton.UseVisualStyleBackColor = true;
			this.RemoveProcessButton.Click += new System.EventHandler(this.RemoveProcessButton_Click);
			// 
			// ProcessStepsList
			// 
			this.ProcessStepsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessStepsList.FormattingEnabled = true;
			this.ProcessStepsList.HorizontalScrollbar = true;
			this.ProcessStepsList.Location = new System.Drawing.Point(12, 69);
			this.ProcessStepsList.MinimumSize = new System.Drawing.Size(218, 134);
			this.ProcessStepsList.Name = "ProcessStepsList";
			this.ProcessStepsList.Size = new System.Drawing.Size(221, 147);
			this.ProcessStepsList.TabIndex = 3;
			this.ProcessStepsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessStepsList_MouseDown);
			// 
			// ListBoxItemContextMenu
			// 
			this.ListBoxItemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem});
			this.ListBoxItemContextMenu.Name = "ListBoxItemContextMenu";
			this.ListBoxItemContextMenu.Size = new System.Drawing.Size(113, 26);
			// 
			// modifyToolStripMenuItem
			// 
			this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.modifyToolStripMenuItem.Text = "Modify";
			this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
			// 
			// NewStepButton
			// 
			this.NewStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NewStepButton.Image = ((System.Drawing.Image)(resources.GetObject("NewStepButton.Image")));
			this.NewStepButton.Location = new System.Drawing.Point(246, 148);
			this.NewStepButton.Margin = new System.Windows.Forms.Padding(0);
			this.NewStepButton.Name = "NewStepButton";
			this.NewStepButton.Size = new System.Drawing.Size(26, 24);
			this.NewStepButton.TabIndex = 5;
			this.NewStepButton.UseVisualStyleBackColor = true;
			this.NewStepButton.Click += new System.EventHandler(this.NewStepButton_Click);
			// 
			// RemoveStepButton
			// 
			this.RemoveStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveStepButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveStepButton.Image")));
			this.RemoveStepButton.Location = new System.Drawing.Point(246, 178);
			this.RemoveStepButton.Name = "RemoveStepButton";
			this.RemoveStepButton.Size = new System.Drawing.Size(26, 24);
			this.RemoveStepButton.TabIndex = 6;
			this.RemoveStepButton.UseVisualStyleBackColor = true;
			this.RemoveStepButton.Click += new System.EventHandler(this.RemoveStepButton_Click);
			// 
			// UpButton
			// 
			this.UpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UpButton.Location = new System.Drawing.Point(246, 86);
			this.UpButton.Name = "UpButton";
			this.UpButton.Size = new System.Drawing.Size(26, 24);
			this.UpButton.TabIndex = 7;
			this.UpButton.Text = "▲";
			this.UpButton.UseVisualStyleBackColor = true;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// DownButton
			// 
			this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DownButton.Location = new System.Drawing.Point(246, 116);
			this.DownButton.Name = "DownButton";
			this.DownButton.Size = new System.Drawing.Size(26, 24);
			this.DownButton.TabIndex = 8;
			this.DownButton.Text = "▼";
			this.DownButton.UseVisualStyleBackColor = true;
			this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ButtonPanel.Controls.Add(this.Save);
			this.ButtonPanel.Controls.Add(this.Cancel);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 224);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(284, 50);
			this.ButtonPanel.TabIndex = 257;
			// 
			// Save
			// 
			this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Save.Location = new System.Drawing.Point(114, 12);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(76, 26);
			this.Save.TabIndex = 15;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(196, 12);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(76, 26);
			this.Cancel.TabIndex = 16;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SourceComboBox
			// 
			this.SourceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SourceComboBox.FormattingEnabled = true;
			this.SourceComboBox.Location = new System.Drawing.Point(62, 40);
			this.SourceComboBox.MinimumSize = new System.Drawing.Size(136, 0);
			this.SourceComboBox.Name = "SourceComboBox";
			this.SourceComboBox.Size = new System.Drawing.Size(136, 21);
			this.SourceComboBox.TabIndex = 258;
			this.SourceComboBox.SelectionChangeCommitted += new System.EventHandler(this.SourceComboBox_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 259;
			this.label1.Text = "Source:";
			// 
			// FocusPanel
			// 
			this.FocusPanel.Controls.Add(this.ProcessComboBox);
			this.FocusPanel.Controls.Add(this.label1);
			this.FocusPanel.Controls.Add(this.AddProcessButton);
			this.FocusPanel.Controls.Add(this.SourceComboBox);
			this.FocusPanel.Controls.Add(this.RemoveProcessButton);
			this.FocusPanel.Controls.Add(this.ProcessStepsList);
			this.FocusPanel.Controls.Add(this.NewStepButton);
			this.FocusPanel.Controls.Add(this.DownButton);
			this.FocusPanel.Controls.Add(this.RemoveStepButton);
			this.FocusPanel.Controls.Add(this.UpButton);
			this.FocusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FocusPanel.Location = new System.Drawing.Point(0, 0);
			this.FocusPanel.Name = "FocusPanel";
			this.FocusPanel.Size = new System.Drawing.Size(284, 274);
			this.FocusPanel.TabIndex = 260;
			this.FocusPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FocusOnMouseClick);
			// 
			// ProcessSequenceEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(284, 274);
			this.Controls.Add(this.ButtonPanel);
			this.Controls.Add(this.FocusPanel);
			this.MinimumSize = new System.Drawing.Size(300, 310);
			this.Name = "ProcessSequenceEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Process Sequence Editor";
			this.ListBoxItemContextMenu.ResumeLayout(false);
			this.ButtonPanel.ResumeLayout(false);
			this.FocusPanel.ResumeLayout(false);
			this.FocusPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox ProcessComboBox;
		private System.Windows.Forms.Button AddProcessButton;
		private System.Windows.Forms.Button RemoveProcessButton;
		private System.Windows.Forms.ListBox ProcessStepsList;
		private System.Windows.Forms.Button NewStepButton;
		private System.Windows.Forms.Button RemoveStepButton;
		private System.Windows.Forms.Button UpButton;
		private System.Windows.Forms.Button DownButton;
		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.ContextMenuStrip ListBoxItemContextMenu;
		private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
		private System.Windows.Forms.ComboBox SourceComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel FocusPanel;
	}
}