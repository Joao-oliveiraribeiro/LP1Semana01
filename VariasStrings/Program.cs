using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string starting_message = "Welcome";
            string gameover_message = "You lost!";
            string message_and_copyright = "This message is subject to copyright \u00A9";
            string message_with_verbatim = @"Would you like to continue? Y/N";
            string message_with_unicode = "Unicode exclamaçao \u0021";
            string unicode_with_escape = "Unicode letra em latim \u03B2";
            Console.WriteLine("Hello, World!");
            Console.WriteLine(starting_message);
            Console.WriteLine(gameover_message);
            Console.WriteLine(message_and_copyright);
            Console.WriteLine(message_with_verbatim);
            Console.WriteLine(message_with_unicode);
            Console.WriteLine(unicode_with_escape);
            
        }
    }
}
