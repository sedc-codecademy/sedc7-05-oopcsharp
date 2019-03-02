using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an int array in c#
            //int[] myIntArray = new int[3];

            //myIntArray[0] = 5;
            //myIntArray[1] = 56;
            //myIntArray[2] = 77;
            //for (int i = 0; i < myIntArray.Length; i++)
            //{
            //    myIntArray[i] = i + 10;
            //    //Console.WriteLine(myIntArray[i]);
            //}
            //foreach (int num in myIntArray)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(myIntArray[2]);

            string[] words = new string[5];

            words[0] = "first";
            words[1] = "second";
            words[2] = "third";
            words[3] = "fourth";
            words[4] = "fifth";

            double[] doubles = new double[5];

            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = Convert.ToDouble(i) / 2;
            }

            char[] chars = new char[5];

            chars[0] = 'a';
            chars[1] = 'b';
            chars[2] = 'c';
            chars[3] = 'd';
            chars[4] = 'e';

            bool[] booleans = new bool[5] { true, true, false, true, false };

            int[][] arrays = { new int[2] { 2, 4 }, new int[1] { 5 } };

            foreach(string word in words)
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();
            Array.Reverse(words);
            foreach (string word in words)
            {
                Console.Write(word + ", ");
            }

            
            Console.ReadLine();
        }
    }
}
