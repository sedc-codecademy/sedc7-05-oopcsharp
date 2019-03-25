# Cheat Sheet
## List
```csharp
// Create an empty list of strings
List<string> names = new List<string>();
// Add stuff to the list
names.Add("Bob");
names.Add("Midge");
names.Add("Red");
// Remove stuff from the list
names.Remove("Red");
// Find stuff from the list
names.Find("Midge");
// Number of elements
names.Count;
// Create and initialize a list of numbers
List<int> numbers = new List<int>(){ 2,89,4,8,6 };
```
## Dictionary
```csharp
// Create an empty dictionary
Dictionary<int, string> people = new Dictionary<int,string>();
// Add stuff to the dictionary
people.Add(1,"Bob");
people.Add(2,"Midge");
people.Add(3,"Red");
// Remove items by key value
people.Remove(3); // removes Red
// Find if a key exists
people.ContainsKey(2);
// Find if a value exists
people.ContainsValue("Midge");
// Number of elements
people .Count;
// Get value by key from a dictionary
people[1]; // this will return "Bob"
// Create and initialize a dictionary
Dictionary<string, bool> CheckList = new Dictionary<string, bool>(){ 
{"Potatoes", false},
{"Butter", true},
{"Salt", false},
{"Pepper", false}
};
// Getting first checklist item key and value
CheckList.First().Key // Returns "Potatoes"
CheckList.First().Value // Returns false


```
## Stack/Queue
```csharp
// Creating an empty Queue
Queue<string> people1 = new Queue<string>();
// Add stuff to the queue
people1.Enqueue("Bob");
people1.Enqueue("Midge");
people1.Enqueue("Red");
// Remove the item that is next in the queue
people1.Dequeue(); // removes Bob
// See which item is next in the queue
people1.Peek(); // returns Midge ( since we removed Bob )

// Creating an empty Stack
Stack<string> people2 = new Stack<string>();
// Add stuff to the Stack
people2.Push("Bob");
people2.Push("Midge");
people2.Push("Red");
// Remove the item that is next in the Stack
people2.Pop(); // removes Red
// See which item is next in the Stack
people2.Peek(); // returns Midge ( since we removed Red )
```
## LINQ
```csharp
List<string> strings = new List<string>(){"bob","midge","Red","Kitty","Fez"};
// Where
List<strings> 3letterNames = strings.Where(x => x.Length == 3).ToList();
// Select
List<int> numberOfLetters = strings.Select(x => x.Length).ToList();
// First item
numberOfLetters.First();
numberOfLetters.FirstOrDefault();
// Last item
numberOfLetters.Last();
numberOfLetters.LastOrDefault();
```

## Exercise 3 Data
```csharp
List<Person> FansArray = new List<Person>();

//fans
Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
Person Maria = new Person("Maria", "Campbel", 43, Genre.Classical);
Person Jane = new Person("Jane", "Doe", 28, Genre.Techno);

//songs
Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
Song song10 = new Song("Fight the Power", 321, Genre.Techno);
Song song11 = new Song("The Message", 363, Genre.Techno);
Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
Song song13 = new Song("No Fear", 182, Genre.Techno);
Song song14 = new Song("Hereditary", 340, Genre.Techno);
Song song15 = new Song("Bounce Back", 226, Genre.Techno);
Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
Song song17 = new Song("Canon in D major", 376, Genre.Classical);
Song song18 = new Song("Swan Lake", 461, Genre.Classical);
Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
Song song23 = new Song("Planet E", 420, Genre.Techno);
Song song24 = new Song("Phasor", 368, Genre.Techno);
Song song25 = new Song("Counting Comets", 242, Genre.Techno);
Song song26 = new Song("Cold Summer", 358, Genre.Techno);
Song song27 = new Song("Destroyer", 359, Genre.Techno);
Song song28 = new Song("Phalanx", 307, Genre.Techno);
Song song29 = new Song("Vision", 693, Genre.Techno);
Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                    song8, song9, song10, song11, song12, song13, song14,
                                    song15, song16, song17, song18, song19, song20,
                                    song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };

FansArray.Add(Jerry);
FansArray.Add(Stefan);
FansArray.Add(Maria);
FansArray.Add(Jane);
```
