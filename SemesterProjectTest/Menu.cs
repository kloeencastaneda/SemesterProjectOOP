using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjectTest
{
    public partial class Menu : Form
    {


        static MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = dbClient.GetDatabase("Restaraunt");
        static IMongoCollection<Items> collection = db.GetCollection<Items>("items");
        public Menu()
        {
            InitializeComponent();
            DisplayItems();
        }

        public void DisplayItems()
        {
            List<Items> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;
        }

        private void menuBtnAdd_Click(object sender, EventArgs e)
        {
            var filter = Builders<Items>.Filter.Eq("ID", txtItemID.Text);
            var docs = collection.Find(filter).ToList();
            if (true)
            {
                Items items = new Items()
                {
                    ID = Convert.ToInt32(txtItemID.Text),
                    ItemName = txtItemName.Text,
                    ItemPrice = txtItemPrice.Text,
                    ItemType = txtItemType.Text,
                };

                collection.InsertOne(items);
                DisplayItems();
            }
            else
            {
                MessageBox.Show("The ID is already occupied.");
            }
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuDelBtn_Click(object sender, EventArgs e)
        {
            var filter = Builders<Items>.Filter.Eq("ID", txtItemID.Text);
            collection.DeleteOne(filter);
            DisplayItems();

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
            try
            {
                var update = Builders<Items>.Update.Set("ItemName", txtItemName.Text).Set("ItemPrice", txtItemPrice.Text).Set("ItemType", txtItemType.Text);
                var filter = Builders<Items>.Filter.Eq("ID", txtItemID.Text);

                collection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad" + ex);
            }

            DisplayItems();
        }
    }

    class Items
    {
        [BsonId]

        [BsonElement("ID")]
        public int ID { get; set; }

        [BsonElement("Item Name")]

        public string ItemName { get; set; }

        [BsonElement("Item Price")]

        public string ItemPrice { get; set; }

        [BsonElement("Item Type")]

        public string ItemType { get; set; }
    }


}
