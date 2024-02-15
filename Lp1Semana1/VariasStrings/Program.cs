using System;

namespace VariasStrings
{
    class Program
    {
        private static string _name = "Steve";

        private static string _simplePath = "C:\\Users\\Steve\\Documents";

        private static string _path = @"C:\Users\Steve\Documents";

        private static string s = @"""Esta string esta ’ entre aspas""";

        static void Main(string[] args)
        {
            Console.WriteLine("User Name: " +_name);

            Console.WriteLine("Path without verbatin: " +_simplePath);

            Console.WriteLine("Path with verbatin: " +_path);

            Console.WriteLine(s);
        }
    }
}
