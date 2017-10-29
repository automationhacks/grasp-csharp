/*
Write a program that initializes a list integer numbers, 
and then prints the numbers out along with their sum. Sample output:

Numbers: 2 4 6
Sum: 12

 */

using System;
using System.Collections.Generic;

namespace loop_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() {2, 4, 6, 8};
            var sum = 0;
            for (int i=0; i < intList.Count; i++) {
                sum += intList[i];
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
