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

    public partial class Scanner: Form
    {

        public Scanner()
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
          private void make_scanner(object sender, EventArgs e)
        {
            //Μέθοδος για την δημιουργία ενός QR code scanner.
        }
          private void open_scanner(object sender, EventArgs e)
        {
            //Μέθοδος για την είσοδο στον scanner. 
        }
          
    }
}