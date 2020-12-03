using System;

namespace DiceRoller {
    class Program {
        static void Main(string[] args) {
            var r = new Random();
            int total;
            String choice = "y";

            Console.WriteLine("DiceRoller!");
            Console.WriteLine("Roll the dice!!");
            while (choice.Equals("y")) {
                Console.WriteLine("dice 1:" + DiceOne());
                Console.WriteLine("dice 2:" + DiceTwo());
                total = DiceOne() + DiceTwo();

                if (total == 12) {
                    Console.WriteLine(total + " " + "snack eyes");
                } else if (total == 2) {
                    Console.WriteLine(total + " " + "box cards");
                } else {
                    Console.WriteLine(total);
                }

                Console.WriteLine("Roll again? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");

        }



        private static int DiceOne() {
            var r = new Random();
            int d1 = r.Next(6) + 1;
            return d1;
        }

        private static int DiceTwo() {
            var r = new Random();
            int d2 = r.Next(6) + 1;
            return d2;
        }

    }

}


