using System;
using System.Collections.Generic;

namespace lists_ex
{

    public class ListDemo {
        public ListDemo() {
            // Example of public constructor
            List<int> intList = new List<int>();
            intList.Add(2);

            foreach (int num in intList) {
                Console.WriteLine(String.Format("{0}", num));
            }
            
        }

        public static void AnotherList() {
            List<double> floatList = new List<double>() {1.0, 2.0, 3.3, 4.8};
            foreach (double el in floatList) {
                Console.WriteLine($"{el}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj = new ListDemo();
            ListDemo.AnotherList();
        }
    }
}
