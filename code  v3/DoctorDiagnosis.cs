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
    public partial class DoctorDiagnosis : Form
    {
        public string name { get; set; }
        public string surname { get; set; }
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from LoginDoctor where username = '" + DoctorLogUsername.doctorUsername + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                name = dr["name"].ToString();
                surname = dr["surname"].ToString();

            }


            Con.Close();
        }
        public DoctorDiagnosis()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //giatros kanei diagnwsi -update
            SqlDataAdapter da = new SqlDataAdapter("select * from DoctorDiagnosis where AMKA = '" + AMKA.Text + "' ", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {// an idi iparxei diagnwsi me auto to AMKA kanei update
                try
                {
                    Con.Open();
                    string query = "update DoctorDiagnosis set doctor_name ='" + name +" "+ surname + "' , patient='" + patient.Text + "' ,  diagnosis='" + comment.Text + "' where AMKA='" + AMKA.Text + "'   ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Diagnosis Successfully Edited");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else if (AMKA.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
             {// an ginetai prwti fora diagnwsi se auto to AMKA insert
                try
                {
                    Con.Open();
                    string query = "insert into DoctorDiagnosis values('" + name +" "+ surname + "','" + patient.Text + "','" + AMKA.Text + "','" + comment.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Diagnosis Successfully Added");
                    Con.Close();
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DoctorDiagnosis_Load(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}