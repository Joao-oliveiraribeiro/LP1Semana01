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
            string operador_mais = "Uma"+"string"+"adcionada"+"com +";
            string x = "Hello";
            int y= 10;
            int z=5;
            string name = "programador";
            string adicionar_uma_variavel = x + " World";
            string interpolaçao = $"O y equivale a {y}";
            string soma = $"Para somar y={y} + z={z} fica {y + z}";
            string hello_and_name =String.Format("Hello {0}",name);
            string valores_y_z =String.Format("y e z sao {0} e {1} ",y,z);
            Console.WriteLine("Hello, World!");
            Console.WriteLine(starting_message);
            Console.WriteLine(gameover_message);
            Console.WriteLine(message_and_copyright);
            Console.WriteLine(message_with_verbatim);
            Console.WriteLine(message_with_unicode);
            Console.WriteLine(unicode_with_escape);
            Console.WriteLine(adicionar_uma_variavel);
            Console.WriteLine(interpolaçao);
            Console.WriteLine(soma);
            Console.WriteLine(hello_and_name);
            Console.WriteLine(valores_y_z);
            Console.WriteLine("Valor de z e y são {0} e {1}",z,y);
            Console.WriteLine(@"Uso de verbatim  z= {0}", z);
            
        }
    }
}
