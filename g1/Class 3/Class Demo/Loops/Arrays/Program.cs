using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5]; //Declaring Array
            string[] denovi = { "pon", "vto", "sre", "cet", "pet", "sab", "ned" };

            //Initializing array
            num[1] = 23;
            num[2] = 12;
            num[3] = 9;
            num[0] = 6;            
            num[4] = 19;

            //Showing value of Array  \t is Horizontal tab
            Console.WriteLine("1st value:\t{0}\t {1}", num[0],denovi[0]);
            Console.WriteLine("2nd value:\t{0}\t {1}", num[1],denovi[1]);
            Console.WriteLine("3rd value:\t{0}\t {1}", num[2],denovi[2]);
            Console.WriteLine("4th value:\t{0}\t {1}", num[3],denovi[3]);
            Console.WriteLine("5th value:\t{0}\t {1}", num[4],denovi[4]);

            Console.ReadLine();
        }
    }
}
