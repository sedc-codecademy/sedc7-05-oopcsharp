using System;

namespace SEDC_Class2
{
    class Program
    {
        static void Main(string[] args)
        {

        //DECLARING AND INITIALIZATION OF VARIABLES AND THEIR TYPES
            //int a = 1;
            //int b = 3;
            //int result;
            //result = a + b;
            //Console.WriteLine(result);

            //bool firstVar = true;
            //bool secondVar;
            //secondVar = true;
            //bool result = firstVar ^ secondVar;
            //Console.WriteLine(result);

            //double firstVar = 1.25;
            //double secondVar = 1.2;
            //firstVar -= secondVar;
            //Console.WriteLine(firstVar);

            //string firstVar = "1";
            //string secondVar = "2";
            //string result = firstVar + secondVar;
            //Console.WriteLine(result);

        
        //DECLARING A VARIABLE OF TYPE DATETIME 
            //DateTime newYearEve = new DateTime(2018, 12, 31);
            //Console.WriteLine();


        //Example of Console.Readline() how to get input from user and how to convert from one type to another using TryParse() method
            //Console.WriteLine("First Name: ");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Age: ");
            //string ageString = Console.ReadLine();
            //int ageInt;
            //bool castSuccess = Int32.TryParse(ageString, out ageInt);

            //if (castSuccess)
            //{
            //    //TODO: DO some logic here
            //    int currentYear = DateTime.Now.Year;
            //    int bornYear = currentYear - ageInt;
            //    string fullName = firstName + " " + lastName + " " + bornYear;
            //    Console.WriteLine(fullName);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age.");
            //}

            //int parseInt;
            //int castInt;

            //string number = "Risto";


        //Convert from one to another type by using Parse and Convert methods
            //parseInt = Int32.Parse(number);
            //castInt = Convert.ToInt32(null);
            //Console.WriteLine("test");
            //Console.WriteLine(parseInt);
            //Console.WriteLine(castInt);

            //int a = 1;
            //int b = 2;
        //Branching using if/else statement
            //if (a == b)
            //{
            //    //DO something
            //} else if (a > b)
            //{
            //    //do something else
            //}

            //string name = "Martin";
            ////double num = 5.2;
            //float res;
            //bool isSuccess = float.TryParse(name, out res);
            //Console.WriteLine(isSuccess);
            //Console.WriteLine(res);
    
        //Branching using switch
            int a = 1;
            switch (a)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("X");
                    break;
            }

            Console.ReadLine();

        }
    }
}
