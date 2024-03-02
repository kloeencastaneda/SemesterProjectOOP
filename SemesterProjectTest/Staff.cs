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
}
