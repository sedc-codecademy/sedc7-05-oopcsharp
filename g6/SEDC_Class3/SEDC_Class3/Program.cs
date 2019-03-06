using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC_Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============================For loop 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //===============================While loop
            //int t = 20;
            //int temp = 10;
            //while (t < 20)
            //{
            //    temp++;
            //}

            //do
            //{
            //    temp--;
            //} while (t < 20);

            //Console.WriteLine(temp);

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    int result;

            //    bool parseIsValid = Int32.TryParse(input, out result);

            //    if (parseIsValid)
            //    {
            //        Console.WriteLine(result);
            //        break;
            //    }
            //}

            //int inputNumber;

            //===============================Example of infinit loop (until the user enter the right input)
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    bool isSuccess = Int32.TryParse(input, out inputNumber);

            //    if (isSuccess)
            //    {
            //        break;
            //    }
            //}

            //===============================Arrays declaring and initialization
            //int[] integerArray;

            //integerArray = new int[6];

            //int[] integerArray2 = new int[5] {1, 5, 6, 7, 9};

            //bool[] boolArray = new bool[5] {false, true, false, false, true};

            //integerArray[0] = 1;
            //integerArray[1] = 10;

            //if (boolArray[3])
            //{
            //    Console.WriteLine("This code will not be executed because boolArray[3] element is false");
            //}

            //===============================Example of IndexOf method 
            //Array.IndexOf(integerArray2, 0);

            //Console.Write(boolArray.Length);

            //===============================Example of using Resize() method
            //Array.Resize(ref boolArray, boolArray.Length + 1);

            //foreach (int element in integerArray2)
            //{
            //    Console.WriteLine(element);
            //}

            //===============================Exercise 1
            //int firstNumber;
            //int secondNumber;

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    bool isSuccess = Int32.TryParse(input, out firstNumber);

            //    if (isSuccess)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 1; i <= firstNumber; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    bool isSuccess = Int32.TryParse(input, out secondNumber);

            //    if (isSuccess)
            //    {
            //        break;
            //    }
            //}

            //for (int i = secondNumber; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //===============================Exercise 2
            //int firstNumber;
            //int secondNumber;

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    bool isSuccess = Int32.TryParse(input, out firstNumber);

            //    if (isSuccess)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 1; i <= firstNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    bool isSuccess = Int32.TryParse(input, out secondNumber);

            //    if (isSuccess)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 1; i <= secondNumber; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //===========================================Exercise 3
            //int inputNumber;
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    bool isSuccess = Int32.TryParse(input, out inputNumber);

            //    if (isSuccess)
            //    {
            //        break;
            //    }
            //}
            //int counter = 0;
            //for (int i = 1; i < inputNumber; i++)
            //{
            //    if (i % 3 == 0 || i % 7 == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine("Number: " + i);
            //    counter++;

            //    if (counter == 100)
            //    {
            //        Console.WriteLine("Limit is reached");
            //        break;
            //    }
            //}

            //===========================================Exercise 4
            //string[] stringArray = new string[5];
            //double[] doubleArray = new double[5];
            //char[] charArray = new char[5];
            //bool[] booleanArray = new bool[5];
            //int[,] twoDimensionalArray = new int[5,2];

            /*Exercise 5*/
            //int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Int32.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Sum: " + sum);

            //===========================================Exercise 5
            //int[] arrayOfNumbers = new int[5];
            //int counter = 0;
            //int sum = 0;

            //while (counter < arrayOfNumbers.Length)
            //{
            //    Console.WriteLine("Please enter the " + counter + " element of the array");
            //    int element = Convert.ToInt32(Console.ReadLine());
            //    arrayOfNumbers[counter] = element;
            //    counter++;
            //}

            //foreach (int item in arrayOfNumbers)
            //{
            //    //Make sure that the array has elements inside
            //    if(arrayOfNumbers.Length > 0)
            //    {
            //        sum += item;
            //    }
            //    else
            //    {
            //    //Show message if the array is empty and the sum cannot be calculated
            //        Console.WriteLine("Something went wrong, the array is empty");
            //    }
            //}
            //Console.WriteLine("The sum of the inserted numbers is: " + sum);

            //Console.ReadLine();
        }
    }
}
