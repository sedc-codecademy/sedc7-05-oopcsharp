using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string caseSwitch;
            Console.WriteLine("Meni options:");
            Console.WriteLine("1. Math");
            Console.WriteLine("2. Informatics");
            Console.WriteLine("3. Business");
            Console.WriteLine("4. Languages");
            caseSwitch = Console.ReadLine();
            int intSwitch = int.Parse(caseSwitch);
            switch (intSwitch)
            {
                case 1:
                    Console.WriteLine("You've chosen Maths.");
                    break;
                case 2:
                    Console.WriteLine("You've chosen Informatics.");
                    break;
                case 3:
                    Console.WriteLine("You've chosen Business.");
                    break;
                case 4:
                    Console.WriteLine("You've chosen Languages.");
                    break;
                default:
                    Console.WriteLine("No option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
