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
        public static System.Collections.Generic.List<Product> Procducts;
        public static System.Collections.Generic.List<Material> Materials;
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
        public static void init_Materials()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewMaterial";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Materials = new List<Material>();

            while (rdr.Read())
            {
                Mstatus S = (Mstatus)Enum.Parse(typeof(Mstatus), rdr.GetValue(4).ToString());
                Warehouse W = (Warehouse)Enum.Parse(typeof(Warehouse), rdr.GetValue(5).ToString());
                Material m = new Material(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (decimal)rdr.GetValue(2), (decimal)rdr.GetValue(3), S,W, (DateTime)rdr.GetValue(6), (DateTime)rdr.GetValue(7), (decimal)rdr.GetValue(8), false);
                Materials.Add(m);
            }
        }
        public static void init_Products()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewProduct";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Procducts = new List<Product>();

            while (rdr.Read())
            {
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (DateTime)rdr.GetValue(2),(decimal) rdr.GetValue(3), false);
                Procducts.Add(p);
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
        public static Material seekMaterial(string ID)
        {
            foreach (Material c in Materials)
            {
                if (c.Id == ID)
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
            init_Materials();
            init_Products();
            Application.Run(new Login());
        }
    }
}
