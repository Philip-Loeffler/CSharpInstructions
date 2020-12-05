using System;

namespace GuessingGame {
    class Program {
        static void Main(string[] args) {
            var r = new Random();
            int randomNumber = r.Next(100);
            int myGuess;
            int guesses = 0;
            Boolean guessing = false;
            String choice = "y";
            GamePrompt();

            while (!guessing) {
                myGuess = GetIntWithinRange("\nEnter number: ", 0, 100);
                Guess(myGuess, randomNumber);
                if (myGuess == randomNumber) {
                    guessing = true;
                }
                guesses++;

            }
            Console.WriteLine(guesses);
            NumberOfGuess(guesses);

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

        public static void NumberOfGuess(int guesses) {
            if (guesses <= 3) {
                Console.WriteLine("Great work! You are a mathematical wizard.");
            } else if (guesses > 3 && guesses <= 7) {
                Console.WriteLine("not to bad you got some potential.");
            } else if (guesses > 7) {
                Console.WriteLine("What took you so long? Maybe you should take some lessons.");
            } else {
                Console.WriteLine("nope");

            }
        }

        public static void GamePrompt() {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("I'm thinking of a number between 1-100");
            Console.WriteLine("try to guess it");
        }


        public static int GetIntWithinRange(String prompt, int min, int max) {
            int num = 0;
            Boolean success = false;
            while (!success) {
                try {
                    Console.Write(prompt);
                    num = int.Parse(Console.ReadLine());
                    if (num > min && num <= max) {
                        success = true;
                    } else {
                        Console.WriteLine("Invalid entry. Enter a number between 1 and 100.");
                    }
                } catch (Exception e) {
                    Console.WriteLine("Invalid entry. Enter a number between 1 and 100.");
                }
            }
            return num;
        }
    }
}






