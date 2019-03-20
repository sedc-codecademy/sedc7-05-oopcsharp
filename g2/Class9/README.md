# Cheat Sheet
## Exceptions
### Try Catch Finally
```csharp
try
{
	int input = int.Parse(Console.ReadLine());
}
catch{Exception}
{
	Console.WriteLine("There was a problem!");
}
finally
{
	Console.WriteLine("Everything is done!");
}
```
### Catching an exception
```csharp
try
{
	int input = int.Parse(Console.ReadLine());
}
catch{Exception ex}
{
	Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
	Console.WriteLine("Everything is done!");
}
```
### Capture multiple exceptions
```csharp
try
{
	int input = int.Parse(Console.ReadLine());
}
catch{FormatException}
{
	Console.WriteLine("WRONG FORMAT! PLEASE ENTER THE RIGHT ONE!");
}
catch{Exception ex}
{
	Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
	Console.WriteLine("Everything is done!");
}
```

## Exercise 3 Data
```csharp
Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


Cinema cinema1 = new Cinema("Cineplex");
cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
cinema1.ListOfMovies = MovieSet1;
Cinema cinema2 = new Cinema("Milenium");
cinema2.Halls = new List<int>() { 1, 2 };
cinema2.ListOfMovies = MovieSet2;
```