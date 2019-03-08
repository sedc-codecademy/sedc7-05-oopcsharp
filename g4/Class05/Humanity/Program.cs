using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Program
    {
        static void Main(string[] args)
        {
            Human weko = new Human();
            weko.FirstName = "Wekoslav";
            weko.LastName = "Stefanovski";
            weko.Age = 0x29;

            Console.WriteLine(weko.GetStats());
            Console.WriteLine(weko);
        }
    }
}
