using System;

namespace VariasStrings
{
    class Program
    {
        // EX 4
        private static string _name = "Steve";

        // paths
        private static string _pathWithoutVerbatim = "C:\\Users\\Steve\\Documents";
        private static string _pathWithVerbatim = @"C:\Users\Steve\Documents";

        // text with quotes
        private static string _noVerbatim = "\" Esta string esta' entre aspas\"";
        private static string _withVerbatim = @"""Esta string esta ’ entre aspas""";
        //-------------------------------------------------------------------------------

        // EX 5
        private static string _firstName = "Steve";
        private static string _lastName = "Hall";

        private static int x = 2, y = 3; 


        private static void Main(string[] args)
        {

            // EX 4 

            Console.WriteLine("EX 4 ----------------------------");
            Console.WriteLine("User Name: " +_name);

            Console.WriteLine("Path without verbatin: " +_pathWithoutVerbatim);
            Console.WriteLine("Path with verbatin: "    +_pathWithVerbatim);

            Console.WriteLine("String sem verbatim: "   +_noVerbatim);
            Console.WriteLine("String com verbatim: "   +_withVerbatim);
            //-------------------------------------------------------------------------------


            // EX 5
            Console.WriteLine("EX 5 ----------------------------");

            // Simple concatenation
            Console.WriteLine("Student name is:" +" Steven " + "Hall");
            
            // Interpolation
            Console.WriteLine($"User first name is {_firstName} and last name is {_lastName}");
            // interpolation and sum operation
            Console.WriteLine($"The value of x is: {x} and y is: {y}. Their sum is: {x + y}");


            // String.Format applied directly in WriteLine();
            Console.WriteLine(string.Format("Y e’ {1}, X e’ {0}", x, y));


            // Use of verbatim, REMEMBER it does work as a interpolation
            Console.WriteLine(@"string com Verbatim x = {2} e y = {3} and their sum is: {2+3}");
            //-------------------------------------------------------------------------------


            // EX 6 

            // 1 -
            double xx =  0.12345;
            int ii = 18; 

            // 2 - 
            // Com 2 casas decimais
            Console.WriteLine(xx.ToString("F2"));

            // com uma casa decimal e simbolo de percentagem
            Console.WriteLine($"{xx:F1}%");

            // 3 - hexadecimal
            Console.WriteLine(ii.ToString("X"));

            // moeda
            Console.WriteLine(ii.ToString("C"));



        }
    }
}
