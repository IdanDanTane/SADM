using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Group_2
{
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
            EmployeeType_choose.DataSource = GetEmployeeTypeList();
            EmployeeType_choose.DisplayMember = "Description";
        }

        private List<EmployeeTypeItem> GetEmployeeTypeList()
        {
            var employeeTypes = Enum.GetValues(typeof(employeeType));
            var employeeTypeList = new List<EmployeeTypeItem>();

            foreach (employeeType type in employeeTypes)
            {
                var descriptionAttribute = type.GetType().GetField(type.ToString())
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute;

                var description = descriptionAttribute != null ? descriptionAttribute.Description : type.ToString();

                employeeTypeList.Add(new EmployeeTypeItem { Value = type, Description = description });
            }

            return employeeTypeList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(EmployeeID.Text)))
            {
                if (!(Program.IsValidID(EmployeeID.Text)))
                    invalid_ID.Show();
                else
                    invalid_ID.Hide();
            }
            else
                invalid_ID.Show();
        }

        private void create_Employee_Click(object sender, EventArgs e)
        {

            // create employee 

            try
            {
                Employee emp = this.addEmployee();


            }
            catch (Exception e1)
            {
                MessageBox.Show("could not create the employee, plese try again");

            }

        }



        private Employee addEmployee()
        {
            if (string.IsNullOrWhiteSpace(EmployeeID.Text) || string.IsNullOrWhiteSpace(EmployeePhone.Text) || string.IsNullOrWhiteSpace(EmployeeEmail.Text) || string.IsNullOrWhiteSpace(EmployeeFirstName.Text) || string.IsNullOrWhiteSpace(EmployeeLastName.Text))
                throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

            if (((!(Program.IsValidID(EmployeeID.Text))) || (!(Program.IsValidPhone(EmployeePhone.Text))) || (!(Program.IsValidEmail(EmployeeEmail.Text)))))
                throw new Exception(); // One or more of the textboxes are not valid

            if (employeeBirthDate.Value > DateTime.Today)
                throw new Exception();

            if (employeeBirthDate.Value.Equals(DateTime.Today))
                throw new Exception();

            Employee E = new Employee(EmployeeID.Text, EmployeePhone.Text, EmployeeEmail.Text, EmployeeFirstName.Text, EmployeeLastName.Text, employeeBirthDate.Value, (employeeType)Enum.Parse(typeof(employeeType), EmployeeType_choose.Text.Replace(' ', '_')), true, true);
            return E;

        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(EmployeePhone.Text)))
            {
                if (!(Program.IsValidPhone(EmployeePhone.Text)))
                    invalidPhone.Show();
                else
                    invalidPhone.Hide();
            }
            else
                invalidPhone.Show();
        }

        private void employeeBirthDate_ValueChanged(object sender, EventArgs e)
        {
            employeeBirthDate.CustomFormat = "yyyy-MM-dd";

            if (employeeBirthDate.Value > DateTime.Today)
                invalidBD.Show();
            else
                invalidBD.Hide();

            if (employeeBirthDate.Value.Equals(DateTime.Today))
                invalidBD.Show();
            else
                invalidBD.Hide();


        }

        private void EmployeeEmail_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(EmployeeEmail.Text)))
            {
                if (!(Program.IsValidEmail(EmployeeEmail.Text)))
                    invalidEmail.Show();
                else
                    invalidEmail.Hide();
            }
            else
                invalidEmail.Show();
        }

        private void EmployeeFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeType_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageEmployees EMP = new manageEmployees();
            EMP.Show();
            this.Hide();

        }

        private void invalidEmail_Click(object sender, EventArgs e)
        {

        }

        private void invalidPhone_Click(object sender, EventArgs e)
        {

        }

      

        private void invalidBD_Click(object sender, EventArgs e)
        {
            

        }

        private void label8_Click(object sender, EventArgs e)
        {
            //invalid_ID
        }
    }
}
