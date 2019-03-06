using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create datetime            
            DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);
            
			//Example how it looks like in the output
			var t = String.Format("{0:t}", dt); // "6:50 PM" ShortTime
			
            //Console.WriteLine(t);
            var d = String.Format("{0:d}", dt); // 
            //Console.WriteLine(d);
            var T = String.Format("{0:T}", dt); // 
            //Console.WriteLine(T);
            var D = String.Format("{0:D}", dt); // 
            //Console.WriteLine(D);
            var f = String.Format("{0:f}", dt); // 
            //Console.WriteLine(f);            
            var F = String.Format("{0:F}", dt); // "Wednesday, February 21, 2018 6:50:23 PM"
            //Console.WriteLine(F);
            var g = String.Format("{0:g}", dt); // 
            //Console.WriteLine(g);
            var G = String.Format("{0:G}", dt); // 
            //Console.WriteLine(G);
            var m = String.Format("{0:m}", dt); // 
            //Console.WriteLine(m);
            var y = String.Format("{0:y}", dt); // 
            //Console.WriteLine(y);
            var r = String.Format("{0:r}", dt); // 
            //Console.WriteLine(r);
            var s = String.Format("{0:s}", dt); // 
            //Console.WriteLine(s);
            var u = String.Format("{0:u}", dt); // 
            //Console.WriteLine(u);

            Console.WriteLine("--------------");

            DateTime TimeNow = DateTime.Now;
            DateTime TimeUtc = DateTime.UtcNow;
            DateTime TimeToday = DateTime.Today;
            Console.WriteLine("Current DateTime: {0} ", TimeNow);  	//
            Console.WriteLine("UTC DateTime:     {0} ", TimeUtc); 	//
            Console.WriteLine("Today:            {0} ", TimeToday); //
            Console.WriteLine();
            
            DateTime yesterday;
            yesterday = TimeNow.AddDays(-1);
            Console.WriteLine("Yesterday: {0}", yesterday);								//
            Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);		//
            Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));				//
            
            int mDays = DateTime.DaysInMonth(2016,2);
            Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);							//
            Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018,2));	//

        }
    }
}
