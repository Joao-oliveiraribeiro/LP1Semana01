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

            
        }
    }
}
