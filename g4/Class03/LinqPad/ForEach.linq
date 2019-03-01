<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var fivesArray = new int[20];
	
	for (int i=0; i<fivesArray.Length; i+=1)
	{
		fivesArray[i] = (i+1)*5;
	}
	
//	for (int i=0; i<fivesArray.Length; i+=1)
//	{
//		Console.WriteLine(fivesArray[i]*fivesArray[i]);
//	}

	foreach (var element in fivesArray)
	{
		//Console.WriteLine(element*element);
	}
	
//	int result = 0;
//	bool found = false;
//	foreach (var element in fivesArray) {
//		if ((!found) && (element % 3==0)) {
//			result = element;
//			found=true;
//		}
//	}
//	Console.WriteLine(fivesArray);
//	Console.WriteLine(result);

	int result = 0;
	foreach (var element in fivesArray) {
		Console.WriteLine($"Executing for {element}");
		if (element % 3==0) {
			result = element;
			break;
		}
	}
	Console.WriteLine(fivesArray);
	Console.WriteLine(result);
}

// Define other methods and classes here
