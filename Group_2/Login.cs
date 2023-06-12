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
    public partial class Login : Form
    {
        public static Employee LoggedEmployee;


        public Login()
        {
            InitializeComponent();
            noEmployeeErr.Hide();
            EmailErr.Hide();
            textBox2.Enabled = false;
            button1.Enabled = false;
        }
        public static string GetEmployeeType()
        {
            return LoggedEmployee.employeeType.ToString(); ;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoggedEmployee = (Program.seekEmployee(textBox1.Text.ToString()));
            if (Program.seekEmployee(textBox1.Text.ToString()) == null)
            {
                noEmployeeErr.Show();
                button1.Enabled = false;
                textBox2.Enabled = false;
            }
            else { noEmployeeErr.Hide();
                textBox2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          if(LoggedEmployee != null)
            {
                if (!LoggedEmployee.email.Equals(textBox2.Text.ToString()))
                {
                    EmailErr.Show();
                    button1.Enabled = false;
                }
                else
                {
                    EmailErr.Hide();
                    button1.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                homepage home = new homepage();
                home.Show();
                this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailErr_Click(object sender, EventArgs e)
        {

        }
    }
}
