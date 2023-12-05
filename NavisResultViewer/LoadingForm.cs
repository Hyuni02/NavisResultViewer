using ClashTest2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NavisResultViewer
{
    public partial class LoadingForm : Form
    {
        private Timer timer;
        //private int timerCount = 0;

        public LoadingForm()
        {
            InitializeComponent();
            //timer.Tick += new EventHandler(timer_Tick);
            //progressBar1.Style = ProgressBarStyle.Marquee;
            timer = new Timer();
            timer.Interval = 1000;
            //progressBar1.Enabled = true;
            timer.Start();
        }

        public void startLoading()
        {
            
        }

       private void formClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                form1?.Close();
            }
        }
    }
}
