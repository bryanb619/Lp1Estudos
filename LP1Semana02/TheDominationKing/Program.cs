using System;

namespace TheDominationKing
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
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


            //points += p *1; 

            points = p *1 + d * 3 + e * 6; 

            Console.WriteLine($"Your total points is: {points}!"); 





        }
    }
}
