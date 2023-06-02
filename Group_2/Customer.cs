using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_2
{
    public class Customer
    {
        public string Email;
        public string companyName;
        public string zipCode;
        public string phoneNumber;
        
        public Customer(string Email, string companyName, string zipCode, string phoneNumber, bool isNew)
        {
            this.Email = Email;
            this.companyName = companyName;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
        if (isNew)
            this.add_Customer();
            Program.Customers.Add(this);

        }
        public string get_Email()
        {
            return this.Email;
        }
        public string get_CompanyName()
        {
            return this.companyName;
        }
        public string get_ZipCode()
        {
            return this.zipCode;
        }
        public string get_PhoneNumber() {
            return this.zipCode;
         }
        public void set_Email(string Email)
        {
            this.Email = Email;
        }
        public void set_companyName(string CompanyName)
        {
           this.companyName= CompanyName;
        }
        public void set_zipCode(string ZipCode)
        {
            this.zipCode= ZipCode;
        }
        public void set_phoneNumber(string PhoneNumber)
        {
            this.phoneNumber= PhoneNumber; 
        }
        public void add_Customer()
        {
            SQL_CON sqlConn = new SQL_CON();
            SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[add_Customer] @Email, @companyName, @zipCode, @phoneNumber", sqlConn.getConnection());
            cmd.SelectCommand.Parameters.AddWithValue("@Email", this.Email);
            cmd.SelectCommand.Parameters.AddWithValue("@companyName", this.companyName);
            cmd.SelectCommand.Parameters.AddWithValue("@zipCode", this.zipCode);
            cmd.SelectCommand.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sqlConn.Execute_non_query(cmd);
        }
       /* public void updateCustomer()
        { SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.update_Customer @Email, @companyName, @zipCode, @phoneNumber";
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@zipCode", this.zipCode);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void delete_Customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.deleteCustomer  @Email, @companyName, @zipCode, @phoneNumber";
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@zipCode", this.zipCode);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }*/
        

        }
    }

