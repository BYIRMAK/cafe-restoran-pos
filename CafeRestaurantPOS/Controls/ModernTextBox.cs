using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CafeRestaurantPOS.Controls
{
    public class ModernTextBox : Panel
    {
        private TextBox textBox;
        private Color borderColor = ColorTranslator.FromHtml("#E0E0E0");
        private Color focusedBorderColor = ColorTranslator.FromHtml("#FF6B6B");
        private int borderRadius = 8;
        private bool isFocused = false;

        public string PlaceholderText { get; set; }
        public Color PlaceholderColor { get; set; } = Color.Gray;

        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public char PasswordChar
        {
            get => textBox.PasswordChar;
            set => textBox.PasswordChar = value;
        }

        public bool UseSystemPasswordChar
        {
            get => textBox.UseSystemPasswordChar;
            set => textBox.UseSystemPasswordChar = value;
        }

        public ModernTextBox()
        {
            Size = new Size(250, 40);
            BackColor = Color.White;
            Padding = new Padding(10, 8, 10, 8);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10F),
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            textBox.Enter += (s, e) => { isFocused = true; Invalidate(); };
            textBox.Leave += (s, e) => { isFocused = false; Invalidate(); };
            textBox.TextChanged += (s, e) => OnTextChanged(e);

            Controls.Add(textBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), borderRadius))
            {
                Region = new Region(path);

                Color currentBorderColor = isFocused ? focusedBorderColor : borderColor;
                using (Pen pen = new Pen(currentBorderColor, 2))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        public void Focus()
        {
            textBox.Focus();
        }
    }
}
