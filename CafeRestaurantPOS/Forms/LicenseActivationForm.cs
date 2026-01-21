using System;
using System.Drawing;
using System.Windows.Forms;
using CafeRestaurantPOS.Controls;
using CafeRestaurantPOS.Services;

namespace CafeRestaurantPOS.Forms
{
    public partial class LicenseActivationForm : Form
    {
        private LicenseService licenseService;

        public LicenseActivationForm()
        {
            InitializeComponent();
            licenseService = new LicenseService();
            
            string deviceId = DeviceService.GetDeviceId();
            txtDeviceId.Text = deviceId;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string licenseKey = txtLicenseKey.Text.Trim();

            if (string.IsNullOrEmpty(licenseKey))
            {
                ShowError("Please enter a license key");
                return;
            }

            if (!licenseService.ValidateLicenseKey(licenseKey))
            {
                ShakeForm();
                ShowError("Invalid license key or device mismatch");
                return;
            }

            try
            {
                licenseService.ActivateLicense(licenseKey);
                MessageBox.Show("License activated successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ShowError($"Error activating license: {ex.Message}");
            }
        }

        private void btnCopyDeviceId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDeviceId.Text);
            lblStatus.Text = "Device ID copied to clipboard!";
            lblStatus.ForeColor = Color.Green;
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
