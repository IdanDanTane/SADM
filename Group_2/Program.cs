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
        public static System.Collections.Generic.List<Shift> Shifts;
        public static System.Collections.Generic.List<Fault> Faults;
        public static System.Collections.Generic.List<ShiftReport> ShiftReports;
        public static System.Collections.Generic.List<ProductionRequirement> productionRequirements;
        public static System.Collections.Generic.List<Forecast> Forecasts;
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
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), (DateTime)rdr.GetValue(5), T, false ,false);
                Employees.Add(e);
            }
            c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_employeeArchive";
             SC = new SQL_CON();
            rdr = SC.Execute_query(c);
            while (rdr.Read())
            {
                employeeType T = (employeeType)Enum.Parse(typeof(employeeType), rdr.GetValue(6).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), (DateTime)rdr.GetValue(5), T, true, false);
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
                Customer cust = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), false,false);
                Customers.Add(cust);
            }
             c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.view_CustomerArchive";
             SC = new SQL_CON();
            rdr = SC.Execute_query(c);
            while (rdr.Read())
            {
                Customer cust = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(),true ,false);
                Customers.Add(cust);
            }
        }
        public static void init_Shifts()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewShifts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Shifts = new List<Shift>();

            while (rdr.Read())
            {
                Shift s = new Shift((int)rdr.GetValue(0), (DateTime)rdr.GetValue(1), false);
                Shifts.Add(s);
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
                Material m = new Material(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (decimal)rdr.GetValue(2), (decimal)rdr.GetValue(3), S, W, (DateTime)rdr.GetValue(6), (DateTime)rdr.GetValue(7), (decimal)rdr.GetValue(8),false ,false);
                Materials.Add(m);
            }
             c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_MaterialArchive";
             SC = new SQL_CON();
             rdr = SC.Execute_query(c);



            while (rdr.Read())
            {
                Mstatus S = (Mstatus)Enum.Parse(typeof(Mstatus), rdr.GetValue(4).ToString());
                Warehouse W = (Warehouse)Enum.Parse(typeof(Warehouse), rdr.GetValue(5).ToString());
                Material m = new Material(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (decimal)rdr.GetValue(2), (decimal)rdr.GetValue(3), S, W, (DateTime)rdr.GetValue(6), (DateTime)rdr.GetValue(7), (decimal)rdr.GetValue(8), true, false);
                Materials.Add(m);
            }
        }
        public static void init_Faults()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewFaults";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Faults = new List<Fault>();

            while (rdr.Read())
            { 
                MachineType M = (MachineType)Enum.Parse(typeof(MachineType), rdr.GetValue(1).ToString());
                FaultType f = (FaultType)Enum.Parse(typeof(FaultType), rdr.GetValue(2).ToString());
                Urgency u = (Urgency)Enum.Parse(typeof(Urgency), rdr.GetValue(3).ToString());
                FaultStatus fs = (FaultStatus)Enum.Parse(typeof(FaultStatus), rdr.GetValue(4).ToString());
                Fault fa = new Fault(M, f, u, fs, false);
                Faults.Add(fa);
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

                ProductType T = (ProductType)Enum.Parse(typeof(ProductType), rdr.GetValue(4).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (DateTime)rdr.GetValue(2),(decimal) rdr.GetValue(3),T ,false,false);
                Procducts.Add(p);
            }
             c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_ProductArchive";
             SC = new SQL_CON();
             rdr = SC.Execute_query(c);



            while (rdr.Read())
            {

                ProductType T = (ProductType)Enum.Parse(typeof(ProductType), rdr.GetValue(4).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), (DateTime)rdr.GetValue(2), (decimal)rdr.GetValue(3), T, true, false);
                Procducts.Add(p);
            }
        }
        public static void init_ShiftReport()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewShiftReports";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            ShiftReports = new List<ShiftReport>();

            while (rdr.Read())
            {

                ShiftReport SR = new ShiftReport(rdr.GetValue(0).ToString(), false);
                ShiftReports.Add(SR);
            }
        }
        public static void init_ProductionRequirement()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewProduction";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            productionRequirements = new List<ProductionRequirement>();

            while (rdr.Read())
            {


                OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(4).ToString());
                ProductionRequirement PR = new ProductionRequirement(rdr.GetValue(0).ToString(), (DateTime)rdr.GetValue(1), (DateTime)rdr.GetValue(2), (decimal)rdr.GetValue(3), os, false);
                productionRequirements.Add(PR);
            }
        }
        public static void init_Forecast()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ViewForecast";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            Forecasts = new List<Forecast>();

            while (rdr.Read())
            {

                Forecast F = new Forecast((DateTime)rdr.GetValue(1), (DateTime)rdr.GetValue(2), false);
                Forecasts.Add(F);
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
            init_Shifts();
            init_Faults();
            init_ShiftReport();
            init_ProductionRequirement();
            init_Forecast();
            Application.Run(new Login());
        }

        

        public static Product seekProduct(string id)
        {
            foreach (Product P in Procducts)
            {
                if (P.Id == id)
                    return P;
            }
            return null;
        }

        public static ProductionRequirement seekProduction(string id)
        {
            foreach (ProductionRequirement PR in productionRequirements)
            {
                if (PR.ID == id)
                    return PR;
            }
            return null;
        }
    }
}
