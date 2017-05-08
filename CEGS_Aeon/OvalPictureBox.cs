using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class OvalPictureBox : PictureBox
{
	public OvalPictureBox() { }
	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		using (var gp = new GraphicsPath())
		{
			// using fractional floats instead of ints to fix bug with extra pixels showing up
			gp.AddEllipse(0.2F, 0.2F, this.Width - 1.4F, this.Height - 1.4F);
			this.Region = new Region(gp);
		}
	}
}