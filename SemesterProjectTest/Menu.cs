
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class Menu : Form
    {

        public Menu()
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


        private void ExecuteQuery(string txtQuery)
        {
            CreateConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();
        }

        private void menuBtnAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO items (ID,ItemName,ItemPrice,ItemType)" + "values('" + txtItemID.Text + "','" + txtItemName.Text + "','" + txtItemPrice.Text + "','" + txtItemType.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuDelBtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM items WHERE ID='" + txtItemID.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtItemID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItemPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtItemType.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void menuUpdateBtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE users SET NAME ='" + txtItemID.Text + "','" + txtItemName.Text + "','" + txtItemPrice.Text + "','" + txtItemType.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }
    }
    class Items
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string ItemType { get; set; }
    }


}
