using System;
using System.Drawing;
using System.Windows.Forms;
using CafeRestaurantPOS.Controls;

namespace CafeRestaurantPOS.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            lblWelcome.Text = "Welcome to Cafe Restaurant POS";
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orders module will be implemented in Phase 2", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu management will be implemented in Phase 2", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table management will be implemented in Phase 2", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports will be implemented in Phase 2", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings will be implemented in Phase 2", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
