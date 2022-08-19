using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace AppForTwitch
{
    class Toggle_Button : CheckBox
    {
        private Color onBackBorderColor = Color.MediumOrchid;
        private Color onToggleColor = Color.DarkViolet;
        private Color offBackBorderColor = SystemColors.Window;
        private Color offToggleColor = SystemColors.WindowFrame;
        private bool solidStyle = true;

        public Color OnBackBorderColor { get => onBackBorderColor; set { onBackBorderColor = value; this.Invalidate(); } }
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        public Color OffBackBorderColor { get => offBackBorderColor; set { offBackBorderColor = value; this.Invalidate(); } }
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }
        [DefaultValue(true)]
        public bool SolidStyle { get => solidStyle; set { solidStyle = value; this.Invalidate(); } }

        public override string Text { get => base.Text; set { } }

        public Toggle_Button()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if (this.Checked) //ON
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackBorderColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackBorderColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                  new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackBorderColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackBorderColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                  new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
