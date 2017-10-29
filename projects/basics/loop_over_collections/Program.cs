using System;
using System.Collections.Generic;

namespace loop_over_collections
{
    class Program
    {

        static void forEachDemo() {
            var myList = new List<string>() {
                "red",
                "blue",
                "green"
            };

            // Method one to iterate over collection
            foreach(var item in myList) {
                Console.WriteLine(item);
            }

            // ForEach method can be used in case a single operation needs to
            // be applied for each item of the list
            Console.WriteLine("=========");
            myList.ForEach(Console.WriteLine);
        }

        static void Main(string[] args)
        {
            forEachDemo();
        }
    }
}
