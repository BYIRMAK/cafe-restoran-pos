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
            InitializeMenuBar();
            LoadDashboard();
        }

        private void InitializeMenuBar()
        {
            MenuStrip menuStrip = new MenuStrip();
            menuStrip.BackColor = ColorTranslator.FromHtml("#2D2D30");
            menuStrip.ForeColor = Color.White;
            menuStrip.Dock = DockStyle.Top;
            
            // Yardım (Help) menu
            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Yardım");
            mnuHelp.ForeColor = Color.White;
            
            ToolStripMenuItem mnuAbout = new ToolStripMenuItem("Hakkında");
            mnuAbout.ForeColor = Color.White;
            mnuAbout.Click += (s, e) =>
            {
                using (AboutForm aboutForm = new AboutForm())
                {
                    aboutForm.ShowDialog(this);
                }
            };
            
            mnuHelp.DropDownItems.Add(mnuAbout);
            menuStrip.Items.Add(mnuHelp);
            
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
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
