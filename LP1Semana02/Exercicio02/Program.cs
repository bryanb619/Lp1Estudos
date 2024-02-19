using System;
using System.IO.Compression;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 3, i2 = 1, i3 = -8, x =2; 

            //x = i1 << 2;
            //x <<= x;
            x= ~ (i1 | i3);

            // 
            Console.WriteLine(x);
        }
    }
}
