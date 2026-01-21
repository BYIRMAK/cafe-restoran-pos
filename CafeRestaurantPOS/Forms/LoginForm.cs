using System;
using System.Drawing;
using System.Windows.Forms;
using CafeRestaurantPOS.Controls;
using CafeRestaurantPOS.Services;

namespace CafeRestaurantPOS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Please enter username and password");
                return;
            }

            var user = DatabaseService.ValidateUser(username, password);

            if (user == null)
            {
                ShakeForm();
                ShowError("Invalid username or password");
                txtPassword.Text = "";
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShowError(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.Red;
        }

        private void ShakeForm()
        {
            Point originalLocation = Location;
            Timer shakeTimer = new Timer { Interval = 50 };
            int shakeCount = 0;
            int[] offsets = { -10, 10, -8, 8, -5, 5, -2, 2, 0 };

            shakeTimer.Tick += (s, args) =>
            {
                if (shakeCount < offsets.Length)
                {
                    Location = new Point(originalLocation.X + offsets[shakeCount], originalLocation.Y);
                    shakeCount++;
                }
                else
                {
                    shakeTimer.Stop();
                    Location = originalLocation;
                }
            };
            shakeTimer.Start();
        }
    }
}
