<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var p = new Person("Wekoslav");
}

// Define other methods and classes here
class Person
{
    public Person(string firstName)
    {
        FirstName = firstName;
    }

//    public Person(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}