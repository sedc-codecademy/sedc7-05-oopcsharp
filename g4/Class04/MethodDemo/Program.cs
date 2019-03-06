using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                #region Parsing input
                bool success;

                char op;
                (op, success) = ReadCharFromConsole("Enter Operation: ");
                if (!success)
                {
                    Console.WriteLine("Entered value is not a valid character");
                    return;
                }

                int first;
                (first, success) = ReadIntFromConsole("Enter first number: ");
                if (!success)
                {
                    Console.WriteLine("Entered value is not a number");
                    return;
                }

                int second;
                (second, success) = ReadIntFromConsole("Enter second number: ");
                if (!success)
                {
                    Console.WriteLine("Entered value is not a number");
                    return;
                }
                #endregion

                if (op == '-')
                {
                    Print(Substract(first, second));
                }
                else if (op == '+')
                {
                    Print(Add(first, second));
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }

                char repeat;
                (repeat, success) = ReadCharFromConsole("Go Again? (Y/n)");

                if (repeat == 'n')
                {
                    break;
                }
            }
        }

        static int Add(int first, int second)
        {
            return first + second;
        }

        static int Substract(int first, int second)
        {
            return first - second;
        }

        static void Print(int x)
        {
            Console.WriteLine($"The value is {x}");
        }

        static (int, bool) ReadIntFromConsole(string message = "")
        {
            if (!String.IsNullOrEmpty(message))
            {
                Console.Write(message);
            }
            var input = Console.ReadLine();
            var parseResult = int.TryParse(input, out int result);
            if (!parseResult)
            {
                return (0, false);
            }
            return (result, true);
        }

        static (char, bool) ReadCharFromConsole(string message = "")
        {
            if (!String.IsNullOrEmpty(message))
            {
                Console.Write(message);
            }
            var input = Console.ReadLine();
            var parseResult = char.TryParse(input, out char result);
            if (!parseResult)
            {
                return ('\0', false);
            }
            return (result, true);
        }
    }
}
