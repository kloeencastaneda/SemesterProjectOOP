
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
    public partial class TableDetails : Form
    {

        public TableDetails()
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
        private void TableDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff window = new Staff();
            window.Show();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOrderID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAvailability.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        class Tables
        {
            public string ID { get; set; }
            public string Order { get; set; }
            public string Staff { get; set; }
            public string Customer { get; set; }
            public string Available { get; set; }
        }

        private void staffBtnInsert_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO tables (ID,Order,Staff,Customer,Available)" + "values('" + txtID.Text + "','" + txtOrderID.Text + "','" + txtStaffID.Text + "','" + txtCustomerID.Text + "','" + txtAvailability.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void staffBtnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM tables WHERE ID='" + txtID.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void staffBtnUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE tables SET NAME ='" + txtID.Text + "','" + txtOrderID.Text + "','" + txtStaffID.Text + "','" + txtCustomerID.Text + "','" + txtAvailability.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }
    }
}
