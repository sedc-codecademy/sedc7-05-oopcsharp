# Class 3 CheatSheet
## Loops
#### For
```csharp
Console.WriteLine("Counting to 10...");
for(int i = 1; i <= 10; i++){
	Console.WriteLine("Counter is now:" + i);
}
Console.WriteLine("Done counting!");
Console.ReadLine();
```
#### While
```csharp
Console.WriteLine("Counting to 10...");
int j = 1;
while(j <= 10){
	Console.WriteLine("Counter is now:" + j);
	j++;
}
Console.WriteLine("Done counting!");
Console.ReadLine();
```
## Arrays
#### Creating an array
```csharp
int[] intArray1 = new int[2];
intArray[0] = 2;
intArray[1] = -20;
```
```csharp
int[] intArray2 = new int[] {2, -20};
```
```csharp
int[] intArray2 = {2, -20};
```
#### Looping arrays
```csharp
string[] names = new string[] {"Bob", "Jill", "Greg"};
Console.WriteLine("Writing names...");
for(int i = 0; i < names.Length; i++){
	Console.WriteLine(names[i]);
}
Console.ReadLine();
```

#### foreach
```csharp
string[] names = new string[] {"Bob", "Jill", "Greg"};
Console.WriteLine("Writing names...");
foreach(string name in names){
	Console.WriteLine(name);
}
Console.ReadLine();
```