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
	
	for (int i=0; i<first; i+=1) {
		Console.WriteLine($"Counting up: {i+1}");
		Thread.Sleep(100);
	}
	
	Console.WriteLine("Enter second number: ");
	var secondInput = Console.ReadLine();
	if (!int.TryParse(secondInput, out int second)) {
		Console.WriteLine("Not-a-number");
		return;
	}
	
	var index = second;
	
	do {
		Console.WriteLine($"Counting down: {index}");
		Thread.Sleep(100);
		index -=1;
	} while (index > 0);	
}

// Define other methods and classes here
