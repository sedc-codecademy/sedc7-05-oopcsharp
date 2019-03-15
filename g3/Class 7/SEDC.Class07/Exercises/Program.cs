using ExerciseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { FirstName = "Bob", LastName = "Bobsky", Salary = 600, Role = Role.Other };
            SalesPerson sale = new SalesPerson("Bill", "Billsky", 1500);

            sale.ExtendSuccessSaleRevenue(2000);
            emp.PrintInfo();
            sale.PrintInfo();
            Console.WriteLine("Employee Salary: " + emp.GetSalary());
            Console.WriteLine("Sales Person Salary: " + sale.GetSalary());
            Console.ReadLine();
        }
    }
}
