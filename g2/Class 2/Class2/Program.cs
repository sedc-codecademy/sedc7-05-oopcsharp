using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = "9 " + " " + "5";
            int branches = 12;
            int applesOnBranch = 8;
            int basketSize = 5;
            Console.Write("Vnesete broj na drva: ");
            string trees = Console.ReadLine();
            double numTrees = double.Parse(trees);
            double dblBranches = Convert.ToDouble(branches);
            double dblApplesPerBranch = Convert.ToDouble(applesOnBranch);
            double dblBasketSize = Convert.ToDouble(basketSize);
            var neededBaskets = numTrees * dblBranches * dblApplesPerBranch / dblBasketSize;
            var roundedBaskets = Math.Ceiling(neededBaskets);
            Console.WriteLine(roundedBaskets);

            Console.ReadLine();
        }
    }
}
