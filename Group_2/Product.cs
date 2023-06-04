using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    internal class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DateTime expirationDate { get; set; }

        public decimal pricePerTon { get; set; }

        public Dictionary<Material,decimal> componenets { get; set; }

        public Product(string id, string name, DateTime expDate, decimal price, bool isNew) { 
        this.Id = id;
            this.Name = name;
            this.expirationDate = expDate;
            this.pricePerTon = price;
            if(isNew )
            {
                Program.Procducts.Add( this ); 
            }
        }



    }
}
