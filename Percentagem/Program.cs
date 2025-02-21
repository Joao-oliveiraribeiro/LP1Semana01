using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Insere 4 números reais entre 0 e 1: ");
            string number_1 = Console.ReadLine();
            string number_2 = Console.ReadLine();
            string number_3 = Console.ReadLine();
            string number_4 = Console.ReadLine();

            float con_number_1 = float.Parse(number_1);
            float con_number_2 = float.Parse(number_2);
            float con_number_3 = float.Parse(number_3);
            float con_number_4 = float.Parse(number_4);

            string s1 = $"{con_number_1,7:p2}";
            string s2 = $"{con_number_2,7:p2}";
            string s3 = $"{con_number_3,7:p2}";
            string s4 = $"{con_number_4,7:p2}";

            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
