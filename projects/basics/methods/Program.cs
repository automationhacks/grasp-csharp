using System;

namespace methods
{
    class Program
    {
        public static string firstName;
        public static string lastName;

        static int staticMethod(int num1, int num2) {
            return num1 + num2;
        }

        string instanceMethod() {
            return $"{firstName} {lastName}";
        }

        static void Main(string[] args)
        {
            firstName = "Gaurav";
            lastName = "Singh";
            Program program = new Program();
            Console.WriteLine(staticMethod(1, 20));
            Console.WriteLine(program.instanceMethod());
        }
    }
}
