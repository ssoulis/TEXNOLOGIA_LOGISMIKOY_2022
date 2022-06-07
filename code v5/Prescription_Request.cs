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

    public partial class PrescriptionRequest : Form
    {

        public PrescriptionRequest()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=TLDB;Integrated Security=True");
        
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

        private void make_presc_req(object sender, EventArgs e)
        {
            //Μέθοδος για την δημιουργία φόρμας υποβολής για αίτηση συνταγογράφησης
        }

         private void presc_req(object sender, EventArgs e)
        {
            //Μέθοδος για την αποστολή της αίτησης συνταγογράφησης σε γιατρό

        }

        

    }


}

