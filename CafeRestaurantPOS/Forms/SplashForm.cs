using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace CafeRestaurantPOS.Forms
{
    public partial class SplashForm : Form
    {
        private Timer fadeTimer;
        private double opacity = 0;

        public SplashForm()
        {
            InitializeComponent();
            Opacity = 0;
            fadeTimer = new Timer { Interval = 20 };
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            opacity += 0.05;
            if (opacity >= 1)
            {
                opacity = 1;
                fadeTimer.Stop();
                Timer closeTimer = new Timer { Interval = 2000 };
                closeTimer.Tick += (s, args) =>
                {
                    closeTimer.Stop();
                    Close();
                };
                closeTimer.Start();
            }
            Opacity = opacity;
        }
    }
}
