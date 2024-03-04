
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjectTest
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=Restaraunt.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) //this is the username box
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int role = 0;

            if (role == 0) { 
                Admin window = new Admin();
                this.Hide();
                window.Show();
            }
            else if (role == 1)
            {
                Manager window = new Manager();
                this.Hide();
                window.Show();
            }

            else if (role == 2)
            {
                Staff window = new Staff();
                this.Hide();
                window.Show();

            }
        }
    }
    class User
    {


        public int ID { get; set; }


        public string Username { get; set; }



        public string Password { get; set; }



        public string Role { get; set; }
    }

}
