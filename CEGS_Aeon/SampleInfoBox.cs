using System;
using System.Windows.Forms;
using HACS.Components;
using System.Collections.Generic;
using HACS.Core;

namespace CEGS_Aeon_Namespace
{
	public partial class SampleInfoBox : Form
	{
		CEGS CEGS;
		Sample Sample;
		bool RunSample;

		public SampleInfoBox()
		{
			InitializeComponent();
			Owner = UserInterface.ActiveForm;
			CEGS = (Owner as UserInterface).CEGS;
			Sample = new Sample(CEGS.Sample);
			ActiveControl = SampleIDTextBox;
		}

		public SampleInfoBox(bool run) : this()
		{
			RunSample = run;
			if (!RunSample)
				Text = "Enter Sample Information";
			InitializeControlContents();
		}

		public static new DialogResult Show()
		{
			return Show(true);
		}

		public static DialogResult Show(bool run)
		{
			SampleInfoBox form = new SampleInfoBox(run);
			return form.ShowDialog();
		}

		void InitializeControlContents()
		{
			SampleIDTextBox.Text = Sample.ID;

			SampleSourceComboBox.DataSource = Enum.GetValues(typeof(SampleSources));
			SampleSourceComboBox.SelectedItem = Sample.Source;

			PopulateProcessOptions();

			UpdateSampleMassTextBox();
			SampleAliquotsTextBox.Text = Sample.nAliquots.ToString();
			FiltrationsTextBox.Text = Sample.Filtrations.ToString();
			SulfurSuspectedCheckBox.Checked = Sample.SulfurSuspected;
			NotifyCC_S_CheckBox.Checked = Sample.NotifyCC_S;
			Take_d13C_CheckBox.Checked = Sample.Take_d13C;
			Only_d13C_CheckBox.Checked = Sample.Only_d13C;
			Only_d13C_CheckBox.Enabled = Sample.Take_d13C;
			
			if (RunSample)
			{
				CheckSampleLoaded();
				CheckVialLoaded();
				EnableCheckBoxes();
			}
			else
			{
				CheckBoxPanel.Hide();
				OK.Enabled = true;
			}
		}

		void PopulateProcessOptions()
		{
			ProcessSequenceComboBox.Items.Clear();

			foreach (ProcessSequence ps in ProcessSequence.List)
			{
				if (ps.SampleSource == Sample.Source)
					ProcessSequenceComboBox.Items.Add(ps.Name);
			}

			if (ProcessSequenceComboBox.Items.Contains(Sample.Process))
				ProcessSequenceComboBox.SelectedItem = Sample.Process;
			
			if (ProcessSequenceComboBox.Items.Count > 0)
			{
				if (ProcessSequenceComboBox.SelectedIndex == -1)
					ProcessSequenceComboBox.SelectedIndex = 0;
				if (ProcessSequenceComboBox.SelectedItem != null)
					Sample.Process = ProcessSequenceComboBox.SelectedItem.ToString();
			}
		}

		void CheckSampleLoaded()
		{
			if (Sample.Source == SampleSources.CO2Supply)
			{
				Sample_loaded_CheckBox.Text = "Sample loaded";
				Sample_loaded_CheckBox.Checked = true;
			}
			/*
			else if (Sample.Source == SampleSources.BreaksealPort)
			{
				Sample_loaded_CheckBox.Text = "Sample loaded at Breakseal Port";
				Sample_loaded_CheckBox.Checked = 
					CEGS.BP.State == LinePort.States.Loaded || 
					CEGS.BP.State == LinePort.States.Prepared;
			}
			*/
			else
			{
				Sample_loaded_CheckBox.Text = "Sample loaded at Inlet Port";
				Sample_loaded_CheckBox.Checked = 
					CEGS.IP.State == LinePort.States.Loaded || 
					CEGS.IP.State == LinePort.States.Prepared;
			}
		}

		void CheckVialLoaded()
		{
			Vial_loaded_CheckBox.Checked = 
				CEGS.VP.State == LinePort.States.Loaded || 
				CEGS.VP.State == LinePort.States.Prepared;
		}

		void EnableCheckBoxes()
		{
			Air_Valve_CheckBox.Enabled = false;

			if (Sample.Source == SampleSources.CO2Supply)
				Sample_loaded_CheckBox.Enabled = false;
			else
				Sample_loaded_CheckBox.Enabled = true;

			if (Sample.Source == SampleSources.InletPortCombustion)
			{
				NotifyCC_S_CheckBox.Enabled = true;
				CC_CheckBox.Enabled = true;
			}
			else
			{
				NotifyCC_S_CheckBox.Enabled = false;
				CC_CheckBox.Enabled = false;
				CC_CheckBox.Checked = false;
			}

			if (!Sample.Only_d13C)
			{
				GR_FTC_CheckBox.Enabled = true;
				GR_furnace_CheckBox.Enabled = true;
			}
			else
			{
				GR_FTC_CheckBox.Enabled = false;
				GR_FTC_CheckBox.Checked = false;
				GR_furnace_CheckBox.Enabled = false;
				GR_furnace_CheckBox.Checked = false;
			}

			if (Sample.Take_d13C)
			{
				Vial_loaded_CheckBox.Enabled = true;
				Vial_FTC_CheckBox.Enabled = true;
			}
			else
			{
				Vial_loaded_CheckBox.Enabled = false;
				Vial_loaded_CheckBox.Checked = false;
				Vial_FTC_CheckBox.Enabled = false;
				Vial_FTC_CheckBox.Checked = false;
			}

			if (Air_Valve_CheckBox.Enabled)
			{
				Air_Valve_CheckBox.Visible = true;
				CC_CheckBox.Visible = false;
			}
			else
			{
				Air_Valve_CheckBox.Visible = false;
				CC_CheckBox.Visible = true;
			}

			EnableDisableOK();
		}

		#region Sample Info Text boxes

		int TextToInt(string s)
		{
			int i;
			int.TryParse(s, out i);
			return i;
		}

		double TextToDouble(string s)
		{
			double d;
			double.TryParse(s, out d);
			return d;
		}

		void SampleSourceComboBoxChanged(object sender, EventArgs e)
		{
			Sample.Source = (SampleSources)(sender as ComboBox).SelectedItem;
			PopulateProcessOptions();
			CheckSampleLoaded();
			EnableCheckBoxes();
		}

		void ProcessComboBoxChanged(object sender, EventArgs e)
		{
			Sample.Process = (string)(sender as ComboBox).SelectedItem;
			CheckSampleLoaded();
			EnableCheckBoxes();
		}

		void LeaveSampleIDTextBox(object sender, EventArgs e)
		{
			string id = (sender as TextBox).Text;
			if (Sample.ID != id)
			{
				Sample.ID = id;
				Only_d13C_CheckBox.Checked = false;
			}
		}

		void UpdateSampleMassTextBox()
		{ SampleMassTextBox.Text = Sample.grams.ToString("0.000000"); }

		void LeaveSampleMassTextBox(object sender, EventArgs e)
		{
			Sample.grams = TextToDouble((sender as TextBox).Text);
			UpdateSampleMassTextBox();
		}


		void LeaveFiltrationsTextBox(object sender, EventArgs e)
		{
			Sample.Filtrations = TextToInt((sender as TextBox).Text);
			FiltrationsTextBox.Text = Sample.Filtrations.ToString();
		}

		void OneKeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox tb = sender as TextBox; if (tb == null) return;
			string valid_keys = "";
			if (tb == FiltrationsTextBox)
				valid_keys = "13579";
			else	// if (tb == SampleAliquotsTextBox)
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

		void LeaveSampleAliquotsTextBox(object sender, EventArgs e)
		{ Sample.nAliquots = TextToInt(((TextBox)sender).Text); }
				
		#endregion Sample Info Text boxes

		void SulfurSuspectedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Sample.SulfurSuspected = SulfurSuspectedCheckBox.Checked;
		}

		void Take_d13C_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Sample.Take_d13C = Take_d13C_CheckBox.Checked;
			if (Take_d13C_CheckBox.Checked)
				Only_d13C_CheckBox.Enabled = true;
			else
			{
				Sample.Only_d13C = false;
				Only_d13C_CheckBox.Enabled = false;
				Only_d13C_CheckBox.Checked = false;
			}
			EnableCheckBoxes();
		}

		void Only_d13C_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Sample.Only_d13C = Only_d13C_CheckBox.Checked;
			EnableCheckBoxes();
		}

		void NotifyCC_S_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Sample.NotifyCC_S = NotifyCC_S_CheckBox.Checked;
			if (NotifyCC_S_CheckBox.Checked)
				CC_CheckBox.Text = "Quartz combustion chamber furnace is in place";
			else
				CC_CheckBox.Text = "Combustion chamber furnaces are in place";
		}

		void Sample_loaded_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Sample_loaded_CheckBox.Checked)
			{
				/*if (Sample.Source == SampleSources.BreaksealPort)
					CEGS.BP.State = LinePort.States.Loaded;
				else */
				if (Sample.Source != SampleSources.CO2Supply)
					CEGS.IP.State = LinePort.States.Loaded;
			}
			CheckBoxListItem_CheckedChanged(sender, e);
		}

		void Vial_loaded_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Vial_loaded_CheckBox.Checked)
			{
				if (CEGS.VP.State != LinePort.States.Prepared)
					CEGS.VP.State = LinePort.States.Loaded;
			}
			CheckBoxListItem_CheckedChanged(sender, e);
		}

		void CheckBoxListItem_CheckedChanged(object sender, EventArgs e)
		{
			EnableDisableOK();
		}

		void EnableDisableOK()
		{
			if (RunSample)
			{
				foreach (CheckBox c in CheckBoxPanel.Controls)
				{
					if (c.Enabled && !c.Checked)
					{
						OK.Enabled = false;
						return;
					}
				}
			}
			OK.Enabled = true;
		}

		void exitKeyHandler(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
			{
				SendKeys.Send("{TAB}");
				e.Handled = true;
			}
		}

		void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			CEGS.Sample = Sample;
			Close();
		}

		void OkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			CEGS.Sample = Sample;
			Close();
		}
	}
}
