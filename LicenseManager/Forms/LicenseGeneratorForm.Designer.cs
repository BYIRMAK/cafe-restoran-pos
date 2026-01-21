namespace LicenseManager.Forms
{
    partial class LicenseGeneratorForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblValidityDays = new System.Windows.Forms.Label();
            this.numValidityDays = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblLicenseKey = new System.Windows.Forms.Label();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValidityDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Generate License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerInfo.Location = new System.Drawing.Point(30, 70);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(540, 50);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "Customer: \nContact: ";
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeviceId.Location = new System.Drawing.Point(30, 140);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(73, 19);
            this.lblDeviceId.TabIndex = 2;
            this.lblDeviceId.Text = "Device ID:";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtDeviceId.Location = new System.Drawing.Point(30, 165);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(540, 23);
            this.txtDeviceId.TabIndex = 3;
            // 
            // lblValidityDays
            // 
            this.lblValidityDays.AutoSize = true;
            this.lblValidityDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValidityDays.Location = new System.Drawing.Point(30, 210);
            this.lblValidityDays.Name = "lblValidityDays";
            this.lblValidityDays.Size = new System.Drawing.Size(129, 19);
            this.lblValidityDays.TabIndex = 4;
            this.lblValidityDays.Text = "Validity (Days):";
            // 
            // numValidityDays
            // 
            this.numValidityDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numValidityDays.Location = new System.Drawing.Point(170, 208);
            this.numValidityDays.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numValidityDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numValidityDays.Name = "numValidityDays";
            this.numValidityDays.Size = new System.Drawing.Size(120, 25);
            this.numValidityDays.TabIndex = 5;
            this.numValidityDays.Value = new decimal(new int[] {
            365,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(220, 260);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 40);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate License";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblLicenseKey
            // 
            this.lblLicenseKey.AutoSize = true;
            this.lblLicenseKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicenseKey.Location = new System.Drawing.Point(30, 320);
            this.lblLicenseKey.Name = "lblLicenseKey";
            this.lblLicenseKey.Size = new System.Drawing.Size(140, 19);
            this.lblLicenseKey.TabIndex = 7;
            this.lblLicenseKey.Text = "Generated License Key:";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLicenseKey.Location = new System.Drawing.Point(30, 345);
            this.txtLicenseKey.Multiline = true;
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.ReadOnly = true;
            this.txtLicenseKey.Size = new System.Drawing.Size(540, 80);
            this.txtLicenseKey.TabIndex = 8;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCopy.Enabled = false;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(200, 440);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 35);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(310, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LicenseGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.lblLicenseKey);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numValidityDays);
            this.Controls.Add(this.lblValidityDays);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numValidityDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblValidityDays;
        private System.Windows.Forms.NumericUpDown numValidityDays;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblLicenseKey;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClose;
    }
}
