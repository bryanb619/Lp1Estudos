using System;

namespace ManipulaVar
{
    class Program
    {
        private static void Main(string[] args)
        {
            // requesting input
            Console.WriteLine("Escreve Número:");

            // 2 reading input and converting to int
            string input = Console.ReadLine();
            int x = int.Parse(input);

            // 3 -> incrementation and decrementation
            Console.WriteLine(x++);
            Console.WriteLine(x--);

        }
    }
}
