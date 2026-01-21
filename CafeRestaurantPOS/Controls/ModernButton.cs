using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CafeRestaurantPOS.Controls
{
    public class ModernButton : Button
    {
        private Color normalColor = ColorTranslator.FromHtml("#FF6B6B");
        private Color hoverColor = ColorTranslator.FromHtml("#FF5252");
        private Color pressedColor = ColorTranslator.FromHtml("#E85A5A");
        private int borderRadius = 10;
        private bool isHovering = false;
        private bool isPressed = false;

        public Color NormalColor
        {
            get => normalColor;
            set { normalColor = value; Invalidate(); }
        }

        public Color HoverColor
        {
            get => hoverColor;
            set { hoverColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = normalColor;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            Size = new Size(120, 40);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovering = true;
            BackColor = hoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovering = false;
            isPressed = false;
            BackColor = normalColor;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            isPressed = true;
            BackColor = pressedColor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            isPressed = false;
            BackColor = isHovering ? hoverColor : normalColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = GetRoundedRectangle(ClientRectangle, borderRadius);
            Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                g.FillPath(brush, path);
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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
    }
}
