using System; 

namespace SpecialChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Horizontal tab ( \t ) 2 new lines
            Console.WriteLine("Hello\tWorld\n\n");

            //horizontal tab ( \t ) + carrige return ( \r )
            Console.WriteLine("Hi there\t\r");

            // \ - backslash ( \\ )
            Console.WriteLine("Cel na doznaka: 2345-34\\1 {0} \n");

            //verbatim string
            Console.WriteLine(@"Cel na doznaka: 2345-34\1 {0}",1);
            
            // \a - Alert or Bell
            Console.WriteLine("\a");

            //Beep
            Console.Beep(2000, 10000); //10 seconds a sound with frequency of 2000 Hz            
            Console.ReadKey();
        }
    }
}
