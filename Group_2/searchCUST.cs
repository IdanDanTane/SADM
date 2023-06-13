
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
            invalidEmail.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (Program.IsValidEmail(textBox1.Text))
                invalidEmail.Hide();
            else
                invalidEmail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invalidEmail.Hide();

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

            // update customer 

            try
            {
                Customer c = updateCustomer();
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
            catch (Exception e1)
            {
                MessageBox.Show("could not update the customer, plese try again");

            }

        }
        private Customer updateCustomer()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

            if ((!(Program.IsValidEmail(textBox1.Text))) && (!(string.IsNullOrWhiteSpace(textBox1.Text)))) //invalid Email
            {
                invalidEmail.Show();
                throw new Exception();
            }

            if (((!(Program.IsValidZipCode(textBox3.Text))) || (!(Program.IsValidPhone(textBox4.Text)))))
                throw new Exception(); // One or more of the textboxes are not valid

            Customer C = new Customer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, true, true);
            return C;
        }


        private void textBox3_TextChanged(object sender, EventArgs e) // Zip Code
        {
            if (!(string.IsNullOrWhiteSpace(textBox3.Text)))
            {
                if (!(Program.IsValidZipCode(textBox3.Text)))
                    invalid_Zip.Show();
                else
                    invalid_Zip.Hide();
            }
            else
                invalid_Zip.Show();
        }

        private void invalid_Zip_Click(object sender, EventArgs e)
        {

        }

        private void invalidPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //phone number
        {
            if (!(string.IsNullOrWhiteSpace(textBox4.Text)))
            {
                if (!(Program.IsValidPhone(textBox4.Text)))
                    invalidPhone.Show();
                else
                    invalidPhone.Hide();
            }
            else
                invalidPhone.Show();
        }

        private void invalidEmail_Click(object sender, EventArgs e)
        {

        }

        private void searchCUST_Load(object sender, EventArgs e)
        {
            
        }
    }
    }

