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
            // Below will through NullReferenceException
            // Console.WriteLine($"Length of null string {nullString.Length}"); 

            string fname = "Gaurav";
            string lname = "Singh";

            Console.WriteLine(fname + " " + lname);

            // Additional string functions:
            string test = "Test_String";
            Console.WriteLine(test.ToUpper());
            Console.WriteLine(test.ToLower());

            string addn = " Steve ";
            Console.WriteLine(addn.TrimStart());
            Console.WriteLine(addn.TrimEnd());
            Console.WriteLine(addn.Trim());
            Console.WriteLine(addn.Substring(0, 2));

            // Replacing part of strings
            lastName = "Rockbottom";

            Console.WriteLine($"Hello mr {lastName}"); // string interpolation - recommended
            Console.WriteLine(String.Format("Hello mr {0}", lastName));
            Console.WriteLine("Hello mr " + lastName);
            Console.WriteLine("Hello mr **NAME**".Replace("**NAME**", lastName)); // template way

        }
    }
}
