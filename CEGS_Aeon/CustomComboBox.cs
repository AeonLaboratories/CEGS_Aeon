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
    public class CustomComboBox : ComboBox
    {
        public CustomComboBox() : base()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        //protected override void OnDropDown(EventArgs e)
        //{
            //base.OnDropDown(e);
        //}

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            KeyValuePair<string, ThreadStart> item =
                (KeyValuePair<string, ThreadStart>)Items[e.Index];

            string text = item.Key;
            bool add_separator = text.Substring(text.Length - 1, 1) == "_";
            if (add_separator) text = text.Substring(0, text.Length - 1);

            int y = e.Bounds.Y + e.Bounds.Height -1;

            e.DrawBackground();

//            if (e.State == DrawItemState.HotLight)
//                e.DrawFocusRectangle();


            //if (e.State == DrawItemState.Selected)
            //    e.Graphics.DrawString(text, e.Font, Brushes.Red, e.Bounds);
            //else
                e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), e.Bounds);

            if (add_separator && DroppedDown)
                e.Graphics.DrawLine(SystemPens.ControlText, e.Bounds.X, y, e.Bounds.Right, y);

            base.OnDrawItem(e);

        }

        /*
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DroppedDown)
                ButtonRenderer.DrawButton(CreateGraphics(),
                    new System.Drawing.Rectangle(
                        ClientRectangle.X - 1, ClientRectangle.Y - 1,
                        ClientRectangle.Width + 2, ClientRectangle.Height + 2),
                        PushButtonState.Pressed);
            else
                ButtonRenderer.DrawButton(CreateGraphics(),
                    new System.Drawing.Rectangle(
                        ClientRectangle.X - 1, ClientRectangle.Y - 1,
                        ClientRectangle.Width + 2, ClientRectangle.Height + 2),
                        PushButtonState.Normal);

            if (SelectedIndex != -1)
            {
                string text = SelectedItem.ToString();
                bool add_separator = text.Substring(text.Length - 1, 1) == "e";
                if (add_separator) text = text.Substring(0, text.Length - 1);

                e.Graphics.DrawString(text, Font, Brushes.Black, 3, 3);
            }
            //if (DroppedDown)
            //    this.CreateGraphics().DrawImageUnscaled(new Bitmap("c:\\ArrowBlue.png"), ClientRectangle.Width - 13, ClientRectangle.Height - 12);
            //else
            //    this.CreateGraphics().DrawImageUnscaled(new Bitmap("c:\\ArrowGray.png"), ClientRectangle.Width - 13, ClientRectangle.Height - 12);

        }
    */
    }
}
