using System;

namespace loops_ex
{   
    public class LoopsExample {
        public void WhileExample(int num) {
            while (num < 10) {
                Console.WriteLine($"Current # {num}");
                num += 1;

                if (num == 4) {
                    break; // exit out of the loop
                }
            }
        }

        public void ForExample(int range=4, int num=24) {
            /* Achieve the below output
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
            0,2,4,6,8,10,12,14,16,18,20,22,24
            0,3,6,9,12,15,18,21,24
            0,4,8,12,16,20,24
             */
            Console.WriteLine($"Inside For example with range = {range} and num = {num}");
            for (int i=0; i < range; i++) {
                var temp = "";

                for (int j=0; j <= num; j+=i+1) {
                    var conv = String.Format("{0}", j);
                    temp = temp + conv + ",";
                }
                Console.WriteLine(temp);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            LoopsExample loops = new LoopsExample();
            // loops.WhileExample(8);

            loops.ForExample();
        }
    }
}
