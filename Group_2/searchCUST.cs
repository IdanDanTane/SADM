
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
        bool addEmail = false;
        bool addPhoneNum = false;
        bool addZip = false;
        bool addCompany = false;
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
            temp.inArchive = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          if ((addEmail = true) && (addPhoneNum = true) && (addCompany = true) && (addZip = true))
                {SQL_CON SC = new SQL_CON();
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
          else
              MessageBox.Show("could not add the customer, plese try again");



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)//phone number
            {
                invalid_Zip.Show();
                if (Program.IsValidZipCode(textBox3.Text))
                {
                    invalid_Zip.Hide();
                    addZip = true;
                }
            }
            else
            {
                invalid_Zip.Show();
                addZip = false;

            }
        }

        private void invalid_Zip_Click(object sender, EventArgs e)
        {

        }

        private void invalidPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != null)//phone number
            {
                invalidPhone.Show();
                if (Program.IsValidPhone(textBox4.Text))
                {
                    invalidPhone.Hide();
                    addPhoneNum = true;
                }
            }
            else
            {
                invalidPhone.Show();
                addPhoneNum = false;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

