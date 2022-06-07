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

    public partial class Prescription : Form
    {

        public Prescription()
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

        private void make_prescr(object sender, EventArgs e)
        {
            //Μέθοδος για την δημιουργία φόρμας υποβολής συνταγογράφησης
        }

         private void open_prescr(object sender, EventArgs e)
        {
            //Μέθοδος για το άνοιγμα και την συμπλήρωση της φόρμας συνταγογράφησης
        }

        private void receive_final_presc(object sender, EventArgs e)
        {
            //Μέθοδος για την λήψη των έτοιμων από επεξεργασία συνταγογραφήσεων
        }
        private void show_presc(object sender, EventArgs e)
        {
            //Μέθοδος που δίνει την δυνατότητα για άνοιγμα των τελικών συνταγογραφήσεων
        }
      
        private void download_presc(object sender, EventArgs e)
        {
            //Μέθοδος για το κατέβασμα locally των συνταγογραφησεων σε pdf
        }

    }


}

