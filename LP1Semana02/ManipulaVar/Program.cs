using System;

namespace ManipulaVar
{
    class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Escreve Número:");

            // 2
            string input = Console.ReadLine();
            int x = int.Parse(input);

            // 3
            Console.WriteLine(x++);
            Console.WriteLine(x--);

        }
    }
}
