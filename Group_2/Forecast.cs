using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    public class Forecast
    {
        public int ID;
        public DateTime startDate;
        public DateTime endDate;
        public Dictionary<Material, decimal> futureProducts = new Dictionary<Material, decimal>();
        public static int serialNum = 1;
        public Dictionary<Product, decimal> futureMaterials { get; set; }

        public Forecast(DateTime startDate, DateTime endDate, bool isNew) {
            this.ID = Forecast.serialNum;
            this.startDate = startDate;
            this.endDate = endDate;
            Forecast.serialNum++;
            if (isNew )
            {
                this.CreateForecast();
                Program.Forecasts.Add(this);
            }
        }
        private void CreateForecast()
        {

            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[AddForecast] @ID, @startDate, @EndDate", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@ID", this.ID);
            string newDateTime = this.startDate.ToString("yyyy-MM-dd");
            r.SelectCommand.Parameters.AddWithValue("@startDate", newDateTime);
            newDateTime = this.endDate.ToString("yyyy-MM-dd");
            r.SelectCommand.Parameters.AddWithValue("@endDate", newDateTime);
            SC.Execute_non_query(r);
        }
    }
}
