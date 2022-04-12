using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sxediasilogismikoy
{
    public partial class LoginDoctor : Form
    {
        public LoginDoctor()
        {
            InitializeComponent();
        }
       SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            //epistrofi sto LoginSelection
            this.Hide();
            LoginSelection loginSelection = new LoginSelection();
            loginSelection.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From LoginDoctor where username = '" + txtusername.Text + "' and password ='" + txtpassword.Text + "'", Con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                //login san giatros
                this.Hide();
                DoctorScreen doctorScreen = new DoctorScreen();
                doctorScreen.Show();
            }
            else
            {
                MessageBox.Show("Λάθος όνομα και κωδίκος!Προσπαθείστε ξανά.");
            }
            Con.Close();
        }
    }
}
