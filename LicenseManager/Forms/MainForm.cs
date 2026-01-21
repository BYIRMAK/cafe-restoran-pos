using System;
using System.Drawing;
using System.Windows.Forms;
using LicenseManager.Models;
using LicenseManager.Services;

namespace LicenseManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadLicenses();
        }

        private void LoadCustomers()
        {
            dgvCustomers.Rows.Clear();
            var customers = DatabaseService.GetAllCustomers();

            foreach (var customer in customers)
            {
                dgvCustomers.Rows.Add(
                    customer.Id,
                    customer.BusinessName,
                    customer.ContactPerson,
                    customer.Email,
                    customer.Phone,
                    customer.CreatedAt.ToString("yyyy-MM-dd")
                );
            }
        }

        private void LoadLicenses()
        {
            dgvLicenses.Rows.Clear();
            var licenses = DatabaseService.GetAllLicenses();

            foreach (var license in licenses)
            {
                dgvLicenses.Rows.Add(
                    license.Id,
                    license.CustomerName,
                    license.DeviceId.Substring(0, 16) + "...",
                    license.GeneratedAt.ToString("yyyy-MM-dd"),
                    license.ExpiresAt.ToString("yyyy-MM-dd"),
                    license.IsActive ? "Active" : "Inactive"
                );
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void btnGenerateLicense_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer first", "No Customer Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            var form = new LicenseGeneratorForm(customerId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadLicenses();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadLicenses();
        }
    }
}
