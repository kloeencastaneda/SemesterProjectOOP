
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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        public void DisplayStaff()
        {
          
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
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
   

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
    
        public int ID { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

      
        public string PhoneNumber { get; set; }


        public string Address { get; set; }


        public string Wage { get; set; }
    }
}
