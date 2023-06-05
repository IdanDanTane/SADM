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

        }

        private void create_Employee_Click(object sender, EventArgs e)
        {
            create_Employee_Click(sender, e, employeeBirthDate);
        }

        private void create_Employee_Click(object sender, EventArgs e, DateTimePicker employeeBirthDate)
        {
            Employee E = new Employee(EmployeeID.Text, EmployeePhone.Text, EmployeeEmail.Text, EmployeeFirstName.Text, EmployeeLastName.Text, employeeBirthDate.Value ,(employeeType)Enum.Parse(typeof(employeeType),EmployeeType_choose.Text.Replace(' ', '_')),true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeBirthDate_ValueChanged(object sender, EventArgs e)
        {
            employeeBirthDate.CustomFormat = "yyyy-MM-dd";
        }

        private void EmployeeEmail_TextChanged(object sender, EventArgs e)
        {

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
    }
}
