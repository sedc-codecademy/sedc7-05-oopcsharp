<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Print(Add(3, 4));
}

// Define other methods and classes here
int Add (int x, int y) {
	return x + y;
}

void Print (int x) {
	if (x == 0){
		return;
	}
	Console.WriteLine($"The value is {x}");
}
