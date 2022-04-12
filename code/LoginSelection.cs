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
    public partial class LoginSelection : Form
    {
        public LoginSelection()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //login san xristis
            this.Hide();
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //login san giatros
            this.Hide();
            LoginDoctor loginDoctor = new LoginDoctor();
            loginDoctor.Show();
        }
    }
}
