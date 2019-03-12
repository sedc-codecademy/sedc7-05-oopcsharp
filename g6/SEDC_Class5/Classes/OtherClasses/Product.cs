using System;

namespace Classes.OtherClasses
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Buy(double money)
        {

            if (money >= Price)
            {
                Console.WriteLine($"You just bought a {Name}!");
            }
            else
            {
                Console.WriteLine($"You need {Price - money} more to buy this!");
            }

            Console.ReadLine();
        }
    }
}