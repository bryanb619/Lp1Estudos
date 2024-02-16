using System;

namespace Argumentos
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Writes a string in the console
            Console.WriteLine("Inserir Argumentos");

            // loops that runs every argument passed in the console
            for (int i = 0; i < args.Length; i++)
            {
                // write every argument to the console
                Console.WriteLine($"Argumento {i + 1}: {args[i]}");
            }

            // Waits for user input to close
            Console.ReadLine(); 
        }
    }
}
