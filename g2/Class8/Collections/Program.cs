using MusicApp.Enums;
using MusicApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Dog(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            // ArrayList arrayList = new ArrayList() { 1, "2" };

            #region List
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //numbers.Add(6);
            //numbers.Add(12);
            //numbers.Remove(3);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("From numbers: " + item);
            //}

            //Console.WriteLine(numbers[2]);
            #endregion
            #region Dictionary
            //Dictionary<string, string> sedc =
            //new Dictionary<string, string> { { "Igor", "trainer" }, { "Dejan", "ninja" } };

            //sedc.Add("Veko", "Po Taka");
            //Console.WriteLine(sedc["Igor"]);

            //Dictionary<int, string> people =
            //new Dictionary<int, string> { { 0, "Andrej" }, { 1, "Boban" } };

            //Dictionary<string, string> phonebook = new Dictionary<string, string>
            //{
            //    { "Igor", "389792679" },
            //    { "Gorjan", "389795449" },
            //    { "Dalibor", "389452179" },
            //    { "Voskresija", "389770179" },
            //    { "Kornelija", "389485279" },
            //};
            //Console.Write("Search phonebook by name: ");
            //string query = Console.ReadLine();
            //string result = SearchPhoneBook(phonebook, query);
            //Console.WriteLine($"The number for {query} is {result}");
            #endregion

            #region Queue
            //Queue<int> nums = new Queue<int>();

            //nums.Enqueue(1);
            //nums.Enqueue(2);
            //nums.Enqueue(3);
            //nums.Enqueue(4);
            //Console.WriteLine(nums.Peek());

            //nums.Dequeue();
            //Console.WriteLine(nums.Peek());
            #endregion

            #region Stack
            //Stack<char> chars = new Stack<char>();

            //chars.Push('a');
            //chars.Push('b');
            //chars.Push('c');
            //chars.Push('d');

            //Console.WriteLine(chars.Peek());
            //chars.Pop();
            //Console.WriteLine(chars.Peek());
            #endregion

            #region Linq

            //List<Dog> dogs = new List<Dog>
            //{
            //    new Dog("Barky", 3),
            //    new Dog("Cvarki", 5),
            //    new Dog("Spikey", 2),
            //    new Dog("Laika", 7),
            //    new Dog("Bubic", 12)
            //};

            //List<string> startsWithB = dogs.Where(dog => dog.Name.StartsWith("B")).Select(dog => dog.Name).ToList();

            //List<int> agesOfDogs = dogs.Select(dog => dog.Age).ToList();
            //foreach (int dogage in agesOfDogs)
            //{
            //    Console.WriteLine(dogage);
            //}


            #endregion


            #region musicapp

            List<Person> FansArray = CreateFans();
            List<Song> Songs = CreateSongs();

            Person Jerry = FansArray.FirstOrDefault(fan => fan.FirstName == "Jerry");
           
            Jerry.FavoriteSongs = Songs.Where(song => song.Title.StartsWith("B")).ToList();
            
            //Jerry.FavoriteSongs = (from song in Songs
            //                       where song.Title.StartsWith("B")
            //                       select song).ToList();
            Jerry.GetFavSongs();
            #endregion
            Console.ReadLine();
        }

        public static string SearchPhoneBook (Dictionary<string, string> phonebook, string query)
        {
            if(!phonebook.ContainsKey(query))
            {
                return $"not found";
            }
            return phonebook[query];
        }


        public static List<Person> CreateFans()
        {
            return new List<Person> {
                new Person("Jerry", "Tompson", 78, Genre.Rock),
                new Person("Stefan", "Stefanoski", 28, Genre.Techno),
                new Person("Maria", "Campbel", 43, Genre.Classical),
                new Person("Jane", "Doe", 28, Genre.Techno),
            };
        }

        public static List<Song> CreateSongs()
        {
            return new List<Song>
            {
                new Song("Bohemian Rhapsody", 367, Genre.Rock),
                new Song("Stairway To Heaven", 480, Genre.Rock),
                new Song("Riders On The Storm", 430, Genre.Rock),
                new Song("Not Fade Away", 108, Genre.Rock),
                new Song("Breaking Glass", 111, Genre.Rock),
                new Song("Welcome To The Jungle", 275, Genre.Rock),
                new Song("Walk Of Life", 266, Genre.Rock),
                new Song("Smoke on the Water", 340, Genre.Rock),
                new Song("93 'til Infinity", 209, Genre.Techno),
                new Song("Fight the Power", 321, Genre.Techno),
                new Song("The Message", 363, Genre.Techno),
                new Song("Butterfly Effect", 213, Genre.Techno),
                new Song("No Fear", 182, Genre.Techno),
                new Song("Hereditary", 340, Genre.Techno),
                new Song("Bounce Back", 226, Genre.Techno),
                new Song("The Four Seasons", 2520, Genre.Classical),
                new Song("Canon in D major", 376, Genre.Classical),
                new Song("Swan Lake", 461, Genre.Classical),
                new Song("Symphony No. 5", 425, Genre.Classical),
                new Song("Ride of the Valkyries", 608, Genre.Classical),
                new Song("The Magic Flute", 458, Genre.Classical),
                new Song("Carmen Suite No.1", 721, Genre.Classical),
                new Song("Planet E", 420, Genre.Techno),
                new Song("Phasor", 368, Genre.Techno),
                new Song("Counting Comets", 242, Genre.Techno),
                new Song("Cold Summer", 358, Genre.Techno),
                new Song("Destroyer", 359, Genre.Techno),
                new Song("Phalanx", 307, Genre.Techno),
                new Song("Vision", 693, Genre.Techno),
                new Song("Chain Reaction", 181, Genre.Techno)
            };
        }
    }
}
