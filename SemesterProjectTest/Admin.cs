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
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Xml.Linq;
using MongoDB.Driver.Core.Configuration;

namespace SemesterProjectTest
{
    
    public partial class Admin : Form
    {
       
        static MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = dbClient.GetDatabase("Restaraunt");
        static IMongoCollection<User> collection = db.GetCollection<User>("users");



        public Admin()
        { 
            InitializeComponent();
            DisplayUsers();
        }

        private void adBtnDisplay_Click(object sender, EventArgs e)
        {
  
        }

        public void DisplayUsers()
        {
            List<User> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;
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
            var filter = Builders<User>.Filter.Eq("ID", txtID.Text);
            var docs = collection.Find(filter).ToList();
            if (true)
            {
                User users = new User()
                {
                    ID = Convert.ToInt32(txtID.Text),
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = txtRole.Text,
                };

                collection.InsertOne(users);
                DisplayUsers();
            }
            else
            {
                MessageBox.Show("The ID is already occupied.");
            }
        }



        private void adBtnDelete_Click(object sender, EventArgs e)
        {
            var filter = Builders<User>.Filter.Eq("_id", txtID.Text);
            collection.DeleteOne(filter);
            DisplayUsers();

        }

        private void adBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var update = Builders<User>.Update.Set("Username", txtUsername.Text).Set("Password", txtPassword.Text).Set("Role", txtRole.Text);
                var filter = Builders<User>.Filter.Eq("_id", ObjectId.Parse(txtID.Text));

                collection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad" + ex);
            }

            DisplayUsers();
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
            [BsonId]

            public ObjectId _id { get; set; }

            [BsonElement("ID")]
            public int ID { get; set; }

            [BsonElement("Username")]

            public string Username { get; set; }

            [BsonElement("Password")]

            public string Password { get; set; }

            [BsonElement("Role")]

            public string Role { get; set; }
        }
    }
