using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string starting = "Hello";
            string close = "Bye";
            string copyright = "This is the copyright symbol \u00A9";
            string unicode = "Unicode exclamacao \u0021";
            string name = "Luis";
            string hello_name =String.Format("Hello {0}",name);
            Console.WriteLine("Hello LP1!");
            Console.WriteLine(starting);
            Console.WriteLine(close);
            Console.WriteLine(copyright);
            Console.WriteLine(unicode);
            Console.WriteLine(hello_name);
        }
    }
}
