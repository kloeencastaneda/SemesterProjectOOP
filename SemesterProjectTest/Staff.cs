using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
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
    public partial class Staff : Form
    {

        static MongoClient dbClient = new MongoClient("mongodb+srv://kloeepratt:P0mP0mPur1n@cluster0.cokpytk.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");

        static IMongoDatabase db = dbClient.GetDatabase("Restaraunt");
        static IMongoCollection<Restaraunt> collection = db.GetCollection<tables>("tables");
        public Staff()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }
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
    }
}
