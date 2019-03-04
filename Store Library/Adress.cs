using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Library
{
    public class Adress
    {
        public string City;
        public string Street;
        public string Number;
        public string Postcode;

        public Adress(string city, string street, string number, string postcode)
        {
            this.City = city;
            this.Street = street;
            this.Number = number;
            this.Postcode = postcode;
        }
    }
}
