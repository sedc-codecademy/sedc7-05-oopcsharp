using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch2
{
    class Program
    {
        /*
            Da se napishe programa sto kje ovozmozi pretvoranje na dvocifrenite broevi vo zborovi
            na sledniot nacin: Za dvocifreniot broj 89 na ekran kje ispecati "Osum Devet".
        */
        static void Main(string[] args)
        {
            string input;
            Console.Write("Vnesi dvocifren broj:");
            input = Console.ReadLine();
            int broj = int.Parse(input); //parse string -> int
            int prva, vtora;
            prva = broj / 10; // prva cifra
            vtora = broj % 10;  // vtora cifra

            switch (prva)
            {
                case 0:
                    Console.Write("Nula");
                    break;
                case 1:
                    Console.Write("Eden");
                    break;
                case 2:
                    Console.Write("Dva");
                    break;
                case 3:
                    Console.Write("Tri");
                    break;
                case 4:
                    Console.Write("Cetiri");
                    break;
                case 5:
                    Console.Write("Pet");
                    break;
                case 6:
                    Console.Write("Shest");
                    break;
                case 7:
                    Console.Write("Sedum");
                    break;
                case 8:
                    Console.Write("Osum");
                    break;
                case 9:
                    Console.Write("Devet");
                    break;
                default:
                    break;
            }
            Console.Write(" ");
            switch (vtora)
            {
                case 0:
                    Console.WriteLine("Nula");
                    break;
                case 1:
                    Console.WriteLine("Eden");
                    break;
                case 2:
                    Console.WriteLine("Dva");
                    break;
                case 3:
                    Console.WriteLine("Tri");
                    break;
                case 4:
                    Console.WriteLine("Cetiri");
                    break;
                case 5:
                    Console.WriteLine("Pet");
                    break;
                case 6:
                    Console.WriteLine("Shest");
                    break;
                case 7:
                    Console.WriteLine("Sedum");
                    break;
                case 8:
                    Console.WriteLine("Osum");
                    break;
                case 9:
                    Console.WriteLine("Devet");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
