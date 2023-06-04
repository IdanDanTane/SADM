using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    internal class Material
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

        public Material(string id,string name, decimal price,decimal threshold, Mstatus status, Warehouse loc, DateTime recived,DateTime exp, decimal amount, bool isNew)
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
            if(isNew)
            {
                Program.Materials.Add(this);
            }
        }
    }
}
