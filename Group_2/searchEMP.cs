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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_2
{
    public partial class searchEMP : Form
    {
        public Employee temp;
        public searchEMP()
        {
            InitializeComponent();
            this.EmployeePhone.Enabled = false;
            this.employeeBirthDate.Enabled = false;
            this.EmployeeEmail.Enabled = false;
            this.EmployeeFirstName.Enabled = false;
            this.EmployeeLastName.Enabled = false;
            this.EmployeeType_choose.Enabled = false;
            this.deleteEMP.Enabled = false;
            this.UpdateEMP.Enabled = false;
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

        private void search_Employee_Click(object sender, EventArgs e)
        {
           
            if (Program.seekEmployee(EmployeeID.Text.ToString()) == null)
            {
                MessageBox.Show("employee does not exist. please try again");
            }
            else
            {
                search_Employee.Enabled = false;
                deleteEMP.Enabled = true;
                UpdateEMP.Enabled = true;
                temp = Program.seekEmployee(EmployeeID.Text.ToString());
                EmployeeID.Enabled = false;
                this.EmployeePhone.AppendText(temp.phoneNumber);
                this.employeeBirthDate.Value = temp.birthDate;
                this.EmployeeEmail.AppendText(temp.email);
                this.EmployeeFirstName.AppendText(temp.firstName);
                this.EmployeeLastName.AppendText(temp.lastName);
                this.EmployeeType_choose.SelectedItem=temp.employeeType;


                this.EmployeePhone.Enabled = true;
                this.employeeBirthDate.Enabled = true;
                this.EmployeeEmail.Enabled = true;
                this.EmployeeFirstName.Enabled = true;
                this.EmployeeLastName.Enabled = true;
                this.EmployeeType_choose.Enabled = true;
            }
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

            if (employeeBirthDate.Value < DateTime.Today)
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

        private void deleteEMP_Click(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[Delete_Employee_And_RemoveToArchive] @employeeId", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@employeeId", temp.employeeID);
            SC.Execute_non_query(r);
            temp.inArchive = true;

        }

        private void UpdateEMP_Click(object sender, EventArgs e)
        {
            // update employee 

            try
            {
                Employee emp = this.updateEmployee();

                SQL_CON SC = new SQL_CON();
                SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[update_employee] @employeeId, @phoneNumber, @email,@firstName , @lastName , @birthDate , @type", SC.getConnection());
                r.SelectCommand.Parameters.AddWithValue("@employeeId", temp.employeeID);
                r.SelectCommand.Parameters.AddWithValue("@phoneNumber", this.EmployeePhone.Text);
                r.SelectCommand.Parameters.AddWithValue("@email", this.EmployeeEmail.Text);
                r.SelectCommand.Parameters.AddWithValue("@firstName", this.EmployeeFirstName.Text);
                r.SelectCommand.Parameters.AddWithValue("@lastName", this.EmployeeLastName.Text);
                string newDateTime = this.employeeBirthDate.Value.ToString("yyyy-MM-dd");
                r.SelectCommand.Parameters.AddWithValue("@birthDate", newDateTime);
                r.SelectCommand.Parameters.AddWithValue("@type", this.EmployeeType_choose.Text);
                SC.Execute_non_query(r);
                temp.email = this.EmployeeEmail.Text;
                temp.firstName = this.EmployeeFirstName.Text;
                temp.lastName = this.EmployeeLastName.Text;
                temp.phoneNumber = this.EmployeePhone.Text;
                temp.birthDate = this.employeeBirthDate.Value;
                temp.employeeType = (employeeType)Enum.Parse(typeof(employeeType), this.EmployeeType_choose.Text.Replace(' ', '_'));

            }
            catch (Exception e1)
            {
                MessageBox.Show("could not update the employee, plese try again");
            }

        }

        private Employee updateEmployee()
        {
            if (string.IsNullOrWhiteSpace(EmployeeID.Text) || string.IsNullOrWhiteSpace(EmployeePhone.Text) || string.IsNullOrWhiteSpace(EmployeeEmail.Text) || string.IsNullOrWhiteSpace(EmployeeFirstName.Text) || string.IsNullOrWhiteSpace(EmployeeLastName.Text))
                throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

            if (((!(Program.IsValidID(EmployeeID.Text))) || (!(Program.IsValidPhone(EmployeePhone.Text))) || (!(Program.IsValidEmail(EmployeeEmail.Text)))))
                throw new Exception(); // One or more of the textboxes are not valid

            if (employeeBirthDate.Value < DateTime.Today)
                throw new Exception();

            if (employeeBirthDate.Value.Equals(DateTime.Today))
                throw new Exception();
                 return temp;

        }

    

        private void invalidPhone_Click(object sender, EventArgs e)
        {

        }

        private void invalidEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
