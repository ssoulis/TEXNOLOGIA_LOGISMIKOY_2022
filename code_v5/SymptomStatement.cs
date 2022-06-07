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

    public partial class SymptomStatement : Form
    {

        public SymptomStatement()
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

        private void make_symptom(object sender, EventArgs e)
        {
            //Μέθοδος που δημιουργεί φόρμα υποβολής συμπτωμάτων
        }

         private void save_symptom(object sender, EventArgs e)
        {
            //Μέθοδος που ανοίγει την φόρμα υποβολής συμπτωμάτων
        }

        private void open_symptom(object sender, EventArgs e)
        {
            //Μέθοδος για αποθήκευση των συμπτωμάτων
        }


    }




}