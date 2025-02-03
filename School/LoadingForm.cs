using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace School
{

    public partial class LoadingForm : Form
    {
        private Timer timer;

        public LoadingForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 20; 
            timer.Tick += Timer_Tick;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0; 
            timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1; 
            }
            else
            {
                timer.Stop();
                LoginForm lg_form = new LoginForm(this);
                lg_form.Show();
                this.Hide(); 
               
            }
        }
    }
}
