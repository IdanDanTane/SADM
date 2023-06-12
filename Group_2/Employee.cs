using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Group_2
{
    public class Employee
    {
        public string employeeID;
        public string phoneNumber;
        public string email;
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public employeeType employeeType;
        public bool inArchive;






            public Employee(string employeeID, string phoneNumber, string email, string firstName, string lastName,DateTime BirthDate ,employeeType employeeType, bool inArchive, bool isNew)
        {
            this.employeeID = employeeID;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = BirthDate;
            this.employeeType = employeeType;
            this.inArchive = inArchive;
            if (isNew)
            {
                this.create_employee();
                Program.Employees.Add(this);
            }
        }
        public void create_employee()
        {
                    SQL_CON SC = new SQL_CON();
                    SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[add_employee] @employeeId, @phoneNumber, @email,@firstName , @lastName , @birthDate , @type", SC.getConnection());
                    r.SelectCommand.Parameters.AddWithValue("@employeeId", this.employeeID);
                    r.SelectCommand.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
                    r.SelectCommand.Parameters.AddWithValue("@email", this.email);
                    r.SelectCommand.Parameters.AddWithValue("@firstName", this.firstName);
                    r.SelectCommand.Parameters.AddWithValue("@lastName", this.lastName);
                    string newDateTime = this.birthDate.ToString("yyyy-MM-dd");
                    r.SelectCommand.Parameters.AddWithValue("@birthDate", newDateTime);
                    r.SelectCommand.Parameters.AddWithValue("@type", this.employeeType.ToString());
                    SC.Execute_non_query(r);
                }
            }
        }
    
