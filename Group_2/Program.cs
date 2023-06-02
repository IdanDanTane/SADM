using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Customer> Customers;
        [STAThread]
        public static void init_Employees()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                employeeType T = (employeeType)Enum.Parse(typeof(employeeType), rdr.GetValue(6).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), (DateTime)rdr.GetValue(5), T, false);
                Employees.Add(e);
            }
        }
        public static void init_Customers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_Customer";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Customers = new List<Customer>();

            while (rdr.Read())
            {
                Customer cust = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), false);
                Customers.Add(cust);
            }
        }
        public static Customer seekCustomer(string email)
        {
            foreach (Customer c in Customers)
            {
                if (c.Email == email)
                    return c;
            }
            return null;
        }



        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.employeeID == id)
                    return e;
            }
            return null;
        }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            init_Employees();
            init_Customers();
            Application.Run(new Login());
        }
    }
}
