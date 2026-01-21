using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CafeRestaurantPOS.Controls
{
    public class ModernTitleBar : Panel
    {
        private Form parentForm;
        private Label titleLabel;
        private Button closeButton;
        private Button minimizeButton;
        private bool isDragging = false;
        private Point dragStartPoint;

        public string Title
        {
            get => titleLabel.Text;
            set => titleLabel.Text = value;
        }

        public ModernTitleBar()
        {
            Height = 40;
            BackColor = ColorTranslator.FromHtml("#FF6B6B");
            Dock = DockStyle.Top;

            titleLabel = new Label
            {
                Text = "Cafe Restaurant POS",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(15, 0),
                Size = new Size(300, 40)
            };

            closeButton = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(40, 40),
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            };
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 107, 107);
            closeButton.Click += (s, e) => parentForm?.Close();

            minimizeButton = new Button
            {
                Text = "−",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(40, 40),
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            };
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 107, 107);
            minimizeButton.Click += (s, e) => { if (parentForm != null) parentForm.WindowState = FormWindowState.Minimized; };

            Controls.Add(titleLabel);
            Controls.Add(closeButton);
            Controls.Add(minimizeButton);

            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
            MouseUp += OnMouseUp;
            titleLabel.MouseDown += OnMouseDown;
            titleLabel.MouseMove += OnMouseMove;
            titleLabel.MouseUp += OnMouseUp;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            parentForm = FindForm();
            if (parentForm != null)
            {
                parentForm.Resize += (s, args) => PositionButtons();
                PositionButtons();
            }
        }

        private void PositionButtons()
        {
            if (parentForm == null) return;

            closeButton.Location = new Point(parentForm.ClientSize.Width - 40, 0);
            minimizeButton.Location = new Point(parentForm.ClientSize.Width - 80, 0);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = e.Location;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && parentForm != null)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point newFormPos = new Point(
                    currentScreenPos.X - dragStartPoint.X,
                    currentScreenPos.Y - dragStartPoint.Y
                );
                parentForm.Location = newFormPos;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
