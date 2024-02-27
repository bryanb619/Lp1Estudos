using System;

namespace TheDominationKing
{
    /// <summary>
    /// Represents point calculator for a King
    /// </summary>
    class Program
    {
        /// <summary>
        /// Requests user input for provinces, duchies and estates
        /// Add points accordingly the type of property
        /// Outputs the total sum of points
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {
            int points = 0; 

            // request provinces
            Console.WriteLine("Enter your provinces!");

            // read province input & convert to int
            int p = int.Parse(Console.ReadLine()); 

            // request duchies
            Console.WriteLine("Enter your duchies!");

            // read duchies input & convert to int
            int d = int.Parse(Console.ReadLine()); 

            // read estate input & convert to int
            Console.WriteLine("Enter your estates");
            int e = int.Parse(Console.ReadLine()); 

            // point equation
            points = e * 1 + 3 *d + 6 *p; 

            // displays points
            Console.WriteLine($"Your total points is: {points}!"); 
       





        }
    }
}
