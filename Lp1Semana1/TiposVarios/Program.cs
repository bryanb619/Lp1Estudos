using System;

namespace TiposVarios
{
    class Program
    {

        static void Main(string[] args)
        {
            // 2 numeros inteiros
            int myIntNumber = 1;
            int myIntNumber2 = 2;

            Console.WriteLine($"{myIntNumber} {myIntNumber2}");
            // ------------------------------------------------------------------------------------

            // 5 Unicode 
            string heart = "\u2764"; // 
            Console.WriteLine(heart); // display emoji when supported by console

            char star = '\u2605';

            Console.WriteLine(Convert.ToInt32(star)); // display int number of star 
            // ------------------------------------------------------------------------------------

            // 8 Variaveis de tipo real 

            float gravity = -9.8f; 

            double height = 1.65;

            decimal z = 3.1415m; 

            Console.WriteLine($"My height is {height}, earth gravity is {gravity} and z = {z}");
            // ------------------------------------------------------------------------------------


            // 11 Variaveis de tipo bool
            bool detected = false;

            bool connection = true;

            Console.WriteLine($" Server was: {detected} and conection status is: {connection}");



        }
    }
}
