using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            float f1 = 1.4f; 
            float f2 = -13F;

            bool b1 = true;
            bool b2 = false; 
            bool x = true;

            //x = true && false; 
            //x= !true || false;
            x = true  ^ b2;

            Console.WriteLine(x);
        }
    }
}
