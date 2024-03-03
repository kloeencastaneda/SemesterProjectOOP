
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
            DisplayTables();
        }

        private void TableDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff window = new Staff();
            window.Show();

        }

        public void DisplayTables()
        {
           

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOrderID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAvailability.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        class Tables
        {

            public string ID { get; set; }


            public string Order { get; set; }


            public string Staff { get; set; }

            public string Customer { get; set; }

            public string Available { get; set; }
        }

        private void staffBtnInsert_Click(object sender, EventArgs e)
        {

        }

        private void staffBtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void staffBtnUpdate_Click(object sender, EventArgs e)
        {


        }
    }
