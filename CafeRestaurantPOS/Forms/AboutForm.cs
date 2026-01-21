using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeRestaurantPOS.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void lblSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText("05521650435");
                MessageBox.Show(
                    "Telefon numarası kopyalandı!\n\n📞 0 552 165 04 35\n\nLisans satın alma ve destek için arayabilirsiniz.",
                    "Destek İletişim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Telefon numarası kopyalanamadı. Lütfen manuel olarak not edin:\n\n📞 0 552 165 04 35",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
