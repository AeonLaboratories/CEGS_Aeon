using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CEGS_Aeon_Namespace
{
	public class CustomListBox : ListBox
	{
		public CustomListBox() : base()
		{
			DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			if (e.Index < 0) return;
			if (Items.Count <= 0) return;

			string text = Items[e.Index].ToString();
			bool add_separator = text.Substring(text.Length - 1, 1) == "_";
			if (add_separator) text = text.Substring(0, text.Length - 1);

			int y = e.Bounds.Y + e.Bounds.Height - 1;

			e.DrawBackground();

			e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), e.Bounds);

			if (add_separator)
				e.Graphics.DrawLine(SystemPens.ControlText, e.Bounds.X, y, e.Bounds.Right, y);

			base.OnDrawItem(e);
		}
	}
}
