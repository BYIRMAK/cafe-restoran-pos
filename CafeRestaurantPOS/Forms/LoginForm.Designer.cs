using CafeRestaurantPOS.Controls;

namespace CafeRestaurantPOS.Forms
{
    partial class LoginForm
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
            this.cardPanel = new ModernCard();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new ModernTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new ModernTextBox();
            this.btnLogin = new ModernButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Title = "Login";
            // 
            // cardPanel
            // 
            this.cardPanel.Controls.Add(this.lblTitle);
            this.cardPanel.Controls.Add(this.lblUsername);
            this.cardPanel.Controls.Add(this.txtUsername);
            this.cardPanel.Controls.Add(this.lblPassword);
            this.cardPanel.Controls.Add(this.txtPassword);
            this.cardPanel.Controls.Add(this.btnLogin);
            this.cardPanel.Controls.Add(this.lblStatus);
            this.cardPanel.Controls.Add(this.lblInfo);
            this.cardPanel.Location = new System.Drawing.Point(75, 80);
            this.cardPanel.Size = new System.Drawing.Size(450, 420);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.lblTitle.Location = new System.Drawing.Point(180, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 37);
            this.lblTitle.Text = "Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(50, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 19);
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(50, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 40);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(50, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 19);
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(350, 40);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(145, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 45);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(50, 335);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(350, 20);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(50, 365);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(350, 35);
            this.lblInfo.Text = "Default credentials:\nUsername: admin | Password: admin123";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.cardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private ModernTitleBar titleBar;
        private ModernCard cardPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private ModernTextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private ModernTextBox txtPassword;
        private ModernButton btnLogin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInfo;
    }
}
