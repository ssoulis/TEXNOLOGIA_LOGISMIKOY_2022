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
    public partial class UserScreen : Form
    {
        //pernoyme ta stoixeia apo tin basi mas kai ta apikonoizoyme stin arxiki othoni
        private void fetchempdata()
        {
            Con.Open();
            string query = "select AMKA,name,surname,AFM,address,phone,email,img from LoginUser where AMKA = '" + UserLogAMKA.userAMKA + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            SqlDataReader DataRead = cmd.ExecuteReader();//---------- foto
            DataRead.Read();//---------- foto 
            foreach (DataRow dr in dt.Rows)
            {
                label5.Text = dr["AMKA"].ToString();
                namelbl.Text = dr["name"].ToString();
                label3.Text = dr["surname"].ToString();
                label12.Text = dr["AFM"].ToString();
                label14.Text = dr["address"].ToString();
                label13.Text = dr["phone"].ToString();
                label9.Text = dr["email"].ToString();


                label5.Visible = true;
                namelbl.Visible = true;
                label3.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label9.Visible = true;
            }
           
            if (DataRead.HasRows)//------------ gia tin foto
            {
                byte[] images = ((byte[])DataRead[7]);
                if(images == null)
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
        public UserScreen()
        {
            
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");

        

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void Customerlbl_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSettings userSettings = new UserSettings();
            userSettings.Show();
        }
    }
}
