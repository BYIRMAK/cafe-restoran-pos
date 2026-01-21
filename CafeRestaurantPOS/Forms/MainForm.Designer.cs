using CafeRestaurantPOS.Controls;

namespace CafeRestaurantPOS.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titleBar = new ModernTitleBar();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnOrders = new ModernButton();
            this.btnMenu = new ModernButton();
            this.btnTables = new ModernButton();
            this.btnReports = new ModernButton();
            this.btnSettings = new ModernButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.cardWelcome = new ModernCard();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Title = "Cafe Restaurant POS - Dashboard";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Controls.Add(this.btnTables);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 40);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 660);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(20, 30);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(160, 50);
            this.btnOrders.Text = "📋 Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(20, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(160, 50);
            this.btnMenu.Text = "🍽️ Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTables
            // 
            this.btnTables.Location = new System.Drawing.Point(20, 170);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(160, 50);
            this.btnTables.Text = "🪑 Tables";
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(20, 240);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(160, 50);
            this.btnReports.Text = "📊 Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(20, 310);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(160, 50);
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelContent.Controls.Add(this.cardWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            this.panelContent.Size = new System.Drawing.Size(1000, 660);
            // 
            // cardWelcome
            // 
            this.cardWelcome.Controls.Add(this.lblWelcome);
            this.cardWelcome.Controls.Add(this.lblDate);
            this.cardWelcome.Location = new System.Drawing.Point(50, 50);
            this.cardWelcome.Size = new System.Drawing.Size(900, 200);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.lblWelcome.Location = new System.Drawing.Point(40, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(500, 45);
            this.lblWelcome.Text = "Welcome to Cafe Restaurant POS";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(40, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(300, 25);
            this.lblDate.Text = "Monday, January 01, 2024";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Restaurant POS";
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.cardWelcome.ResumeLayout(false);
            this.cardWelcome.PerformLayout();
            this.ResumeLayout(false);
        }

        private ModernTitleBar titleBar;
        private System.Windows.Forms.Panel panelSidebar;
        private ModernButton btnOrders;
        private ModernButton btnMenu;
        private ModernButton btnTables;
        private ModernButton btnReports;
        private ModernButton btnSettings;
        private System.Windows.Forms.Panel panelContent;
        private ModernCard cardWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDate;
    }
}
