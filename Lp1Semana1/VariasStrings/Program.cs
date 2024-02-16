using System;

namespace VariasStrings
{
    class Program
    {
        private static string _name = "Steve";

        // paths
        private static string _pathWithoutVerbatim = "C:\\Users\\Steve\\Documents";
        private static string _pathWithVerbatim = @"C:\Users\Steve\Documents";

        // text with quotes
        private static string _noVerbatim = "\" Esta string esta' entre aspas\"";
        private static string _withVerbatim = @"""Esta string esta ’ entre aspas""";
       

        static void Main(string[] args)
        {
            Console.WriteLine("User Name: " +_name);

            Console.WriteLine("Path without verbatin: " +_pathWithoutVerbatim);
            Console.WriteLine("Path with verbatin: "    +_pathWithVerbatim);

            Console.WriteLine("String sem verbatim: "   +_noVerbatim);
            Console.WriteLine("String com verbatim: "   +_withVerbatim);
        }
    }
}
