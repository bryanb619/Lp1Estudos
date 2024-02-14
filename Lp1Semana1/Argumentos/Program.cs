using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir Argumentos");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argumento {i + 1}: {args[i]}");
            }

            Console.ReadLine();
        }
    }
}
