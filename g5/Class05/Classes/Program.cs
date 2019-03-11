using System;
using Classes.OtherClasses;

/* 
This is the namespace of our class Person
We must include this so we can use our Person class
*/
using Classes.MyClasses;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an empty person object (using the parameterless constructor)
            Person bob = new Person();
            bob.Name = "Bob Bobsky";
            bob.Age = 34;
            //bob.SSN = 3453254252; // We can't access this. It's private
            bob.Talk("Hey there");
            //bob.GenerateSSN(); // We can't call this. It's private

            // Creating a person object using the second constructor with parameters
            Person jill = new Person("Jill Wayne", 29); // we don't need to set the properties
            jill.Talk("Hello!");

            // Creating a product because we have access to it since we are in the same namespace
            Product car = new Product();
            car.Name = "Car";
            car.Code = 12314;
            car.Price = 6500.99;

            car.Buy(5000);
            car.Buy(10000);

            Console.ReadLine();
        }
    }
}