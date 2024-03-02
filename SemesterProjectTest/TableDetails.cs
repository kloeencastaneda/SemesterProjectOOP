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

namespace SemesterProjectTest
{
    public partial class TableDetails : Form
    {
        public TableDetails()
        {
            InitializeComponent();
        }
    }

    class Details
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
