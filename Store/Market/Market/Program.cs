using System;

namespace Store
{
    class Store
    {
     public class Seller
        {
            public int MyProperty { get; set; }

            public int year { get; set; }

            public int MyProperty { get; set; }

            

            public string FN;
            public string LN;
            public int Age;
        }
     public class Product
        {
            public string Title;
            public decimal Price;
        }
        static void Main()
        {
            var milk = new Product();

            milk.Title = "Vereia";
            milk.Price = 1;

            var seller = new Seller();

            seller.FN = "Toma";
            seller.LN = "Lazarov";
            seller.Age = 32;

        }
       
    }
}
