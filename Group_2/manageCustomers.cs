using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public partial class manageCustomers : Form
    {
        public manageCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createCustomer CreateCSUT = new createCustomer();
            CreateCSUT.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            searchCUST CUSTsearch = new searchCUST();
            CUSTsearch.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewCUST view = new viewCUST();
            view.Show();
            this.Hide();
        }
    }
}
