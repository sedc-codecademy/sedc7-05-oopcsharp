<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

string firstName = "Wekoslav";
string lastName = "Stefanovski";
int age = 0x29;

Console.WriteLine(firstName + " " + lastName + " (" + age + ")");

Console.WriteLine($"{firstName} {lastName} ({age})");

Console.WriteLine("{0} {1} ({2})", firstName, lastName, age);
