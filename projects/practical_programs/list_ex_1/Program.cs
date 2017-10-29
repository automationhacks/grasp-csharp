/*
Write a simple program that lets the user manage a list of elements. 
It can be a grocery list, "to do" list, etc. 
Refer to Looping Based on a Logical Expression if necessary to see how to implement 
an infinite loop. 
Each time through the loop, ask the user to perform an operation, 
and then show the current contents of their list. 
The operations available should be Add, Remove, and Clear. 
The syntax should be as follows:

+ some item
- some item
--

Your program should read in the user's input and determine 
if it begins with a "+" or "-", or if it is simply "--". 
In the first two cases, your program should add or remove the string 
given ("some item" in the example). 
If the user enters just "--" then the program should clear the current list. 
Your program can start each iteration through its loop with the following 
instruction: Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

 */

using System;
using System.Collections.Generic;

namespace list_ex_1
{
    class Program
    {

        public static List<string> addItem(List<string> toDoList, string item) {
            toDoList.Add(item);
            return toDoList;
        }

        public static List<string> removeItem(List<string> toDoList, string item) {
            toDoList.Remove(item);
            return toDoList;
        }

        public static List<string> clearAll(List<string> toDoList) {
            toDoList.Clear();
            return toDoList;
        }

        public static void manageList() {

            List<string> toDoList = new List<string>();

            while(true) {
                Console.WriteLine("Enter command: + item, - item or -- to clear all");
                var userInput = Console.ReadLine();
                var split = userInput.Split();
                var item = split[1];

                switch (split[0]) {
                    case "+":
                        toDoList = addItem(toDoList, item);
                        break;
                    case "-":
                        toDoList = removeItem(toDoList, item);
                        break;
                    case "--":
                        toDoList = clearAll(toDoList);
                        break;
                    default:
                        Console.WriteLine("Invalid input provided, terminating program!!");
                        break;
                }
                Console.WriteLine("Current items in list: ");
                toDoList.ForEach(Console.WriteLine);
            }
            
        }

        static void Main(string[] args)
        {
            manageList();
        }
    }
}
