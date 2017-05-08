using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEGS_Aeon_Namespace
{
	public class TransparentPictureBox : PictureBox
	{
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			Graphics g = e.Graphics;

			if (Parent != null)
			{
				int index = Parent.Controls.GetChildIndex(this);
				for (int i = Parent.Controls.Count - 1; i > index; i--)
				{
					Control c = Parent.Controls[i];
					if (c.Visible && c.Bounds.IntersectsWith(Bounds))
					{
						Bitmap bmp = new Bitmap(c.Width, c.Height, g);
						c.DrawToBitmap(bmp, c.ClientRectangle);
						g.TranslateTransform(c.Left - Left, c.Top - Top);
						g.DrawImageUnscaled(bmp, Point.Empty);
						g.TranslateTransform(Left - c.Left, Top - c.Top);
						bmp.Dispose();
					}
				}
			}
		}
	}
}