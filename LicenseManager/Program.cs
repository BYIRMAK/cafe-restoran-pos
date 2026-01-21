using System;
using System.Windows.Forms;
using LicenseManager.Forms;
using LicenseManager.Services;

namespace LicenseManager
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
            
            Application.Run(new MainForm());
        }
    }
}
