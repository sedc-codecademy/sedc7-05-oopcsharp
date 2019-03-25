using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region ListDemo
            //List<string> names = new List<string>();
            //names.Add("Risto");
            //names.Add("Martin");
            //names.Add("Bojan");

            //names.Remove("Martin");
            //names.RemoveAt(1);

            //List<int> ages = new List<int>()
            //{
            //    1,
            //    2,
            //    3,
            //    4
            //};

            //List<int> copy_ages = new List<int>(ages);

            //copy_ages.AddRange(new List<int> { 5, 6, 7, 8 });

            //int count = copy_ages.Count;

            //Console.WriteLine(copy_ages);

            //foreach (var age in copy_ages)
            //{
            //    Console.WriteLine(age);
            //}

            //copy_ages.ForEach(Console.WriteLine);

            //List<Product> products = new List<Product>
            //{
            //    new Product("Tomato", 60, "TO1234", "Vegetable"),
            //    new Product("Cheese", 260, "TO1222", "Milk products")
            //};

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name} {product.Price}");
            //}
            //#endregion

            //#region DictionaryDemo

            //Dictionary<string, int> students = new Dictionary<string, int>();
            //students.Add("Risto", 29);
            //students.Add("Martin", 25);


            //Dictionary<string, int> trainers = new Dictionary<string, int>()
            //{
            //    {"Risto", 29 },
            //    {"Martin", 29 }
            //};

            //bool exists = students.ContainsKey("Risto");


            //Dictionary<string, List<Product>> market = new Dictionary<string, List<Product>>()
            //{
            //    {"Risto", new List<Product> {new Product("Tomato", 60, "TO1234", "Vegetable"),
            //        new Product("Cheese", 260, "TO1222", "Milk products")}}
            //};

            //Dictionary<User, List<Product>> market2 = new Dictionary<User, List<Product>>();
            //market2.Add(new User
            //{
            //    FirstName = "Risto",
            //    LastName = "Panchevski"
            //}, new List<Product> { new Product("Tomato", 60, "TO1234", "Vegetable"),
            //    new Product("Cheese", 260, "TO1222", "Milk products") });

            //Dictionary<string, List<string>> students2 = new Dictionary<string, List<string>>();
            //students2.Add("Risto", new List<string> { "Basic C#", "Advance C#", "AJs" });

            //List<string> courses = students2["Risto"];

            //List<string> result;
            //bool keyExists = students2.TryGetValue("Risto", out result);

            //foreach (KeyValuePair<string, List<string>> student in students2)
            //{
            //    Console.WriteLine($"Key: {student.Key}");

            //    foreach (string course in student.Value)
            //    {
            //        Console.WriteLine($"Course: {course}");
            //    }
            //}

            //#endregion

            //#region QueueDemo

            //Queue<int> ticketNumber = new Queue<int>();
            //ticketNumber.Enqueue(1);
            //ticketNumber.Enqueue(2);
            //ticketNumber.Enqueue(3);

            //while (ticketNumber.Count != 0)
            //{
            //    int ticket =
            //        ticketNumber.Dequeue();

            //    Console.WriteLine(ticket);
            //}
            //#endregion

            //#region StackDemo

            //Stack<int> ticketsNumber = new Stack<int>();
            //ticketsNumber.Push(1);
            //ticketsNumber.Push(2);
            //ticketsNumber.Push(3);

            //while (ticketsNumber.Count != 0)
            //{
            //    int ticket =
            //        ticketsNumber.Pop();

            //    Console.WriteLine(ticket);
            //}

            //#endregion

            #region LinqDemo

            List<Product> marketProducts = Market.Products;

            List<Product> vegetableProducts = marketProducts.Where(product => product.Category == "Vegetable").ToList();

            PrintProducts(vegetableProducts);

            List<Product> higher100Products = marketProducts.Where(product => product.Price > 100 && product.Price < 500 && product.Category == "Milk products").ToList();

            PrintProducts(higher100Products);

            Product firstMilkProduct = marketProducts.First(x => x.Category == "Milk products");

            Console.WriteLine($"{firstMilkProduct.Name}");

            Product lastMilkProduct = marketProducts.Last(x => x.Category == "Milk products");

            Console.WriteLine($"{lastMilkProduct.Name}");

            //Product nonexistingProduct = marketProducts.First(x => x.Category == "AAA");

            Product nonexistingProduct = marketProducts.FirstOrDefault(x => x.Category == "AAA");
            Product nonexistingProduct2 = marketProducts.FirstOrDefault(x => x.Category == "AAA");

            bool exists = marketProducts.Any(x => x.Category == "Meat");
            double sum = marketProducts.Average(x => x.Price);


            Product singleProduct = marketProducts.Single(x => x.Category == "Milk products");





            #endregion
            Console.Read();
        }

        public static void PrintProducts(List<Product> products)
        {
            List<string> productNames = products.Select(x => x.Name).ToList();

            Console.WriteLine($"Products: {string.Join(", ", productNames)}");
        }


    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Barcode { get; set; }
        public string Category { get; set; }

        public Product(string name, int price, string barcode, string category)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Category = category;
        }
    }

    public static class Market
    {
        public static List<Product> Products { get; set; }

        static Market()
        {
            Products = new List<Product>
                {
                    new Product("Tomato", 60, "TO1234", "Vegetable"),
                    new Product("Cheese", 260, "TO1222", "Milk products"),
                    new Product("Potatoes", 50, "TO1233", "Vegetable"),
                    new Product("Chicken", 150, "TO1236", "Meat"),
                    new Product("Pork", 300, "TO1237", "Meat"),
                    new Product("Bread", 30, "TO1238", "Bread"),
                    new Product("Cake", 200, "TO1239", "Desert"),
                    new Product("Beef", 1000, "TO1231", "Meat"),
                    new Product("Fish", 500, "TO1242", "Meat"),
                    new Product("Milk", 50, "TO1246", "Milk products"),
                    new Product("Apple", 40, "TO1255", "Fruit"),
                    new Product("Strawberry", 90, "TO1277", "Fruit"),
                    new Product("Cabbage", 30, "TO1288", "Vegetable"),
                    new Product("Beer", 45, "TO1299", "Drink"),
                    new Product("Coca Cola", 70, "TO1299", "Drink"),
                    new Product("Cheese Cake", 45, "TO1299", "Desert")
                };
        }
    }
}
