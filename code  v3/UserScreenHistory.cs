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
    public partial class UserScreenHistory : Form
    {
        public string autoimmune_disease { get; set; }
        public string allergy { get; set; }
        //pernoyme ta stoixeia apo tin basi mas kai ta apikonoizoyme sto istoriko toy xristi
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from HistoryUser where AMKA = '" + UserLogAMKA.userAMKA + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                label5.Text = dr["AMKA"].ToString();
                namelbl.Text = dr["name"].ToString();
                label1.Text = dr["surname"].ToString();
                datelbl.Text = dr["date"].ToString();
                autoimmune_disease = dr["autoimmune_disease"].ToString();
                allergy = dr["allergy"].ToString();



                label5.Visible = true;
                namelbl.Visible = true;
                label1.Visible = true;
                datelbl.Visible = true;


            }

           
            Con.Close();
        }
        
        public UserScreenHistory()
        {
            InitializeComponent();  
            
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreenHistory userScreenHistory = new UserScreenHistory();
            userScreenHistory.Show();
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreenHistory userScreenHistory = new UserScreenHistory();
            userScreenHistory.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreenHistoryv2 userScreenHistoryv2 = new UserScreenHistoryv2();
            userScreenHistoryv2.Show();
        }

        private void UserScreenHistory_Load(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        { // istoriko aimodosias
            istorikoaimodosias Msg = new istorikoaimodosias();
            Msg.Show();

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {// istoriko emvoliasmoy
            istorikoemvoliasmoy Msg = new istorikoemvoliasmoy();
            Msg.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {//allergies
            MessageBox.Show("Αλλεργίες: " + allergy);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {// autoanosa nosimata
            MessageBox.Show("Αυτοάνοσα Νοσήματα: "+ autoimmune_disease);
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {//palia agwgi
            istorikoagwgis Msg = new istorikoagwgis();
            Msg.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {//trexon agwgi
            istorikoagwgis Msg1 = new istorikoagwgis();
            Msg1.Show();
        }
    }
}
