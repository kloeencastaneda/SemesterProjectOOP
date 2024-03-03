using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjectTest
{
    //needs to be able to apply discounts and manage staff
    public partial class Manager : Form
    {

        static MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = dbClient.GetDatabase("Restaraunt");
        static IMongoCollection<Staffs> collection = db.GetCollection<Staffs>("staffs");
        public Manager()
        {
            InitializeComponent();
        }

        public void DisplayStaff()
        {
            List<Staffs> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;
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
            var filter = Builders<Staffs>.Filter.Eq("ID", txtStaffID.Text);
            var docs = collection.Find(filter).ToList();
            if (true)
            {
                Staffs staffs = new Staffs()
                {
                    ID = Convert.ToInt32(txtStaffID.Text),
                    FirstName = txtStaffFirstName.Text,
                    LastName = txtStaffLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtStaffAddress.Text,
                    Wage = txtStaffWage.Text,
                };

                collection.InsertOne(staffs);
                DisplayStaff();
            }
            else
            {
                MessageBox.Show("The ID is already occupied.");
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var update = Builders<Staffs>.Update.Set("FirstName", txtStaffFirstName.Text).Set("LastName", txtStaffLastName.Text).Set("PhoneNumber", txtPhoneNumber.Text).Set("Address", txtStaffAddress.Text).Set("Wage",txtStaffWage.Text);

                var filter = Builders<Staffs>.Filter.Eq("ID", txtStaffID.Text);

                collection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad" + ex);
            }

            DisplayStaff();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            var filter = Builders<Staffs>.Filter.Eq("ID", txtStaffID.Text);
            collection.DeleteOne(filter);
            DisplayStaff();

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
        [BsonId]

        [BsonElement("ID")]
        public int ID { get; set; }

        [BsonElement("First Name")]

        public string FirstName { get; set; }

        [BsonElement("Last Name")]

        public string LastName { get; set; }

        [BsonElement("Phone Number")]

        public string PhoneNumber { get; set; }


        [BsonElement("Address")]

        public string Address { get; set; }


        [BsonElement("Wage")]

        public string Wage { get; set; }
    }
}
