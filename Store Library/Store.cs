using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Library
{
    public class Store
    {
        public string Name;
        public double Size;
        public Adress Adress;
        public List<Products> Products;
        public Seller Seller; 
        public Owner Owner;

        public Store(string name, double size, Adress adress)
        {
            this.Name = name;
            this.Size = size;
            this.Adress = adress;
        }

    


        

    }
}
