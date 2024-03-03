
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

        public Menu()
        {
            InitializeComponent();

        }

        public void DisplayItems()
        {

        }

        private void menuBtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuDelBtn_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuUpdateBtn_Click(object sender, EventArgs e)
        {

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
