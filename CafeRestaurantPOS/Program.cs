using System;
using System.Windows.Forms;
using CafeRestaurantPOS.Forms;
using CafeRestaurantPOS.Services;

namespace CafeRestaurantPOS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize database
            DatabaseService.Initialize();
            
            // Show splash screen
            using (var splash = new SplashForm())
            {
                splash.ShowDialog();
            }
            
            // Check license
            var licenseService = new LicenseService();
            if (!licenseService.IsLicenseValid())
            {
                var licenseForm = new LicenseActivationForm();
                if (licenseForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            
            // Show login form
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
