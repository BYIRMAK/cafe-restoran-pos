using System;
using System.Windows.Forms;
using LicenseManager.Models;
using LicenseManager.Services;

namespace LicenseManager.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusinessName.Text))
            {
                MessageBox.Show("Please enter business name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContactPerson.Text))
            {
                MessageBox.Show("Please enter contact person name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var customer = new Customer
                {
                    BusinessName = txtBusinessName.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                DatabaseService.AddCustomer(customer);

                MessageBox.Show("Customer added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
