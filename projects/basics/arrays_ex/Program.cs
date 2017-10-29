using System;

namespace arrays_ex
{

    public class ArrayOperations {
        public static void SingleDim() {
            int[] arr = new int[5];

            for (int i=0; i < 5; i++) {
                arr[i] = i;
            }

            Console.WriteLine($"Array: {arr}");
        } 

        public static void MultiDim() {
            int[,] mult = new int[2, 3] {{1, 1, 1}, {3, 3, 3}};

            for (int i=0; i < 2; i++) {
                for (int j=0; j < 3; j++) {
                    Console.WriteLine(String.Format("{0}", mult[i, j]));
                }
            }
        }

        public static void AddnOperations() {
            string greeting = "Hello, Dude, You, Are, Crazy";
            var splitted = greeting.Split(',');

            foreach (string word in splitted) {
                Console.WriteLine($"{word}");
            }

            var joined = String.Join("|", splitted);
            Console.WriteLine(" " + joined);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations.SingleDim();
            ArrayOperations.MultiDim();
            ArrayOperations.AddnOperations();
        }
    }
}
