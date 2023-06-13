
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Group_2
{
    public partial class createCustomer : Form
    {


        public createCustomer()
        {
            InitializeComponent();
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)   // Email
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                if (!(Program.IsValidEmail(textBox1.Text)))
                    invalidEmail.Show();
                else
                    invalidEmail.Hide();
            }
            else
                invalidEmail.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            // add customer 
            
            try
            {
                Customer c = addCustomer();
                c.add_Customer();
              //  MessageBox.Show( "customer added");
               
            }
            catch (Exception e1)
            {
                MessageBox.Show("could not add the customer, plese try again");

            }
           
        }


        // checks if all data fits to database. if not - throws exception
        private Customer addCustomer()
        {              
           if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
               throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

           if((!(Program.IsValidEmail(textBox1.Text)) || (!(Program.IsValidZipCode(textBox3.Text))) || (!(Program.IsValidPhone(textBox4.Text)))))
                throw new Exception(); // One or more of the textboxes are not valid

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

    
        private void textBox3_TextChanged(object sender, EventArgs e)   //Zip Code number
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

        private void invalidEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



