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

    public partial class DoctorAppointments : Form
    {

        public DoctorAppointments()
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


        private void make_calendar(object sender, EventArgs e)
        {
           //Μέθοδος για την δημιουργία Calendar με δυνατότητα εισαγωγής κειμένου στις ημερομηνίες.
        }
        
        private void make_apt_req(object sender, EventArgs e)
        {
           //Μέθοδος για την δημιουργία φόρμας υποβολής User για την αίτηση ραντεβού με γιατρό.
        }

         private void make_calendar_text(object sender, EventArgs e)
        {
           //Μέθοδος για την δημιουργία κειμένου στις ημερομηνίες του Calendar.
        }

         private void save_calendar_text(object sender, EventArgs e)
        {
           //Μέθοδος για αποθήκευση κειμένου στις ημερομηνίες.
        }
        private void make_apt(object sender, EventArgs e)
        {
           //Μέθοδος που δίνει την δυνατότητα αποδοχής η απόρριψής της αίτησης ραντεβού.
        }
         private void make_apt(object sender, EventArgs e)
        {
           //Μέθοδος που δίνει την δυνατότητα αποδοχής η απόρριψής της αίτησης ραντεβού.
        }
        private void send_decision(object sender, EventArgs e)
        {
           //Μέθοδος για την αποστολή μηνύματος με την απόφαση για το ραντεβού ( αποδοχή ή απόρριψη).
        }
        private void receive_apt_req(object sender, EventArgs e)
        {
           //Μέθοδος για να λαμβάνει ο  γιατρός τις αιτήσεις για ραντεβού.
        }
        private void receive_cancel_apt(object sender, EventArgs e)
        {
           //Μέθοδος για να λαμβάνει ο  γιατρός τις ακυρώσεις ραντεβού
        }
        private void make_presc_apt(object sender, EventArgs e)
        {
           //Mέθοδος για άνοιγμα του παραθύρου για συνταγογράφηση
        }
        private void receive_avail_apt(object sender, EventArgs e)
        {
           //Μέθοδος για την λήψη διαθεσιμότητας των γιατρών.
        }
        private void receive_diagnosis(object sender, EventArgs e)
        {
           //Μέθοδος για την λήψη της διάγνωσης.
        }

    }
}