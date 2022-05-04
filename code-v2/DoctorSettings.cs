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
    public partial class DoctorSettings : Form
    {
        public DoctorSettings()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorScreen doctorScreen = new DoctorScreen();
            doctorScreen.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorScreen doctorScreen = new DoctorScreen();
            doctorScreen.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //apothikeusi olwn twn allagwn
            if (address.Text == "" || phone.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update LoginDoctor set address ='" + address.Text + "' , phone='" + phone.Text + "'  where username = '" + DoctorLogUsername.doctorUsername + "'   ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes Successfully Edited");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            // allagi dieuthinsis
            if (address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update LoginDoctor set address ='" + address.Text + "'  where username = '" + DoctorLogUsername.doctorUsername + "'   ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes Successfully Edited");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            //allagi  tilefonoy
            if (phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update LoginDoctor set  phone='" + phone.Text + "'  where username = '" + DoctorLogUsername.doctorUsername + "'   ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes Successfully Edited");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //allagi password
            if (password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update LoginDoctor set  password='" + password.Text + "' where username = '" + DoctorLogUsername.doctorUsername + "'   ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes Successfully Edited");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        string imgLocation = "";
        SqlCommand cmd;
        private void image_Click(object sender, EventArgs e)
        {
            // kanoyme  browse to img poy 8eloyme na baloyme
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                image.ImageLocation = imgLocation;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            // apothikeusi image
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);

            Con.Open();
            string sqlQuery = "Update LoginDoctor SET img =@images where username ='" + DoctorLogUsername.doctorUsername + "' ";

            cmd = new SqlCommand(sqlQuery, Con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show(N.ToString() + "Successfully upload image!");
        }
    }
}
