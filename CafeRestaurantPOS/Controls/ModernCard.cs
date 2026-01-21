using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CafeRestaurantPOS.Controls
{
    public class ModernCard : Panel
    {
        private int borderRadius = 15;
        private Color shadowColor = Color.FromArgb(30, 0, 0, 0);
        private int shadowDepth = 5;

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public Color ShadowColor
        {
            get => shadowColor;
            set { shadowColor = value; Invalidate(); }
        }

        public int ShadowDepth
        {
            get => shadowDepth;
            set { shadowDepth = value; Invalidate(); }
        }

        public ModernCard()
        {
            BackColor = Color.White;
            Padding = new Padding(20);
            Size = new Size(300, 200);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle shadowRect = new Rectangle(shadowDepth, shadowDepth, Width - shadowDepth, Height - shadowDepth);
            using (GraphicsPath shadowPath = GetRoundedRectangle(shadowRect, borderRadius))
            {
                using (PathGradientBrush shadowBrush = new PathGradientBrush(shadowPath))
                {
                    shadowBrush.CenterColor = shadowColor;
                    shadowBrush.SurroundColors = new Color[] { Color.Transparent };
                    g.FillPath(shadowBrush, shadowPath);
                }
            }

            Rectangle cardRect = new Rectangle(0, 0, Width - shadowDepth - 1, Height - shadowDepth - 1);
            using (GraphicsPath cardPath = GetRoundedRectangle(cardRect, borderRadius))
            {
                Region = new Region(cardPath);

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillPath(brush, cardPath);
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
    }
}
