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
    public partial class LoginUser : Form
    {
        public LoginUser()
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

        private void LoginUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From LoginUser where AMKA = '" + txtAMKA.Text + "'", Con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            
            if (dt.Rows[0][0].ToString() =="1")
            {
                //login san xristis
                this.Hide();
                UserScreen userScreen = new UserScreen();
                userScreen.Show();
            }
            else
            {
                MessageBox.Show("Λάθος ΑΜΚΑ!Προσπαθείστε ξανά.");
            }
            Con.Close();
        }
    }
}
