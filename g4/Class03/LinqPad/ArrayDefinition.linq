<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

int[] nullArray = null;
Console.WriteLine(nullArray);

int[] oddArray = {1, 3, 5, 7, 8};
Console.WriteLine(oddArray);

oddArray[4] = 9;
Console.WriteLine(oddArray);

var evenArray = new int[]{2, 4, 6, 8, 10};
Console.WriteLine(evenArray);

var fivesArray = new int[5];
Console.WriteLine(fivesArray);

for (int i=0; i<fivesArray.Length; i+=1)
{
	fivesArray[i] = (i+1)*5;
}
Console.WriteLine(fivesArray);





