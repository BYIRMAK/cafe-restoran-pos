using CafeRestaurantPOS.Controls;

namespace CafeRestaurantPOS.Forms
{
    partial class LicenseActivationForm
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
            this.lblDeviceIdLabel = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.btnCopyDeviceId = new ModernButton();
            this.lblLicenseKey = new System.Windows.Forms.Label();
            this.txtLicenseKey = new ModernTextBox();
            this.btnActivate = new ModernButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Title = "License Activation";
            // 
            // cardPanel
            // 
            this.cardPanel.Controls.Add(this.lblTitle);
            this.cardPanel.Controls.Add(this.lblDeviceIdLabel);
            this.cardPanel.Controls.Add(this.txtDeviceId);
            this.cardPanel.Controls.Add(this.btnCopyDeviceId);
            this.cardPanel.Controls.Add(this.lblLicenseKey);
            this.cardPanel.Controls.Add(this.txtLicenseKey);
            this.cardPanel.Controls.Add(this.btnActivate);
            this.cardPanel.Controls.Add(this.lblStatus);
            this.cardPanel.Location = new System.Drawing.Point(50, 80);
            this.cardPanel.Size = new System.Drawing.Size(500, 400);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.lblTitle.Location = new System.Drawing.Point(120, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 32);
            this.lblTitle.Text = "Activate Your License";
            // 
            // lblDeviceIdLabel
            // 
            this.lblDeviceIdLabel.AutoSize = true;
            this.lblDeviceIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeviceIdLabel.Location = new System.Drawing.Point(40, 90);
            this.lblDeviceIdLabel.Name = "lblDeviceIdLabel";
            this.lblDeviceIdLabel.Size = new System.Drawing.Size(73, 19);
            this.lblDeviceIdLabel.Text = "Device ID:";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtDeviceId.Location = new System.Drawing.Point(40, 115);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(320, 23);
            this.txtDeviceId.TabIndex = 0;
            // 
            // btnCopyDeviceId
            // 
            this.btnCopyDeviceId.Location = new System.Drawing.Point(370, 110);
            this.btnCopyDeviceId.Name = "btnCopyDeviceId";
            this.btnCopyDeviceId.Size = new System.Drawing.Size(90, 35);
            this.btnCopyDeviceId.Text = "Copy";
            this.btnCopyDeviceId.Click += new System.EventHandler(this.btnCopyDeviceId_Click);
            // 
            // lblLicenseKey
            // 
            this.lblLicenseKey.AutoSize = true;
            this.lblLicenseKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicenseKey.Location = new System.Drawing.Point(40, 170);
            this.lblLicenseKey.Name = "lblLicenseKey";
            this.lblLicenseKey.Size = new System.Drawing.Size(87, 19);
            this.lblLicenseKey.Text = "License Key:";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Location = new System.Drawing.Point(40, 195);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(420, 40);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(170, 270);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(160, 45);
            this.btnActivate.Text = "Activate License";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(40, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(420, 40);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LicenseActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.cardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicenseActivationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Activation";
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private ModernTitleBar titleBar;
        private ModernCard cardPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeviceIdLabel;
        private System.Windows.Forms.TextBox txtDeviceId;
        private ModernButton btnCopyDeviceId;
        private System.Windows.Forms.Label lblLicenseKey;
        private ModernTextBox txtLicenseKey;
        private ModernButton btnActivate;
        private System.Windows.Forms.Label lblStatus;
    }
}
