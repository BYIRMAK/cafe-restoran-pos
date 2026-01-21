using System;
using System.Windows.Forms;
using LicenseManager.Models;
using LicenseManager.Services;

namespace LicenseManager.Forms
{
    public partial class LicenseGeneratorForm : Form
    {
        private int customerId;

        public LicenseGeneratorForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadCustomerInfo();
        }

        private void LoadCustomerInfo()
        {
            var customer = DatabaseService.GetCustomerById(customerId);
            if (customer != null)
            {
                lblCustomerInfo.Text = $"Customer: {customer.BusinessName}\nContact: {customer.ContactPerson}";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeviceId.Text))
            {
                MessageBox.Show("Please enter Device ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string deviceId = txtDeviceId.Text.Trim();
                int validityDays = (int)numValidityDays.Value;
                DateTime expiryDate = DateTime.Now.AddDays(validityDays);

                string signature = GenerateSignature(deviceId, expiryDate);
                string licenseData = $"{deviceId}|{expiryDate:yyyy-MM-dd}|{signature}";
                string licenseKey = EncryptionService.Encrypt(licenseData);

                var license = new License
                {
                    CustomerId = customerId,
                    LicenseKey = licenseKey,
                    DeviceId = deviceId,
                    GeneratedAt = DateTime.Now,
                    ExpiresAt = expiryDate,
                    IsActive = true
                };

                DatabaseService.SaveLicense(license);

                txtLicenseKey.Text = licenseKey;
                btnCopy.Enabled = true;

                MessageBox.Show("License generated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating license: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateSignature(string deviceId, DateTime expiryDate)
        {
            string data = $"{deviceId}{expiryDate:yyyy-MM-dd}";
            return HashString(data);
        }

        private string HashString(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLicenseKey.Text))
            {
                Clipboard.SetText(txtLicenseKey.Text);
                MessageBox.Show("License key copied to clipboard!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
