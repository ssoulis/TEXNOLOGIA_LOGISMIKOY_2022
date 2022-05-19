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
using System.IO;
namespace sxediasilogismikoy
{
    public partial class UserScreenHistoryv2 : Form
    {
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from DoctorDiagnosis where AMKA = '" + UserLogAMKA.userAMKA + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                diagnosis.Text = dr["diagnosis"].ToString();
                name.Text = dr["doctor_name"].ToString();
               


                diagnosis.Visible = true;
                name.Visible = true;
               


            }


            Con.Close();
        }
        public UserScreenHistoryv2()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreenHistory userScreenHistory = new UserScreenHistory();
            userScreenHistory.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreen userScreen = new UserScreen();
            userScreen.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreenHistoryv2 userScreenHistoryv2 = new UserScreenHistoryv2();
            userScreenHistoryv2.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreenHistory userScreenHistory = new UserScreenHistory();
            userScreenHistory.Show();
        }

        private void UserScreenHistoryv2_Load(object sender, EventArgs e)
        {
            fetchempdata();
        }
    }
}
