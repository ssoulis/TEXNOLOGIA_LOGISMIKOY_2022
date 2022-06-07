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

    public partial class SubmitPrescription: Form
    {

        public SubmitPrescription()
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
         private void receive_presc(object sender, EventArgs e)
        {
            //Μέθοδος για την λήψη των συνταγογραφήσεων του χρήστη
        }
        private void save_prescr(object sender, EventArgs e)
        {
            //Μέθοδος για την αποθήκευση της φόρμας συνταγογράφησης σε pdf.
        }
    }
}