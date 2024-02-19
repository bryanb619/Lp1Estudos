using System;

namespace FourSisterAndTheDuckbear
{
    class Program
    {
        private static void Main(string[] args)
        {

            while(true)
            {
                // request eggs number
                Console.WriteLine("Enter Quantity of chocolate eggs: ");

                // convert eggs string to int
                int eggs = Convert.ToInt32(Console.ReadLine());


                if (eggs < 4)
                {
                    Console.WriteLine("Must be higher or equal to 4 eggs");
                    return;
                }
                


                if (eggs % 2 == 0)
                {
                    Console.WriteLine($"Each sister received {eggs / 4} egg(s)");

                }
                
                else
                {
                    int eggsRemain;
                    eggsRemain = eggs %2;
                    Console.WriteLine($"The sisters received {eggs / 4} and duckbear received {eggsRemain} egg(s)");
                }

            }

        }

    }
}
