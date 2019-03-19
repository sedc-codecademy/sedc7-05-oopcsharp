using System;
using System.Collections.Generic;

namespace Class08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ListDemo
            List<string> names = new List<string>();
            names.Add("Risto");
            names.Add("Martin");
            names.Add("Bojan");

            names.Remove("Martin");
            names.RemoveAt(1);

            List<int> ages = new List<int>()
            {
                1,
                2,
                3,
                4
            };

            List<int> copy_ages = new List<int>(ages);

            copy_ages.AddRange(new List<int> { 5, 6, 7, 8 });

            int count = copy_ages.Count;

            Console.WriteLine(copy_ages);

            foreach (var age in copy_ages)
            {
                Console.WriteLine(age);
            }

            copy_ages.ForEach(Console.WriteLine);

            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "juice",
                    Price = 100
                },
                new Product()
                {
                    Name = "tomato",
                    Price = 30
                }
            };

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.Price}");
            }
            #endregion

            #region DictionaryDemo

            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Risto", 29);
            students.Add("Martin", 25);


            Dictionary<string, int> trainers = new Dictionary<string, int>()
            {
                {"Risto", 29 },
                {"Martin", 29 }
            };

            bool exists = students.ContainsKey("Risto");


            Dictionary<string, List<Product>> market = new Dictionary<string, List<Product>>()
            {
                {"Risto", new List<Product> {new Product {Name = "tomato", Price = 300}}}
            };

            Dictionary<User, List<Product>> market2 = new Dictionary<User, List<Product>>();
            market2.Add(new User
            {
                FirstName = "Risto",
                LastName = "Panchevski"
            }, new List<Product> { new Product { Name = "tomato", Price = 300 } });

            Dictionary<string, List<string>> students2 = new Dictionary<string, List<string>>();
            students2.Add("Risto", new List<string> { "Basic C#", "Advance C#", "AJs" });

            List<string> courses = students2["Risto"];

            List<string> result;
            bool keyExists = students2.TryGetValue("Risto", out result);

            foreach (KeyValuePair<string, List<string>> student in students2)
            {
                Console.WriteLine($"Key: {student.Key}");

                foreach (string course in student.Value)
                {
                    Console.WriteLine($"Course: {course}");
                }
            }

            #endregion

            #region QueueDemo

            Queue<int> ticketNumber = new Queue<int>();
            ticketNumber.Enqueue(1);
            ticketNumber.Enqueue(2);
            ticketNumber.Enqueue(3);

            while (ticketNumber.Count != 0)
            {
                int ticket =
                    ticketNumber.Dequeue();

                Console.WriteLine(ticket);
            }
            #endregion

            #region StackDemo

            Stack<int> ticketsNumber = new Stack<int>();
            ticketsNumber.Push(1);
            ticketsNumber.Push(2);
            ticketsNumber.Push(3);

            while (ticketsNumber.Count != 0)
            {
                int ticket =
                    ticketsNumber.Pop();

                Console.WriteLine(ticket);
            }

            #endregion


            Console.Read();
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
        }
    }
}
