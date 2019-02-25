<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

string firstName = "Wekoslav";
string lastName = "Stefanovski";
int age = 0x29;

string resultConcatenate = firstName + " " + lastName + " (" + age + ")";
Console.WriteLine(resultConcatenate);

string resultTemplate = $"{firstName} {lastName} ({age})";
Console.WriteLine(resultTemplate);

string resultFormat = String.Format("{0} {1} ({2})", firstName, lastName, age);
Console.WriteLine(resultFormat);
