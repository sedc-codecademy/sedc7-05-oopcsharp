<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int top = 100;
	
	for (int i=1; i<=top; i++) {
		if (i%3==0) {
			if (i % 5 == 0)  {
				Console.WriteLine($"{i}: FizzBuzz");
				continue;
			}
			
			Console.WriteLine($"{i}: Fizz");
		} else {
			if (i%5==0) {
				Console.WriteLine($"{i}: Buzz");
			} else {
				Console.WriteLine($"{i}: {i}");
			}
		}
	}
}

// Define other methods and classes here
