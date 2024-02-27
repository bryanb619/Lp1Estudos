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
        }
    }
}
