using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForTwitch.User_Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class Rounded_Textbox : UserControl
    {
        private Color borderColor = SystemColors.ScrollBar;
        private int borderSize = 2;
        private Color borderFocusColor = Color.MediumOrchid;
        private bool isFocused = false;
        private int borderRadius = 0;


        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        public bool Multiline
        {
            get { return textBox.Multiline; }
            set { textBox.Multiline = value; }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox.BackColor = value; }
        }

        public override Color ForeColor 
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; textBox.ForeColor = value; }
        }
        public override Font Font
        {
            get { return base.Font; }
            set 
            { 
                base.Font = value;
                textBox.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        public string Texts
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public HorizontalAlignment TextsAlign
        {
            get => textBox.TextAlign;
            set => textBox.TextAlign = value;
        }
        public int MaxTextLength
        {
            get => textBox.MaxLength;
            set => textBox.MaxLength = value;
        }

        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        public int BorderRadius
        {
            get => borderRadius;
            set 
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        public Rounded_Textbox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (BorderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize + 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15)
                        SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;

                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused)
                        penBorder.Color = borderFocusColor;
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused)
                        penBorder.Color = borderFocusColor;
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox.ClientRectangle, BorderRadius - borderRadius);
                textBox.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox.ClientRectangle, borderRadius*2);
                textBox.Region = new Region(pathTxt);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, txtHeight);
                textBox.Multiline = false;

                this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
