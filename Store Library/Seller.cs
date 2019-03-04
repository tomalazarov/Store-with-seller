using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Library
{
    public class Seller
    {
        public string Name;
        public int Age;

        public Experience SellerExp;

        public Seller(string name, int age, Experience sellerExp)
        {
            this.Name = name; 
            this.Age = age;
            this.SellerExp = sellerExp;
        }
        
    }
}
