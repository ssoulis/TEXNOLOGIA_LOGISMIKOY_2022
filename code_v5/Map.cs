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

    public partial class Map : Form
    {

        public Map()
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
        private void make_map(object sender, EventArgs e)
        {
            //Μέθοδος για την δημιουργία ενας map με βάση την τωρινή τοποθεσία του χρήστη
        }
        private void receive_rates(object sender, EventArgs e)
        {
          // Μέθοδος για την λήψη των rates των γιατρών.
        }
        private void list_rates(object sender, EventArgs e)
        {
            //Μέθοδος για την καταχώρηση των rates στα σωστά σημεία στον χάρτη.
        }
        private void receive_apt(object sender, EventArgs e)
        {
          // Μέθοδος για την λήψη των ραντεβού των χρηστών με τους γιατρούς
        }
        private void list_apt(object sender, EventArgs e)
        {
            //Μέθοδος για την καταχώρηση των ραντεβού στα κατάλληλα σημεία του χάρτη.
        }
        private void make_spots(object sender, EventArgs e)
        {
            //Μέθοδος για την δημιουργεία σημείων ενδιαφέροντος στον χάρτη (νοσοκομεία,γιατροί).
        }
        private void map_search(object sender, EventArgs e)
        {
            //Μέθοδος για αναζήτηση στον χάρτη.
        }
        private void spot_click(object sender, EventArgs e)
        {
            //Μέθοδος που δίνει την δυνατότητα για επιλογή νοσοκομείου η γιατρού και εμφανίζει αξιολογήσεις και ραντεβού.
        }
    }
}
