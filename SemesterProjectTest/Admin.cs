using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ZstdSharp;
using System.ComponentModel.DataAnnotations;



namespace SemesterProjectTest
{


    public partial class Admin : Form
    {

   
        public Admin()
        {
            InitializeComponent();
            LoadData();
           
        }

        private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS;
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_conn = new SQLiteConnection("Data Source=Restaraunt.db;Version=3;New=false;Compress=true;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQuery; 
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();
        }

private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login window = new Login();
            window.Show();

        }
        private void adBtnDisplay_Click(object sender, EventArgs e)
        {
  
        }

    private void LoadData() 
        {
            SetConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            string CommandText = "SELECT * FROM users";
            DB = new SQLiteDataAdapter(CommandText, sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRole.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void adBtnInsert_Click(object sender, EventArgs e)
        {
            string txtQuery ="INSERT INTO users (ID,Username,Password,Role)" +"values('" + txtID.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtRole.Text+"')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void adBtnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM users WHERE ID='" + txtID.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();

        }

        private void adBtnUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE users SET NAME ='" + txtID.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtRole.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void goMenu_Click(object sender, EventArgs e)
        {
            Menu window = new Menu();
            this.Hide();
            window.Show();
        }
    }



    class Users
        {

        [Key]
            public int ID { get; set; }

            public string Username { get; set; }

            public string Password { get; set; }

            public string Role { get; set; }
        }
    }
