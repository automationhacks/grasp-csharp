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

        public void initListFromArray() {
            string[] colours = "red,blue,green,yellow".Split(",");
            List<string> colourList = new List<string>(colours);

            foreach(string colour in colourList) {
                Console.WriteLine($"{colour}");
            }
        }

        public void listOperations() {
            List<string> newColours = new List<string> {"Voilet", "Indigo", "Blue", "Green"};
            newColours.Add("Yellow"); // Add elements to list
            newColours.ForEach(Console.WriteLine); // Apply single function to all elements of list
            Console.WriteLine("===============");

            newColours.AddRange(new List<string> {"Orange", "Red"});
            newColours.ForEach(Console.WriteLine);
            Console.WriteLine("===============");

            newColours.Remove("Indigo"); // Remove matching element
            newColours.ForEach(Console.WriteLine);
            Console.WriteLine("===============");

            newColours.Insert(1, "Gaurav"); // Insert at an index
            newColours.ForEach(Console.WriteLine);
            Console.WriteLine("===============");

            newColours.RemoveAll(c => c.Contains("O")); // Remove elements containing O
            newColours.ForEach(Console.WriteLine);
            Console.WriteLine("===============");

            newColours.Clear();
            newColours.ForEach(Console.WriteLine);
            Console.WriteLine("===============");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj = new ListDemo();
            obj.listOperations();
        }
    }
}
