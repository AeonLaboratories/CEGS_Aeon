using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Threading;


namespace CEGS_Aeon_Namespace
{
    public class CustomGroupBox : GroupBox
    {
		public enum TextAlignValue { Left, Center, Right }

		Color BorderColor_ = Color.WhiteSmoke;
		public Color BorderColor
		{
			get { return BorderColor_; }
			set { BorderColor_ = value; OnBorderColorChanged(new EventArgs()); }
		}
		
		TextAlignValue TextAlign_ = TextAlignValue.Left;
		public TextAlignValue TextAlign
		{
			get { return TextAlign_; }
			set { TextAlign_ = value; OnTextAlignChanged(new EventArgs()); }
		}

        public CustomGroupBox() : base() { }

		protected void OnBorderColorChanged(EventArgs e)
		{
			this.Invalidate();
		}

		protected void OnTextAlignChanged(EventArgs e)
		{
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			SizeF sizeOfText;
			using (Graphics g = this.CreateGraphics())
			{
				sizeOfText = g.MeasureString(Text, Font);
			}

			Point textLocation = new Point(7, 0);

			if (TextAlign == TextAlignValue.Center)
				textLocation.Offset((this.ClientRectangle.Width / 2) - 7 - (int)(sizeOfText.Width / 2), 0);
			else if (TextAlign == TextAlignValue.Right)
				textLocation.Offset(this.ClientRectangle.Width - 14 - (int)sizeOfText.Width, 0);
			
			#region Border
			Pen borderPen = new Pen(BorderColor, 1);
			
			Rectangle border = new Rectangle(
				ClientRectangle.Left + Margin.Left - 2,
				ClientRectangle.Top + Margin.Top + 4,
				ClientRectangle.Width - Margin.Left - Margin.Right + 4,
				ClientRectangle.Height - Margin.Top - Margin.Bottom - 2);

			e.Graphics.DrawRectangle(borderPen, border);
			#endregion Border

			#region Draw Caption
			e.Graphics.FillRectangle(new SolidBrush(BackColor), textLocation.X - 1, textLocation.Y - 1, sizeOfText.Width + 2, sizeOfText.Height + 2);
			e.Graphics.DrawString(Text, Font, Brushes.Black, textLocation);
			#endregion Draw Caption
		}
    }
}
