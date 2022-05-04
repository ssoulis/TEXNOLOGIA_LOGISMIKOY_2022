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
    public partial class DoctorScreen : Form
    {
        //pernoyme ta stoixeia apo tin basi mas kai ta apikonoizoyme stin arxiki othoni
        private void fetchempdata()
        {
            Con.Open();
            string query = "select name,surname,address,DoctorID,specialization,phone,img from LoginDoctor where username = '" + DoctorLogUsername.doctorUsername + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            SqlDataReader DataRead = cmd.ExecuteReader();//---------- foto
            DataRead.Read();//---------- foto 
            foreach (DataRow dr in dt.Rows)
            {
                name.Text = dr["name"].ToString();
                label3.Text = dr["surname"].ToString();
                label8.Text = dr["address"].ToString();
                label5.Text = dr["DoctorID"].ToString();
                label14.Text = dr["specialization"].ToString();
                label13.Text = dr["phone"].ToString();



                name.Visible = true;
                label3.Visible = true;
                label8.Visible = true;
                label5.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                
            }

            if (DataRead.HasRows)//------------ gia tin foto
            {
                byte[] images = ((byte[])DataRead[6]);
                if (images == null)
                {
                    image.Image = null;
                }
                else
                {
                    MemoryStream mstreem = new MemoryStream(images);
                    image.Image = Image.FromStream(mstreem);
                }
            }
            Con.Close();
        }
        public DoctorScreen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorSettings doctorSettings = new DoctorSettings();
            doctorSettings.Show();
        }

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
