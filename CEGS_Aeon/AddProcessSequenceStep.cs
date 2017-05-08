using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEGS_Aeon_Namespace
{
	public partial class AddProcessSequenceStep : Form
	{
		public string Result = "";

		public AddProcessSequenceStep()
		{
			InitializeComponent();
			PopulateProcessStepsList();
		}

		public void PopulateProcessStepsList()
		{
			List<string> StepList = ProcessNames.All;
			for (int i = 0; i < ProcessSequenceEditor.ParameterizedSteps.Count; i++)
				StepList.Insert(i, ProcessSequenceEditor.ParameterizedSteps[i]);
			ProcessStepsList.DataSource = StepList;

		}

		private void Add_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			if (ProcessStepsList.SelectedItem != null)
				Result = (string)ProcessStepsList.SelectedItem;
			Close();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void ProcessStepsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Add.Enabled = true;
		}
	}
}