using Store.App.Classes;
using System;

namespace Store.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] catalog =
            {
                new Product("Leb", 25.00),
                new Product("Mleko", 45.7),
                new Product("Kafe", 37.5),
                new Product("Jajca", 60)
            };

            Console.WriteLine("Total number of products in catalog is: " + Product.Count());

            var shoppingCart = new Cart();

            shoppingCart.AddItem(catalog[0]);
            shoppingCart.AddItem(catalog[3]);
            shoppingCart.AddItem(catalog[1]);

            shoppingCart.PrintTotalPrice();

            shoppingCart.CheckOut();

            Console.ReadLine();
        }
    }
}
