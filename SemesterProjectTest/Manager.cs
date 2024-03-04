
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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            LoadData();
        }

        private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS;
        private DataTable DT = new DataTable();

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

        private void ExecuteQuery(string txtQuery)
        {
            CreateConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();
        }
        private void LoadData()
        {
            CreateConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            string CommandText = "SELECT * FROM users";
            DB = new SQLiteDataAdapter(CommandText, sql_conn);
            //DS.Reset();
            //DB.Fill(DS);
            //DT = DS.Tables[1];
            dataGridView1.DataSource = DT;
            sql_conn.Close();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login window = new Login();
            window.Show();
            
        }

        private void btnGoMenu_Click(object sender, EventArgs e)
        {
            {
                Menu window = new Menu();
                this.Hide();
                window.Show();
            }
        }

        private void btnStaffInsert_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO staffs (ID,FirstName,LastName,PhoneNumber,Address,Wage)" + "values('" + txtStaffID.Text + "','" + txtStaffFirstName.Text + "','" + txtStaffLastName.Text + "','" + txtPhoneNumber.Text + "','" + txtStaffAddress.Text + "','" +txtStaffWage.Text+"')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE staffs SET NAME ='" + txtStaffID.Text + "','" + txtStaffFirstName.Text + "','" + txtStaffLastName.Text + "','" + txtPhoneNumber.Text + "','" + txtStaffAddress.Text + "','" + txtStaffWage.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM staffs WHERE ID='" + txtStaffID.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStaffLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStaffAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStaffWage.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }

    class Staffs
    {
    
        public int ID { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

      
        public string PhoneNumber { get; set; }


        public string Address { get; set; }


        public string Wage { get; set; }
    }
}
