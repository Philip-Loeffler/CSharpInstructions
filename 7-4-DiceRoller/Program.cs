using System;
using _7_4_DiceRoller;
using ConsoleClass;
namespace _7_4_DiceRoller {
    class Program {
        static void Main(string[] args) {
            Dice dice = new Dice();
            int die1;
            int die2;
            Console.WriteLine("Welcome to the dice roller!");
            dice.RollDice();
            die1 = dice.GetDie1Value();
            die2 = dice.GetDie2Value();
            dice.PrintDiceRoll(die1, die2);

        }
    }
}
