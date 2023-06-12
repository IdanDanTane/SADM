using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    public class Material
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public decimal pricePerTon { get; set; }

        public decimal minimumThreshold { get; set; }

        public Mstatus Status { get; set; }

        public Warehouse Location { get; set; }

        public DateTime recivedDate { get; set; }

        public DateTime expirationDate  { get; set; }

        public decimal amount { get; set; }

        public bool inArchive;

        public Material(string id,string name, decimal price,decimal threshold, Mstatus status, Warehouse loc, DateTime recived,DateTime exp, decimal amount, bool inArchive, bool isNew)
        {
            this.Id = id;
            this.Name = name;
            this.pricePerTon = price;
            this.minimumThreshold = threshold;
            this.Status = status;
            this.Location = loc;
            this.recivedDate = recived;
            this.expirationDate = exp;
            this.amount = amount;
            this.inArchive = inArchive;
            if(isNew)
            {
                this.createMaterial();
                Program.Materials.Add(this);
            }
        }

        private void createMaterial()
        {

            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[AddMaterial] @MaterialID, @Name, @PricePerTone , @MinimumThreshold, @Status, @Location, @ReceivedDate , @ExpirationDate ,@Amount", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@MaterialID", this.Id);
            r.SelectCommand.Parameters.AddWithValue("@Name", this.Name);
            r.SelectCommand.Parameters.AddWithValue("@PricePerTone", this.pricePerTon);
            r.SelectCommand.Parameters.AddWithValue("@MinimumThreshold", this.minimumThreshold);
            r.SelectCommand.Parameters.AddWithValue("@Status", this.Status.ToString());
            r.SelectCommand.Parameters.AddWithValue("@Location", this.Location.ToString());
            string newDateTime = this.recivedDate.ToString("yyyy-MM-dd");
            r.SelectCommand.Parameters.AddWithValue("@ReceivedDate", newDateTime);
            newDateTime = this.expirationDate.ToString("yyyy-MM-dd");
            r.SelectCommand.Parameters.AddWithValue("@ExpirationDate", newDateTime);
            r.SelectCommand.Parameters.AddWithValue("@Amount", this.amount);
            SC.Execute_non_query(r);
        }
    }
}
