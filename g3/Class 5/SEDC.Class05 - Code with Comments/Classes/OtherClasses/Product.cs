using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Classes.OtherClasses
namespace Classes // We change the namespace and now this is part of the Classes namespace
{
	public class Product
	{
		public int Code { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public void Buy(double money){
			if(money >= Price){
				Console.WriteLine($"You just bought a {Name}!");
			} else {
				Console.WriteLine($"You need {Price - money} more to buy this!");
			}
			Console.ReadLine();
		}
	}
}
