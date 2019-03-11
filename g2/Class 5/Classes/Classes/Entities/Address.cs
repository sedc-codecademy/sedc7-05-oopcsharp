using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entities
{
    public class Address
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }

        public Address(string street, int num, int pCode, string city)
        {
            Street = street;
            Number = num;
            PostalCode = pCode;
            City = city;
        }

        public string GetAddress()
        {
            return $"\nAddress: {Street} {Number}, {PostalCode} {City}";
        }
    }
}
