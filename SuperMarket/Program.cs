using Store_Library;
using System;

namespace SuperMarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress("Sofia", "Slatinska", "46", "1574");

            Store store = new Store("Lidl", 864.25, adress);

            Owner owner = new Owner("Toma Lazazrov", 32);

            Experience exp = new Experience(2, 5, 3);

            Seller seller = new Seller("Ivan", 30, exp);

            Products product1 = new Products("tomatoes", 5, 1);
            Products product2 = new Products("cheese", 8, 0.400);
            Products product3 = new Products("olives", 6, 0.550);



        }
    }
}
