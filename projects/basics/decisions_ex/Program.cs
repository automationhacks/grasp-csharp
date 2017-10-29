using System;

namespace decisions_ex
{
    public class Decisions {
        public static void Decide(string input) {
            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("Provide valid input");
            }
            else {
                Console.WriteLine($"Input is valid {input}");
            }
        }
    }

    public class ElaborateDecisions {
        public static void SwitchDemo(string input) {
            switch (input)
            {
                case "Mon":
                    Console.WriteLine("Its Monday");
                    break;
                default:
                    Console.WriteLine("Ackk Error!!");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Decisions.Decide("");
            Decisions.Decide("Yahoo!!");

            ElaborateDecisions.SwitchDemo("Mon");
            ElaborateDecisions.SwitchDemo("");
        }
    }
}
