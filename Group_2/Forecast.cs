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
        public Dictionary<Material, decimal> futureMaterials = new Dictionary<Material, decimal>();
        public static int serialNum = 1;
        public Dictionary<Product, decimal> futureProducts = new Dictionary<Product, decimal>();

        public Forecast(DateTime startDate, DateTime endDate, bool isNew)
        {
            this.ID = Forecast.serialNum;
            this.startDate = startDate;
            this.endDate = endDate;
            Forecast.serialNum++;
            if (isNew)
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
        public void calculateForecast()
        {
            TimeSpan Period;
            Period = this.endDate - startDate;
            foreach (Product p in this.futureProducts.Keys.ToList())
            {
                foreach (ProductionRequirement PR in Program.productionRequirements)
                {
                    if (PR.toProduce.ContainsKey(p))
                    {
                        this.futureProducts[p] += PR.toProduce[p];
                    }
                }
            }
            DateTime firstPRdate = Program.productionRequirements.Min(a => a.createDate);
            TimeSpan totalPeriod = DateTime.Now - firstPRdate;
            foreach (Product p in this.futureProducts.Keys.ToList())
            {
                this.futureProducts[p] = this.futureProducts[p] * Period.Days / totalPeriod.Days;
            }
            foreach (Product p in this.futureProducts.Keys)
            {
                SQL_CON SC = new SQL_CON();
                SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[AddForecastProduct] @FID, @PID, @Amount", SC.getConnection());
                r.SelectCommand.Parameters.AddWithValue("@FID", this.ID);
                r.SelectCommand.Parameters.AddWithValue("@PID", p.Id);
                r.SelectCommand.Parameters.AddWithValue("@Amount", this.futureProducts[p]);
                SC.Execute_non_query(r);
            }
            this.addToFutureMat();
            foreach (Material m in this.futureMaterials.Keys)
            {
                SQL_CON SC = new SQL_CON();
                SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[AddForecastMaterial] @FID, @MID, @Amount", SC.getConnection());
                r.SelectCommand.Parameters.AddWithValue("@FID", this.ID);
                r.SelectCommand.Parameters.AddWithValue("@MID", m.Id);
                r.SelectCommand.Parameters.AddWithValue("@Amount", this.futureMaterials[m]);
                SC.Execute_non_query(r);
            }


        }

        public void addToFutureMat()
        {
            foreach (Product p in this.futureProducts.Keys)
            {
                foreach (Material m in p.componenets.Keys)
                {
                    if (futureMaterials .ContainsKey(m))
                    {
                        this.futureMaterials[m] += p.componenets[m] * futureProducts[p];
                    }
                    else
                    {
                        this.futureMaterials.Add(m, p.componenets[m] * futureProducts[p]);
                    }
                }
            }
        }
    }
}
