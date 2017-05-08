using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HACS.Core;
using HACS.Components;

namespace CEGS_Aeon_Namespace
{
	public partial class ProcessSequenceEditor : Form
	{
		CEGS CEGS;
		int ModifyProcessIndex = -1;
		public static List<string> ParameterizedSteps = new List<string>(new string[] { "Combust", "WaitMinutes" });

		public ProcessSequenceEditor()
		{
			InitializeComponent();
			Owner = UserInterface.ActiveForm;
			CEGS = (Owner as UserInterface).CEGS;

			PopulateControls();
		}

		public static new DialogResult Show()
		{
			ProcessSequenceEditor form = new ProcessSequenceEditor();
			return form.ShowDialog();
		}

		public void PopulateControls()
		{
			int index = 0;
			if (ProcessComboBox.Items.Count > 0)
				index = ProcessComboBox.SelectedIndex;
			ProcessComboBox.Items.Clear();
			var ProcessSequenceList = new List<ProcessSequence>();
			foreach (ProcessSequence ps in ProcessSequence.List)
				ProcessSequenceList.Add(ps.Clone());
			foreach (ProcessSequence ps in ProcessSequenceList)
				ProcessComboBox.Items.Add(ps);
			if (index >= ProcessComboBox.Items.Count)
				index = ProcessComboBox.Items.Count - 1;
			ProcessComboBox.SelectedIndex = index;
			ProcessComboBox.LostFocus += new EventHandler(ProcessComboBox_LostFocus);

			SourceComboBox.DataSource = Enum.GetValues(typeof(SampleSources));
			UpdateSourceComboBox();

			LoadProcessSequence();
		}

		void ProcessComboBox_LostFocus(object sender, EventArgs e)
		{
			if (ModifyProcessIndex != -1)
				ProcessComboBox.SelectedIndex = ModifyProcessIndex;
		}

		private void ProcessComboBoxChange(object sender, EventArgs e)
		{
			UpdateSourceComboBox();
			LoadProcessSequence();
		}

		public void LoadProcessSequence()
		{
			ProcessStepsList.Items.Clear();
			ProcessSequence ps = (ProcessSequence)(ProcessComboBox).SelectedItem;
			foreach (ProcessSequenceStep step in ps.Steps)
			{
				ProcessStepsList.Items.Add(step);
			}
		}

		public void UpdateSourceComboBox()
		{
			SampleSources source = SampleSources.InletPortCombustion;
			if (ProcessComboBox.SelectedItem != null)
				source = (ProcessComboBox.SelectedItem as ProcessSequence).SampleSource;
			SourceComboBox.SelectedItem = source;
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			MoveUp();
		}

		private void DownButton_Click(object sender, EventArgs e)
		{
			MoveDown();
		}

		private void NewStepButton_Click(object sender, EventArgs e)
		{
			AddProcessSequenceStep step = new AddProcessSequenceStep();
			if (step.ShowDialog() == DialogResult.OK)
			{
				if (step.Result.Equals(""))
					return;
				if (ParameterizedSteps.Contains(step.Result))
				{
					if (step.Result.Equals("Combust"))
						AddItem(new CombustionStep());
					else if (step.Result.Equals("WaitMinutes"))
						AddItem(new WaitMinutesStep());

					int index = 0;
					if (ProcessStepsList.SelectedIndex >= 0)
						index = ProcessStepsList.SelectedIndex;
					else
						index = ProcessStepsList.Items.Count - 1;
					ModifyParameterizedStep ModifiedStepForm = new ModifyParameterizedStep(ProcessStepsList.Items[index] as ProcessSequenceStep);
					if (ModifiedStepForm.ShowDialog() == DialogResult.OK)
						ProcessStepsList.Items[index] = ModifiedStepForm.Step;
				}
				else
					AddItem(new ProcessSequenceStep(step.Result));
			}
		}

		private void RemoveStepButton_Click(object sender, EventArgs e)
		{
			RemoveItem();
		}

		public void MoveUp()
		{
			MoveItem(-1);
		}

		public void MoveDown()
		{
			MoveItem(1);
		}

		public void MoveItem(int direction)
		{
			if (ProcessStepsList.SelectedItem == null || ProcessStepsList.SelectedIndex < 0)
				return;

			int newIndex = ProcessStepsList.SelectedIndex + direction;

			if (newIndex < 0 || newIndex >= ProcessStepsList.Items.Count)
				return;

			object selected = ProcessStepsList.SelectedItem;

			ProcessStepsList.Items.Remove(selected);
			ProcessStepsList.Items.Insert(newIndex, selected);
			ProcessStepsList.SetSelected(newIndex, true);

			SaveSteps();
		}

		public void AddItem(ProcessSequenceStep step)
		{
			int index;
			if (ProcessStepsList.SelectedItem == null || ProcessStepsList.SelectedIndex < 0)
				index = ProcessStepsList.Items.Count;
			else
				index = ProcessStepsList.SelectedIndex + 1;
			ProcessStepsList.Items.Insert(index, step);
			if (ProcessStepsList.SelectedIndex >= 0)
				ProcessStepsList.SelectedIndex++;

			SaveSteps();
		}

		public void RemoveItem()
		{
			if (ProcessStepsList.SelectedItem == null || ProcessStepsList.SelectedIndex < 0)
				return;
			int index = ProcessStepsList.SelectedIndex;
			ProcessStepsList.Items.Remove(ProcessStepsList.SelectedItem);
			if (index >= ProcessStepsList.Items.Count)
				index = ProcessStepsList.Items.Count - 1;
			ProcessStepsList.SelectedIndex = index;

			SaveSteps();
		}

		public void SaveSteps()
		{
			List<ProcessSequenceStep> steps = new List<ProcessSequenceStep>();

			foreach (object i in ProcessStepsList.Items)
			{
				if (i is ProcessSequenceStep)
					steps.Add((ProcessSequenceStep)i);
			}

			(ProcessComboBox.SelectedItem as ProcessSequence).Steps = steps;
		}

		public void SaveProcess()
		{
			List<ProcessSequence> list = new List<ProcessSequence>();
			foreach (object i in ProcessComboBox.Items)
			{
				list.Add((ProcessSequence)i);
			}
			ProcessSequence.List = list;
		}

		void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		void SaveButton_Click(object sender, EventArgs e)
		{
			SaveProcess();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void AddProcessButton_Click(object sender, EventArgs e)
		{
			ProcessSequence ps = new ProcessSequence("New Process Sequence");
			ProcessComboBox.Items.Add(ps);
			ProcessComboBox.SelectedItem = ps;

			UpdateSourceComboBox();
			LoadProcessSequence();
		}

		private void RemoveProcessButton_Click(object sender, EventArgs e)
		{
			if (ProcessComboBox.SelectedItem == null || ProcessComboBox.SelectedIndex < 0)
				return;
			int index = ProcessComboBox.SelectedIndex;
			ProcessComboBox.Items.Remove(ProcessComboBox.SelectedItem);
			if (index >= ProcessComboBox.Items.Count)
				index = ProcessComboBox.Items.Count - 1;
			ProcessComboBox.SelectedIndex = index;

			UpdateSourceComboBox();
			LoadProcessSequence();
		}

		private void ProcessComboBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (ProcessComboBox.SelectedItem != null)
				ModifyProcessIndex = ProcessComboBox.Items.IndexOf(ProcessComboBox.SelectedItem);

			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				if (ModifyProcessIndex != -1)
				{
					string name = ProcessComboBox.Text;
					ProcessSequence ps = (ProcessSequence)ProcessComboBox.Items[ModifyProcessIndex];
					ps.Name = name;
					ProcessComboBox.Items[ModifyProcessIndex] = ps;
					ProcessComboBox.SelectedIndex = ModifyProcessIndex;
					ProcessComboBox.SelectAll();
					ModifyProcessIndex = -1;
				}
			}
		}

		private void ProcessStepsList_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				ProcessStepsList.SelectedIndex = ProcessStepsList.IndexFromPoint(e.Location);
				if (ProcessStepsList.SelectedIndex != -1)
				{
					if (ProcessStepsList.SelectedItem.GetType().IsSubclassOf(typeof(ProcessSequenceStep)))
					{
						ListBoxItemContextMenu.Show(Cursor.Position);
					}
				} 
			}
		}

		private void FocusOnMouseClick(object sender, MouseEventArgs e)
		{
			(sender as Control).Focus();
		}

		private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ModifyParameterizedStep ModifiedStepForm = new ModifyParameterizedStep(ProcessStepsList.SelectedItem as ProcessSequenceStep);
			if (ModifiedStepForm.ShowDialog() == DialogResult.OK)
				ProcessStepsList.Items[ProcessStepsList.SelectedIndex] = ModifiedStepForm.Step;
		}

		private void SourceComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			(ProcessComboBox.SelectedItem as ProcessSequence).SampleSource = (SampleSources)SourceComboBox.SelectedItem;
		}
	}
}
