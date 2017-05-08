using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using HACS.Components;

namespace CEGS_Aeon_Namespace
{
	public partial class ModifyParameterizedStep : Form
	{
		public ProcessSequenceStep Step;
		bool InvalidStep;

		public ModifyParameterizedStep()
		{
			InitializeComponent();
		}

		public ModifyParameterizedStep(ProcessSequenceStep step) : this()
		{
			Step = step;
			Text = "Modify " + Step.GetType().Name;
			PopulateForm();
		}

		public void PopulateForm()
		{
			int fieldCount = Step.GetType().GetFields().Count();
			if (fieldCount == 0)
			{
				InvalidStep = true;
				return;
			}
			FieldInfo[] fields = new FieldInfo[fieldCount];

			int counter = 0;
			foreach (FieldInfo field in Step.GetType().GetFields())
			{
				if (field.Name.Equals("Name"))
				{
					if (fieldCount == 1)
					{
						InvalidStep = true;
						return;
					}
					for (int i = fieldCount - 2; i >= 0; i--)
						fields[i + 1] = fields[i];
					fields[0] = field;
				}
				else
					fields[counter] = field;
				counter++;
			}

			Point location = new Point(0, 10);

			foreach (FieldInfo field in fields)
			{
				Label Name = new Label();
				Name.Text = field.Name;
				Name.Location = location;
				Controls.Add(Name);

				Type fieldType = field.FieldType;

				if (fieldType == typeof(int) ||
				fieldType == typeof(double) ||
				fieldType == typeof(string) ||
				fieldType == typeof(long))
				{
					location.Offset(100, -3);
					TextBox Value = new TextBox();
					Value.Text = field.GetValue(Step).ToString();
					Value.Tag = field;
					Value.Location = location;
					Value.Width = 130;
					//Value.KeyPress += new KeyPressEventHandler(exitKeyHandler);
					Controls.Add(Value);
					location.Offset(-100, 33);
				}
				else
				{
					location.Offset(100, -4);
					ComboBox Value = new ComboBox();
					Value.DropDownStyle = ComboBoxStyle.DropDownList;
					Value.FormattingEnabled = true;
					//Value.TabStop = false;
					if (fieldType == typeof(bool))
					{
						Value.Items.Add("No");
						Value.Items.Add("Yes");
						Value.SelectedIndex = (bool)field.GetValue(Step) ? 1 : 0;
					}
					else if (fieldType.IsEnum)
					{
						foreach (object o in Enum.GetValues(fieldType))
							Value.Items.Add(o);
						Value.SelectedItem = field.GetValue(Step);
					}
					Value.Tag = field;
					Value.Location = location;
					Value.Width = 130;
					Controls.Add(Value);
					location.Offset(-100, 34);
				}
			}
			location.Offset(0, -12);

			Panel overflow = new Panel();
			overflow.Height = ButtonPanel.Height;
			overflow.Location = location;
			Controls.Add(overflow);
		}

		void SaveSettings()
		{
			foreach (Control c in Controls)
			{
				FieldInfo field = (FieldInfo)(c as Control).Tag;
				if (field == null)
					continue;

				Type fieldType = field.FieldType;
				object newValue;
				if (c is TextBox)
				{
					try
					{
						string contents = (c as TextBox).Text;
						if (fieldType == typeof(int))
							newValue = int.Parse(contents);
						else if (fieldType == typeof(double))
							newValue = double.Parse(contents);
						else if (fieldType == typeof(long))
							newValue = long.Parse(contents);
						else
							newValue = contents;
						field.SetValue(Step, newValue);
					}
					catch (Exception error) { MessageBox.Show(error.ToString()); }
				}
				else if (c is ComboBox)
				{
					try
					{
						if (fieldType == typeof(bool))
							newValue = (c as ComboBox).SelectedIndex == 1 ? true : false;
						else
							newValue = Enum.Parse(fieldType, (c as ComboBox).Text);
						field.SetValue(Step, newValue);
					}
					catch (Exception error) { MessageBox.Show(error.ToString()); }
				}
			}
		}

		private void ModifyParameterizedStep_Shown(object sender, EventArgs e)
		{
			if (InvalidStep)
				Close();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			SaveSettings();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
