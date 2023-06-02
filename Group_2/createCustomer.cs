
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public partial class createCustomer : Form
    {
        public createCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer C = new Customer(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text,true);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            manageCustomers manageCustomers = new manageCustomers();
            manageCustomers.Show();
            this.Hide();
        }
    }
    }

