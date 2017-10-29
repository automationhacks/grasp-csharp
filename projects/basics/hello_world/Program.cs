using System; // Library which stores the Console class

namespace projects // a.k.a Folders, used to organize program constructs
{
    class Program // Program class
    {
        static void Main(string[] args)
        {
            var name = "Gaurav";
            Console.WriteLine("Hello " + name); // Console is static with a WriteLine method
            Console.WriteLine($"Hello {name}!"); // Another variation of string substitution
        }
    }
}
