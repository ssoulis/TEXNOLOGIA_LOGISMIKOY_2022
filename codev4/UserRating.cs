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
using sxediasilogismikoy.Properties;

namespace sxediasilogismikoy
{
    public partial class UserRating : Form
    {
        public string ratio { get; set; }
        public UserRating()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void UserRating_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DoctorID,surname from LoginDoctor", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            Con.Close();

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "surname";
            comboBox1.ValueMember = "DoctorID";
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreen userScreen = new UserScreen();
            userScreen.Show();
        }

        private void pb_str1_Click(object sender, EventArgs e)
        {
            pb_str2.Image = Resources.white_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            ratio = "1";
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            ratio = "2";
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            ratio = "3";
        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
          
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            ratio = "4";
        }

        private void pb_str5_Click(object sender, EventArgs e)
        {
           
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            pb_str5.Image = Resources.yellow_star;
            ratio = "5";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UserRatio values('" + comboBox1.Text + "','" + ratio + "','" + comment.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rating Successful!");
            Con.Close();
        }
    }
}
