using System;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    public partial class SplashScreenForm : Form
    {
        Timer timer = new Timer();

        public SplashScreenForm()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
        }
    }
}
