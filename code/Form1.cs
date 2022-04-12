using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sxediasilogismikoy
{
    public partial class Form1 : Form
    {
        int startpoint = 0; //set timer on progress bar
        public Form1()
        {
            InitializeComponent();
        }

        //set timer on progress bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            bunifuCircleProgressbar1.Value = startpoint;
            if(bunifuCircleProgressbar1.Value == 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                LoginSelection Myloginselection = new LoginSelection();
                this.Hide();
                Myloginselection.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start(); 
        }
    }
}
