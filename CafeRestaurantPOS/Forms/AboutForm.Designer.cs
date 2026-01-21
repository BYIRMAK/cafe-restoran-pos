namespace CafeRestaurantPOS.Forms
{
    partial class AboutForm
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
            this.logoPanel = new System.Windows.Forms.Panel();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblSupport = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF8C42");
            this.logoPanel.Controls.Add(this.lblLogoText);
            this.logoPanel.Controls.Add(this.lblLogoSub);
            this.logoPanel.Location = new System.Drawing.Point(25, 20);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(450, 150);
            this.logoPanel.TabIndex = 0;
            // 
            // lblLogoText
            // 
            this.lblLogoText.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(0, 20);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(450, 70);
            this.lblLogoText.TabIndex = 0;
            this.lblLogoText.Text = "🍽️ Menü Soft";
            this.lblLogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.White;
            this.lblLogoSub.Location = new System.Drawing.Point(0, 90);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(450, 30);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "Cafe Restoran Satış Sistemleri";
            this.lblLogoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3436");
            this.lblVersion.Location = new System.Drawing.Point(175, 190);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(150, 30);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versiyon 1.0.0";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.ColorTranslator.FromHtml("#636E72");
            this.lblDescription.Location = new System.Drawing.Point(25, 230);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(450, 60);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Modern, Hızlı ve Güvenilir POS Çözümü\r\nOffline çalışma, güvenli lisanslama ve kullanıcı dostu arayüz";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFeatures
            // 
            this.lblFeatures.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFeatures.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3436");
            this.lblFeatures.Location = new System.Drawing.Point(150, 300);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(450, 80);
            this.lblFeatures.TabIndex = 3;
            this.lblFeatures.Text = "✅ Modern UI Tasarım\r\n✅ AES-256 Şifreleme\r\n✅ SQLite Veritabanı\r\n✅ Cihaz Bazlı Lisanslama";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCopyright.ForeColor = System.Drawing.ColorTranslator.FromHtml("#636E72");
            this.lblCopyright.Location = new System.Drawing.Point(140, 395);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(220, 15);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "© 2026 Menü Soft - Tüm hakları saklıdır.";
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSupport.LinkColor = System.Drawing.ColorTranslator.FromHtml("#FF8C42");
            this.lblSupport.Location = new System.Drawing.Point(155, 425);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(190, 20);
            this.lblSupport.TabIndex = 5;
            this.lblSupport.TabStop = true;
            this.lblSupport.Text = "📞 Destek: 0 552 165 04 35";
            this.lblSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSupport_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.ColorTranslator.FromHtml("#95A5A6");
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(190, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F8F9FA");
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSupport);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hakkında - Menü Soft";
            this.logoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel lblSupport;
        private System.Windows.Forms.Button btnClose;
    }
}
