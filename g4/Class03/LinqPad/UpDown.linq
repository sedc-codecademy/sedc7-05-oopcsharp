<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Console.WriteLine("Enter first number: ");
	var firstInput = Console.ReadLine();
	if (!int.TryParse(firstInput, out int first)) {
		Console.WriteLine("Not-a-number");
		return;
	}
	
	int index = 1;
	while (index <= first) {
		Console.WriteLine($"Counting up: {index}");
		Thread.Sleep(100);
		index +=1;
	}
	
	Console.WriteLine("Enter second number: ");
	var secondInput = Console.ReadLine();
	if (!int.TryParse(secondInput, out int second)) {
		Console.WriteLine("Not-a-number");
		return;
	}
	
	for (int i=second; i > 0; i-=1) {
		Console.WriteLine($"Counting down: {i}");
		Thread.Sleep(100);
	}
	
}

// Define other methods and classes here
