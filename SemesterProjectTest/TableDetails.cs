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

        public void DisplayTables()
        {
            List<Tables> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTableID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffID.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOrderID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAvailability.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }



        class Tables
        {
            [BsonId]

            public ObjectId _id { get; set; }

            [BsonElement("Table ID")]
            public int ID { get; set; }

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
            //var filter = Builders<User>.Filter.Eq("ID", txtID.Text);
            //var docs = collection.Find(filter).ToList();
            //if (true)
            //{
            //    User users = new User()
            //    {
            //        ID = Convert.ToInt32(txtID.Text),
            //        Username = txtUsername.Text,
            //        Password = txtPassword.Text,
            //        Role = txtRole.Text,
            //    };

            //    collection.InsertOne(users);
            //    DisplayUsers();
            //}
            //else
            //{
            //    MessageBox.Show("The ID is already occupied.");
            }
        }
    }
}
