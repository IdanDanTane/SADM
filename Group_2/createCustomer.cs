
using Group_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Group_2
{
    public partial class createCustomer : Form
    {
        bool addEmail = false;
        bool addPhoneNum = false;
        bool addZip = false;
        bool addCompany = false;

        public createCustomer()
        {
            InitializeComponent();

 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Program.seekCustomer(textBox1.Text.ToString()) == null)
            {
                if (!(Program.IsValidEmail(textBox1.Text)))
                {            
                    invalidEmail.Show();
                    addEmail = false;
                }
                else
                {
                    invalidEmail.Hide();
                    addEmail = true;
                }
            }
   
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            // add customer onclick
            string alert;
            try
            {
                Customer c = addCustomer();
                c.add_Customer();
                MessageBox.Show( "customer added");
               
            }
            catch (Exception e1)
            {
                MessageBox.Show("could not add the customer, plese try again");

            }
           
        }


        // checks if all data fits to database. if not - throws exception
        private Customer addCustomer()
        {               
           if (!((addEmail = true) && (addPhoneNum = true) && (addCompany = true) && (addZip = true)))
               throw new Exception();
           Customer C = new Customer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, true, true);
            return C;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            if (textBox4.Text != null)//phone number
            {
                invalidPhone.Show();
                if (Program.IsValidPhone(textBox4.Text))
                {
                    invalidPhone.Hide();
                    addPhoneNum=true;
                }
            }
            else
            {
                invalidPhone.Show();
                addPhoneNum = false;

            }
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

        private void invalidEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           if( textBox1.Text != null )
            {
                addCompany = true;
            }
        }
    }
    }



