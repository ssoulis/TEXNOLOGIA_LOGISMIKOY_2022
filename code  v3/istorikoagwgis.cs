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
    public partial class istorikoagwgis : Form
    {
        public istorikoagwgis()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select medication,[from],[to] from MedicationHistory where AMKA = '" + UserLogAMKA.userAMKA + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDVG.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void UserDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void istorikoagwgis_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
