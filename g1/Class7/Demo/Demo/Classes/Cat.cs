using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Cat:Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat constructor");
        }
        ~Cat()
        {
            Console.WriteLine("Cat destructor");
            Console.ReadLine();
        }
    }
}
