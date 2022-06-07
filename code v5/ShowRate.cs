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

    public partial class ShowRate: Form
    {

        public ShowRate()
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
        private void receive_rate(object sender, EventArgs e)
        {
            //Μέθοδος για την λήψη των αξιολογήσεων του γιατρού.
        }
        private void show_rates(object sender, EventArgs e)
        {
            //Μέθοδος για την εμφάνιση των αξιολογήσεων σε κατάλληλο σημείο.
        }
    }
}