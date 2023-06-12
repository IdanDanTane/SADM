using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public class ProductionRequirement
    {
        public string ID;
        public DateTime createDate;
        public DateTime targetDate;
        public decimal price;
        public OrderStatus status;
        public Dictionary<Material, decimal> ProComponenets = new Dictionary<Material, decimal>();
        public Dictionary<Product, decimal> toProduce { get; set; }


        public ProductionRequirement(string ID, DateTime createDate, DateTime targetDate, decimal price, OrderStatus status, bool isNew)
        {
            this.ID = ID;
            this.createDate = createDate;
            this.targetDate = targetDate;
            this.price = price;
            this.status = status;
            this.GetProducts();
            this.GetMaterials();
            if (isNew)
            {
                this.CreateProductionRequirement();
                Program.productionRequirements.Add(this);
            }
        }

        private void CreateProductionRequirement()
        {

            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[AddProduction] @ID, @createDate, @targetDate, @price, @orderStatus ", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@ID", this.ID);
            string newDateTime = this.createDate.ToString("yyyy-MM-dd");
            r.SelectCommand.Parameters.AddWithValue("@creationDate", newDateTime);
            newDateTime = this.targetDate.ToString("yyyy-MM-dd");
            r.SelectCommand.Parameters.AddWithValue("@TargetDate", newDateTime);
            r.SelectCommand.Parameters.AddWithValue("@price", this.price);
            r.SelectCommand.Parameters.AddWithValue("@orderStatus", this.status.ToString());
            SC.Execute_non_query(r);
        }

        public void GetMaterials()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_ProductionMaterial @prID";
            c.Parameters.AddWithValue("@prID", this.ID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            

            while (rdr.Read())
            {
                this.ProComponenets.Add(Program.seekMaterial(rdr.GetValue(1).ToString()), (decimal)rdr.GetValue(2));
            }
        }
        public void GetProducts()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_ProductionProduct @prID";
            c.Parameters.AddWithValue("@prID", this.ID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            toProduce = new Dictionary<Product, decimal>();

            while (rdr.Read())
            {
                toProduce.Add(Program.seekProduct(rdr.GetValue(1).ToString()), (decimal)rdr.GetValue(2));
            }
        }

        public void addToProComp()
        {
            foreach (Product p in this.toProduce.Keys)
            {
                foreach (Material m in p.componenets.Keys)
                {
                    if (ProComponenets.ContainsKey(m))
                    {
                        this.ProComponenets[m] += p.componenets[m] * toProduce[p];
                    }
                    else
                    {
                        this.ProComponenets.Add(m, p.componenets[m] * toProduce[p]);
                    }
                }
            }
            foreach (Material m in this.ProComponenets.Keys) {
                SQL_CON sqlConn = new SQL_CON();
                SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[Add_ProductionMaterial]  @prID, @mid, @amount", sqlConn.getConnection());
                cmd.SelectCommand.Parameters.AddWithValue("@prID", this.ID);
                cmd.SelectCommand.Parameters.AddWithValue("@mid", m.Id);
                cmd.SelectCommand.Parameters.AddWithValue("@amount", ProComponenets[m]);
                sqlConn.Execute_non_query(cmd);
            }
        }
    }
}

