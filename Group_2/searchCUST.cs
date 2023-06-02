
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
    public partial class searchCUST : Form
    {
        public Customer temp;
        public searchCUST()
        {
            InitializeComponent();
            textBox4.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.seekCustomer(textBox1.Text.ToString()) == null)
            {
                MessageBox.Show("Customer does not exist. please try again");
            }
            else
            {
                temp = Program.seekCustomer(textBox1.Text.ToString());
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                this.textBox2.AppendText(temp.companyName);
                this.textBox3.AppendText(temp.zipCode);
                this.textBox4.AppendText(temp.phoneNumber);

            }

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE dbo.deleteCustomer  @Email", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@Email", temp.Email);
            SC.Execute_non_query(r);
            Program.Customers.Remove(temp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE dbo.update_Customer @Email, @companyName, @zipCode, @phoneNumber", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@Email", this.textBox1.Text);
            r.SelectCommand.Parameters.AddWithValue("@companyName", this.textBox2.Text);
            r.SelectCommand.Parameters.AddWithValue("@zipCode", this.textBox3.Text);
            r.SelectCommand.Parameters.AddWithValue("@phoneNumber", this.textBox4.Text);
            SC.Execute_non_query(r);
            temp.companyName = this.textBox2.Text;
            temp.zipCode = this.textBox3.Text;
            temp.phoneNumber = this.textBox4.Text;
        }
    }
    }

