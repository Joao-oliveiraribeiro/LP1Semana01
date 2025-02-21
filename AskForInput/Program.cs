using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro: ");
            string inputInt = Console.ReadLine();

            int int_number = int.Parse(inputInt);

            Console.WriteLine("Insira um numero real: ");
            string inputFloat = Console.ReadLine();
        }
    }
}
