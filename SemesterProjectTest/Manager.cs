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
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login window = new Login();
            window.Show();
            
        }
    }
}
