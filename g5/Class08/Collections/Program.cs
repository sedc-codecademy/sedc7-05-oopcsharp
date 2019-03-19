using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            string[] stringsInArray = new string[4];
            string[] stringInArray2 = new string[] { "Hello", "World", "!" };
            Console.WriteLine("Length: " + stringInArray2.Length); // Get number of elements in the collection

            // ArrayList ( Accepts all types and does not have constraint on number of elements )
            ArrayList arrayList = new ArrayList() { "Hello", 2 };
            arrayList.Add('h');
            arrayList.Add(stringsInArray);
            arrayList.Remove(2);
            Console.WriteLine(arrayList[2]);
            Console.WriteLine("Length: " + arrayList.Count);  // Get number of elements in the collection

            // List ( Has designated type and does not have constraint on number of elements )
            List<int> listOfInt = new List<int> { 2, 33, 5 };
            listOfInt.Add(9);
            listOfInt.Remove(2);
            Console.WriteLine(listOfInt[2]);
            Console.WriteLine("Length: " + listOfInt.Count);

            // Dictionary ( Works on Key/Value pair system. This system gives us the option to get values from collection by some key )
            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("song1", "Winds of Chage");
            dictionaryOne.Add("song2", "Enter Sandman");
            dictionaryOne.Add("animal", "Dog");
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string> { { 2, "Hello" }, { 4, "World" }, { 7, "!" } };
            Console.WriteLine(dictionaryOne["song1"]);
            Console.WriteLine(dictionaryTwo[4]);
            Console.WriteLine("Length: " + dictionaryOne.Count);  // Get number of elements in the collection

            // Queue (First in First Out)
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25); // Add item to the Queue
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(111);
            someQueue.Dequeue(); // Remove item from the Queue
            //Console.WriteLine(someQueue[2]);
            Console.WriteLine(someQueue.Peek()); // This returns what element is on top of the queue ( Who's turn it is )
            Console.WriteLine("Length: " + someQueue.Count);  // Get number of elements in the collection

            // Stack (Last in First Out)
            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey"); // Add item to the Stack
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");
            someStack.Pop(); // Remove item from the Stack

            Console.WriteLine(someStack.Peek()); // This returns what element is on top of the queue ( Who's turn it is )
            Console.WriteLine("Length: " + someStack.Count);  // Get number of elements in the collection

            Console.ReadLine();
        }
    }
}