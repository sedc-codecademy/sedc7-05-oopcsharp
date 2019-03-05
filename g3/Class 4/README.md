# Cheat Sheet
### Methods
##### A method
```csharp
public static string SayHello(string name){
	string result = $"Hello there {name}!";
    return result;
}
```
### Strings
##### String building
```csharp
string hello1 = "Hello " + name;
string hello2 = string.Format("Hello {0}", name);
string hello3 = $"Hello {name}";
```
##### String formating
```csharp
string currency = string.Format("{0:C}", 125.45); // Currency formating
string percent = string.Format("{0:P}", .5); // Percent formating
string customFormat = string.Format("{0:0##-###-###}", 078270396); // Custom formating
string customAlignment = string.Format("| {0,10} | {1,10} |", "Id", "Order"); // Alignment formatting
```
### Dates
##### Building a string
```csharp
DateTime aDate = new DateTime(); // Creating a new empty date
DateTime aCustomDate = new DateTime(1992, 10, 15); // Creating a custom date
DateTime currentDay = DateTime.Today; // Getting todays date without time
DateTime currentDateTime = DateTime.Now; // Getting todays date with time
```
##### Converting and formating a string
```csharp
string dateFormat1 = DateTime.Now.ToString("MM/dd/yyyy"); // Formating date to string
string dateFormat2 = DateTime.Now.ToString("dddd, dd MMMM yyyy"); // Formating date to string
string stringDate = "12-15-2012"; 
DateTime convertedDate = DateTime.Parse(stringDate); // Converting string to date
```