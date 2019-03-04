using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Library
{
   public class Products
    {
        public string Name;
        public decimal Price;
        public double Weight;
        

        public Products(string name, decimal price, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }
    }
}
