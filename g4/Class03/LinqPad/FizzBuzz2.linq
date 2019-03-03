<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int top = 100;
	
	for (int i=1; i<=top; i++) {
		bool hasThree = i%3==0;
		bool hasFive = i%5==0;
		if (hasThree && hasFive) {
			Console.WriteLine($"{i}: FizzBuzz");
		} else if (hasThree) {
			Console.WriteLine($"{i}: Fizz");
		} else if (hasFive) {
			Console.WriteLine($"{i}: Buzz");
		} else {
			Console.WriteLine($"{i}: {i}");
		}
	}
}

// Define other methods and classes here
