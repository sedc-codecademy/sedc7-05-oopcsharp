using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void PrintCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Elements from collection {name}");
            foreach(var o in collection)
            {
                Console.Write($"{o}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = new int[3] { 1,2,3 };
            PrintCollection(a, "Array a");
            Console.WriteLine("-------------------------------");

            //ArrayList(Accepts all types and does not have constraint on number of elements)
            ArrayList al1 = new ArrayList() { 1, "a", "true" };
            PrintCollection(al1, "ArrayList al1");
            al1.Add(23);
            al1.Add("tekst");
            al1.Remove(1);
            PrintCollection(al1, "ArrayList al1");
            Console.WriteLine($"El[1]={al1[1]}");
            Console.WriteLine("-------------------------------");

            // List ( Has designated type and does not have constraint on number of elements )
            List<int> li = new List<int>() { 1, 2, 3 };
            PrintCollection(li, "ArrayList");
            li.Add(4);
            li.Add(5);
            li.Remove(1);
            PrintCollection(li, "ArrayList");
            Console.WriteLine($"El[1]={li[1]}");
            Console.WriteLine("-------------------------------");

            Queue<int> q = new Queue<int>();
            q.Enqueue(1); // Add item to the Queue
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            PrintCollection(q, "Queue q");
            int el1;
            el1 = q.Dequeue(); // Remove item from the Queue
            int el2;
            el2 = q.Dequeue(); // Remove item from the Queue
            PrintCollection(q, "Queue");

            Console.WriteLine("Zbirot na prviot={0} i vtoriot={1} od redot e: {2}", el1, el2, el1 + el2);
            Console.WriteLine($"Queue<int>.Count = {q.Count}");
            int elP;
            elP = q.Peek();
            Console.WriteLine($"Peak={elP}"); // This returns what element is on top of the queue ( Who's turn it is )
            PrintCollection(q, "Queue");

            Console.WriteLine("-------------------------------");

            Stack<int> s = new Stack<int>();
            s.Push(1); // Add item to the Stack
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            PrintCollection(s, "Stack");

            int se1;
            se1 = s.Pop(); // Remove item from the Stack
            int se2;
            se2 = s.Pop(); // Remove item from the Stack

            PrintCollection(s, "Stack");
            Console.WriteLine("Zbirot na prviot={0} i vtoriot={1} od kupceto e: {2}", se1, se2, se1 + se2);

            Console.WriteLine($"Stack<int>.Count = {s.Count}");
            Console.WriteLine($"Peak={s.Peek()}"); // This returns what element is on top of the queue ( Who's turn it is )
            PrintCollection(s, "Stack");

            Console.WriteLine("--------------------------------------");

            // Dictionary ( Works on Key/Value pair system. This system gives us the option to get values from collection by some key )
            Dictionary<string, string> d1 = new Dictionary<string, string>() { { "Author1", "Book1" }, { "Author2", "Book2" }, { "Author3", "Book3" } };
            
            d1.Add("Author4", "Book4");
            d1.Add("Author5", "Book5");

            d1.Remove("Author1");
            
            PrintCollection(d1, "Dictionary");

            string author3Value = d1["Author3"];

            Console.WriteLine(author3Value);

            //Console.WriteLine($"Dictionary<string,string>.Count = {d1.Count}");
            //Console.WriteLine($"El[Author2]={d1["Author2"]}");

            //d1.Remove("Author5");
            //PrintCollection(d1, "Dictionary");
            //Console.WriteLine($"Dictionary<string,string>.Count = {d1.Count}");
            Console.WriteLine("--------------------------------------");

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("No Songs");


            //Person person = new Person("Trajan", "Stevkovski", Genre.Classical);
            //person.GetFavSongs();


            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Added Songs");
            //Console.WriteLine("--------------------------------------");


            //Song song1 = new Song("Song1", 123, Genre.HipHop);
            //Song song2 = new Song("Song2", 234, Genre.Rock);
            //Song song3 = new Song("Song3", 345, Genre.Techno);
            //Song song4 = new Song("Song4", 567, Genre.Classical);
            //Song song5 = new Song("Song5", 456, Genre.Techno);

            //person.AddFavoriteSong(song1);
            //person.AddFavoriteSong(song2);
            //person.AddFavoriteSong(song3);
            //person.AddFavoriteSong(song4);
            //person.AddFavoriteSong(song5);

            //person.GetFavSongs();


            Console.ReadLine();
        }
    }
}
