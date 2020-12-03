using System;

namespace GuessingGame {
    class Program {
        static void Main(string[] args) {
            var r = new Random();
            int randomNumber = r.Next(100);
            int myGuess;
            Boolean guessing = false;
            String choice = "y";

            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            Console.WriteLine("I'm thinking of a number between 1-100");
            Console.WriteLine("try to guess it");
            while (!guessing && choice.Equals("y")) {
                myGuess = int.Parse(Console.ReadLine());
                Guess(myGuess, randomNumber);
                if (myGuess == randomNumber) {
                    guessing = true;
                }
            }
        }

        public static void Guess(int guess, int randomNumber) {
            if (guess > randomNumber) {
                Console.WriteLine("guess is to high");
            } else if (guess < randomNumber) {
                Console.WriteLine("guess is to low");
            } else if (guess == randomNumber) {
                Console.WriteLine("you got it!");

            }
        }
    }

}



