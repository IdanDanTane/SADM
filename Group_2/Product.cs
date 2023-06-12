using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public class Product
    {
        public ProductType ProductType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public DateTime expirationDate { get; set; }

        public decimal pricePerTon { get; set; }

        public bool inArchive;

        public Dictionary<Material, decimal> componenets { get; set; }

        
        public Product( string id, string name, DateTime expDate, decimal price, ProductType Type, bool inArchive, bool isNew)
        {
            this.Id = id;
            this.Name = name;
            this.expirationDate = expDate;
            this.pricePerTon = price;
            this.GetMaterials();
            this.ProductType = Type;
            this.inArchive = inArchive;
            if (isNew)
            {
                this.createProduct();
                
                Program.Procducts.Add(this);
            }
        }
        public override string ToString()
        {
            return this.Id;
        }

        private void createProduct()
        {
            SQL_CON sqlConn = new SQL_CON();
            
            SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[AddProduct] @productId, @name, @expirationDate, @pricePerTone, @Type", sqlConn.getConnection());
            cmd.SelectCommand.Parameters.AddWithValue("@Type", this.ProductType.ToString());
            cmd.SelectCommand.Parameters.AddWithValue("@productId", this.Id);
            cmd.SelectCommand.Parameters.AddWithValue("@name", this.Name);
            string newDateTime = this.expirationDate.ToString("yyyy-MM-dd");
            cmd.SelectCommand.Parameters.AddWithValue("@expirationDate", newDateTime);
            cmd.SelectCommand.Parameters.AddWithValue("@pricePerTone", this.pricePerTon);
            sqlConn.Execute_non_query(cmd);
        }

        public void GetMaterials()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_ProductMaterial @ProductID";
            c.Parameters.AddWithValue("@ProductID", this.Id);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.Execute_query(c);

            componenets = new Dictionary<Material, decimal>();

            while (rdr.Read())
            {
                componenets.Add(Program.seekMaterial(rdr.GetValue(1).ToString()), (decimal)rdr.GetValue(2));
            }
        }




    }
}
