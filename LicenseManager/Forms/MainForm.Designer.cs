namespace LicenseManager.Forms
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.colCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tabLicenses = new System.Windows.Forms.TabPage();
            this.dgvLicenses = new System.Windows.Forms.DataGridView();
            this.colLicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeneratedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiresAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateLicense = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "License Manager - Cafe Restaurant POS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCustomers);
            this.tabControl.Controls.Add(this.tabLicenses);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(20, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 500);
            this.tabControl.TabIndex = 1;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Controls.Add(this.btnAddCustomer);
            this.tabCustomers.Location = new System.Drawing.Point(4, 28);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(952, 468);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustId,
            this.colBusinessName,
            this.colContactPerson,
            this.colEmail,
            this.colPhone,
            this.colCreatedAt});
            this.dgvCustomers.Location = new System.Drawing.Point(20, 20);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(910, 380);
            this.dgvCustomers.TabIndex = 0;
            // 
            // colCustId
            // 
            this.colCustId.HeaderText = "ID";
            this.colCustId.Name = "colCustId";
            this.colCustId.ReadOnly = true;
            // 
            // colBusinessName
            // 
            this.colBusinessName.HeaderText = "Business Name";
            this.colBusinessName.Name = "colBusinessName";
            this.colBusinessName.ReadOnly = true;
            // 
            // colContactPerson
            // 
            this.colContactPerson.HeaderText = "Contact Person";
            this.colContactPerson.Name = "colContactPerson";
            this.colContactPerson.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Created At";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 415);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(150, 40);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tabLicenses
            // 
            this.tabLicenses.Controls.Add(this.dgvLicenses);
            this.tabLicenses.Controls.Add(this.btnGenerateLicense);
            this.tabLicenses.Location = new System.Drawing.Point(4, 28);
            this.tabLicenses.Name = "tabLicenses";
            this.tabLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicenses.Size = new System.Drawing.Size(952, 468);
            this.tabLicenses.TabIndex = 1;
            this.tabLicenses.Text = "Licenses";
            this.tabLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvLicenses
            // 
            this.dgvLicenses.AllowUserToAddRows = false;
            this.dgvLicenses.AllowUserToDeleteRows = false;
            this.dgvLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLicId,
            this.colCustomerName,
            this.colDeviceId,
            this.colGeneratedAt,
            this.colExpiresAt,
            this.colStatus});
            this.dgvLicenses.Location = new System.Drawing.Point(20, 20);
            this.dgvLicenses.Name = "dgvLicenses";
            this.dgvLicenses.ReadOnly = true;
            this.dgvLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLicenses.Size = new System.Drawing.Size(910, 380);
            this.dgvLicenses.TabIndex = 0;
            // 
            // colLicId
            // 
            this.colLicId.HeaderText = "ID";
            this.colLicId.Name = "colLicId";
            this.colLicId.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Customer";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colDeviceId
            // 
            this.colDeviceId.HeaderText = "Device ID";
            this.colDeviceId.Name = "colDeviceId";
            this.colDeviceId.ReadOnly = true;
            // 
            // colGeneratedAt
            // 
            this.colGeneratedAt.HeaderText = "Generated At";
            this.colGeneratedAt.Name = "colGeneratedAt";
            this.colGeneratedAt.ReadOnly = true;
            // 
            // colExpiresAt
            // 
            this.colExpiresAt.HeaderText = "Expires At";
            this.colExpiresAt.Name = "colExpiresAt";
            this.colExpiresAt.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // btnGenerateLicense
            // 
            this.btnGenerateLicense.BackColor = System.Drawing.Color.FromArgb(255, 107, 107);
            this.btnGenerateLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateLicense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateLicense.ForeColor = System.Drawing.Color.White;
            this.btnGenerateLicense.Location = new System.Drawing.Point(20, 415);
            this.btnGenerateLicense.Name = "btnGenerateLicense";
            this.btnGenerateLicense.Size = new System.Drawing.Size(150, 40);
            this.btnGenerateLicense.TabIndex = 1;
            this.btnGenerateLicense.Text = "Generate License";
            this.btnGenerateLicense.UseVisualStyleBackColor = false;
            this.btnGenerateLicense.Click += new System.EventHandler(this.btnGenerateLicense_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(860, 590);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Manager";
            this.tabControl.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusinessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TabPage tabLicenses;
        private System.Windows.Forms.DataGridView dgvLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneratedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiresAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnGenerateLicense;
        private System.Windows.Forms.Button btnRefresh;
    }
}
