using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5]; //Declaring Array of strings
            students[0] = "Boban";
            students[1] = "Tina";
            students[2] = "Bisera";
            students[3] = "Dejan";
            students[4] = "Dimitar";
                        
            foreach(string student in students)
            {
                Console.WriteLine("Hello {0}", student);                
            } 
            Array.Sort(students);
            Console.WriteLine("The array sorted:");
            foreach (string name in students)
            {
                Console.WriteLine("Hello {0}", name);
            }
            Console.WriteLine("The array sorted descending:");
            Array.Reverse(students);
            foreach (string name in students)
            {
                Console.WriteLine("Hello {0}", name);
            }
            Console.ReadLine();
        }
    }
}
