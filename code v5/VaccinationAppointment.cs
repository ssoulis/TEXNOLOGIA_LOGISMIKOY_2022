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

    public partial class VaccinationAppointment: Form
    {

        public VaccinationAppointment()
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
        private void make_vac_calendar(object sender, EventArgs e)
        {
            //Μέθοδος για την δημιουργία ενός Calendar με την δυνατότητα καταχώρησης κειμένου στις ημερομηνίες.
        }
         private void make_vac_apt(object sender, EventArgs e)
        {
            //Μέθοδος που δίνει την δυνατότητα για επιλογή ημερομηνίας εμβολιασμού στον Calendar.
        }
         private void receive_cancel_vac(object sender, EventArgs e)
        {
            //Μέθοδος για την λήψη ακύρωσης εμβολιασμού ενημερώνοντας τον Calendar.
        }
         private void receive_avail_vac (object sender, EventArgs e)
        {
            //Μέθοδος για την λήψη διαθεσιμότητας γιατρού.
        }
    }
}