using System;
using _7_4_DiceRoller;
namespace _7_4_DiceRoller {
    public class Dice {
        public Dice() {
            DiceValueOne = new Die();
            DiceValueTwo = new Die();
        }

        public Die DiceValueOne;
        public Die DiceValueTwo;
        public int DiceSum;

        public int GetDie1Value() {
            return DiceValueOne.GetDieValue();
        }

        public int GetDie2Value() {
            return DiceValueTwo.GetDieValue();
        }

        public int SumOfDice(int DiceValueOne, int DiceValueTwo) {
            return DiceSum = DiceValueOne + DiceValueTwo;
            Console.WriteLine(DiceSum);
        }

        public void RollDice() {
            DiceValueOne.Roll();
            DiceValueTwo.Roll();
        }

        public void PrintDiceRoll(int DiceValueOne, int DiceValueTwo) {
            Console.WriteLine(DiceValueOne);
            Console.WriteLine(DiceValueTwo);
            Console.WriteLine(SumOfDice(DiceValueOne, DiceValueTwo));
            if (SumOfDice(DiceValueOne, DiceValueTwo) == 7) {
                Console.WriteLine("craps");
            } else if (SumOfDice(DiceValueOne, DiceValueTwo) == 2) {
                Console.WriteLine("snack eyes");
            } else if (SumOfDice(DiceValueOne, DiceValueTwo) == 12) {
                Console.WriteLine("box cars");
            }
        }
    }
}
