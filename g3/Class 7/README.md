# Cheat Sheet
## Inheritance
```csharp
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and it's of the age of {Age}.");
    }
}
```
Programmer inherits from Human along with all properties and Method PrintInfo
```csharp
public class Programmer : Human
{
    public string[] ProgrammingLanugages { get; set; }
    public void DevelopApp()
    {
        Console.WriteLine($"The programmer {Name} is developing an app...");
    }
}
```
## Overriding methods
```csharp
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and it's of the age of {Age}.");
    }
}
```
We override the method PrintInfo() from Human to do something else
```csharp
public class Programmer : Human
{
    public string[] ProgrammingLanugages { get; set; }
    public void DevelopApp()
    {
        Console.WriteLine($"The programmer {Name} is developing an app...");
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"This is {Name} and these are the programming lanugages they know:");
        foreach (string language in ProgrammingLanugages)
        {
            Console.WriteLine(language);
        }
    }
}
```