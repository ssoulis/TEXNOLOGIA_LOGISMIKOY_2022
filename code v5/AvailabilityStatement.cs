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

    public partial class AvailabilityStatement: Form
    {

        public AvailabilityStatement()
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
         private void avail_apt(object sender, EventArgs e)
        {
            //Μέθοδος για ενημέρωση του Calendar για τις διαθεσιμότητες του γιατρού.
        }
         private void avail.vac(object sender, EventArgs e)
        {
            //Μέθοδος για την για ενημέρωση του Calendar για τις διαθεσιμότητες εμβολιασμού.
        }
    }
}