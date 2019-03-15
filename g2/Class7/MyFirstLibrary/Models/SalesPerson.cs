using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary.Models
{
    public class SalesPerson : Employee
    {
        private double ScsSaleRev { get; set; }

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            Role = Enums.Role.Sales;
            Salary = 500;
        }

        public void AddSuccessRevenue(double revenue)
        {
            ScsSaleRev = revenue;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + CalculateBonus();
        }
        private double CalculateBonus()
        {
            if(ScsSaleRev <= 2000)
            {
                return 500;
            } else if(ScsSaleRev > 2000 && ScsSaleRev <= 5000)
            {
                return 1000;
            }
            return 1500;
        }
    }
}
