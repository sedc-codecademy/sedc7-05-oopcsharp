using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetStats()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }
}
