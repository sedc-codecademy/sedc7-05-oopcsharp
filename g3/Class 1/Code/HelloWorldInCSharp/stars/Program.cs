using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stars
{
	class Program
	{
		static void Main(string[] args)
		{
			float x = 2.5F;
			double y = 0.5;
			float z = x + x;
			Console.WriteLine(z);
			var pp = Convert.ToInt32("25");
			var p = int.Parse("25");
			var kk = Convert.ToInt32(null);
			var k = int.Parse(null);
			var tt = 0;
			var t = int.TryParse("25", out tt);

		}
	}
}
