
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

 
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login window = new Login();
            window.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableDetails window = new TableDetails();
            window.Show();
        }
    }

    class Tables
    {

        public int ID { get; set; }

        public string Order { get; set; }

        public string Staff { get; set; }

        public string Customer { get; set; }
    }
}
