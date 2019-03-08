using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entities
{
    public class Address
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void PrintAdress()
        {
            Console.WriteLine($"Address Name: {Name}");
            Console.WriteLine($"Address Number: {Number}");
        }
    }
}
