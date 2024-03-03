using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace SemesterProjectTest
{
    public partial class TableDetails : Form
    {

        static MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = dbClient.GetDatabase("Restaraunt");
        static IMongoCollection<Tables> collection = db.GetCollection<Tables>("tables");

   
        public TableDetails()
        {
            InitializeComponent();
            DisplayTables();
        }

        private void TableDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff window = new Staff();
            window.Show();

        }

        public void DisplayTables()
        {
            List<Tables> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;

        }  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffID.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOrderID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAvailability.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        class Tables
        {
            [BsonId]

            [BsonElement("ID")]
            public string ID { get; set; }

            [BsonElement("Order ID")]

            public string Order { get; set; }

            [BsonElement("Staff ID")]

            public string Staff { get; set; }

            [BsonElement("Customer ID")]

            public string Customer { get; set; }


            [BsonElement("Available")]

            public string Available { get; set; }
        }

        private void staffBtnInsert_Click(object sender, EventArgs e)
        {
            var filter = Builders<Tables>.Filter.Eq("ID", txtID.Text);
            var docs = collection.Find(filter).ToList();
            if (true)
            {
               Tables tables = new Tables()
               {
                    ID = txtID.Text,
                    Order = txtOrderID.Text,
                    Staff = txtStaffID.Text,
                    Customer = txtCustomerID.Text,
                    Available = txtAvailability.Text,
                };

               collection.InsertOne(tables);
                DisplayTables();
            }
            else
            {
                MessageBox.Show("The ID is already occupied.");
            }
        }

        private void staffBtnDelete_Click(object sender, EventArgs e)
        {
            var filter = Builders<Tables>.Filter.Eq("ID", txtID.Text);
            collection.DeleteOne(filter);
            DisplayTables();
        }

        private void staffBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var update = Builders<Tables>.Update.Set("Order", txtOrderID.Text).Set("Staff", txtStaffID.Text).Set("Customer", txtCustomerID.Text).Set("Available", txtAvailability.Text);
                var filter = Builders<Tables>.Filter.Eq("ID", (txtID.Text));

                collection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad" + ex);
            }

            DisplayTables();
        }
    }

}
