using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    public class ShiftReport
    {
        public int shiftID;
        public Dictionary<Product, decimal> produced { get; set; }

        public ShiftReport(int shiftID, bool isNew)
        {
            this.shiftID = shiftID;
            if (isNew)
            {
                Program.ShiftReports.Add(this);
            }
            else
            {
                this.GetProducts();
            }
        }

       

      
        public void GetProducts()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_ShiftProduct @ShiftID";
            c.Parameters.AddWithValue("@ShiftID", this.shiftID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            produced = new Dictionary<Product, decimal>();

            while (rdr.Read())
            {
                produced.Add(Program.seekProduct(rdr.GetValue(1).ToString()), (decimal)rdr.GetValue(2));
            }
        }

    }

}
