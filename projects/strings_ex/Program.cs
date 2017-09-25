using System;

namespace strings_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Steven";
            string lastName = "Smith";
            Console.WriteLine($"{name} {lastName}");

            string emptyString = string.Empty;
            string nullString = null;

            Console.WriteLine($"Length of empty string {emptyString.Length}");
            Console.WriteLine($"Length of null string {nullString.Length}");
        }
    }
}
