using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassDemoExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            string[] words = new string[4];
            string[] names = new string[] { "Ivan", "Maja", "Vlado" };

            var numberOfWords = words.Length;


            // ArrayList (Accepts all types and does not have constraint on number of elements)
            //using System.Collections;
            ArrayList differentValueTypes = new ArrayList();
            differentValueTypes.Add("Hello");
            differentValueTypes.Add(100);
            differentValueTypes.Add('a');
            differentValueTypes.Remove(100);
            differentValueTypes.Remove(new DateTime());

            ArrayList otherWordsAndValues = new ArrayList() { "Worlds", "is", "mine", 100, "percent" };

            var howManyValues = otherWordsAndValues.Count;



            // List (Has designated type and does not have constraint on number of elements)
            //using System.Collections.Generic;
            List<string> series = new List<string>();
            series.Add("Mr. Robot");
            series.Add("Grey`s Anatomy");
            series.Add("Black Mirror");

            List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 100 };
            numbers.Add(90);
            numbers.Remove(20);
            Console.WriteLine(numbers[2]);
            Console.WriteLine("Length: " + numbers.Count);



            // Dictionary (Works on Key/Value pair system. This system gives us the option to get values from collection by some key)
            //using System.Collections.Generic;
            string[] students = new string[3];
            int[] points = new int[3];

            students[0] = "Miodrag";
            points[0] = 45;

            students[1] = "Ivan";
            points[1] = 85;

            students[2] = "Vlado";
            points[2] = 95;

            for (int i = 0; i < students.Length; i++)
            {
                if (points[i] > 50)
                    Console.WriteLine(students[i]);
            }

            Dictionary<string, int> studentsWithPoints = new Dictionary<string, int>();
            studentsWithPoints.Add("Miodrag", 45);
            studentsWithPoints.Add("Ivan", 85);
            studentsWithPoints.Add("Vlado", 95);

            foreach (var pair in studentsWithPoints)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

            Dictionary<int, string> numbersWithText = new Dictionary<int, string> { { 1, "One" }, { 2, "Two" }, { 3, "Three" } };
            Console.WriteLine(numbersWithText[1]);
            Console.WriteLine("Length: " + numbersWithText.Count);



            // Queue (First In First Out -> FIFO)
            //using System.Collections.Generic;
            Queue<string> justToAskSomething = new Queue<string>();

            justToAskSomething.Enqueue("Vlado");
            justToAskSomething.Enqueue("Andrea");
            justToAskSomething.Enqueue("Ivan");

            Console.WriteLine("Current queue overview:");
            foreach (var person in justToAskSomething)
            {
                Console.WriteLine(person);
            }

            string first = justToAskSomething.Dequeue();

            Console.WriteLine($"Next is {first}");

            Console.WriteLine("We have still:");
            foreach (var person in justToAskSomething)
            {
                Console.WriteLine(person);
            }

            string whoIsNowFirst = justToAskSomething.Peek();
            Console.WriteLine($"Next person from the queue is {whoIsNowFirst}");

            Console.WriteLine("Length: " + justToAskSomething.Count);


            // Stack (Last In First Out -> LIFO)
            //using System.Collections.Generic;

            Stack<string> people = new Stack<string>();

            people.Push("Miodrag");
            people.Push("Ivan");
            people.Push("Andrea");
            people.Push("Dimitar");


            Console.WriteLine("Current people overview:");

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("POP for bye bye:");

            var whoIsNext = people.Peek();

            Console.WriteLine($"Next for bye bye is {whoIsNext} from LAST IN FIRST OUT -> LIFO");

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Length of the STACK is: " + people.Count);
        }
    }
}