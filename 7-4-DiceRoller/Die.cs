using System;
namespace _7_4_DiceRoller {
    public class Die {
        public Die() {
            dieValue = 0;
        }
        public int dieValue { get; set; }

        public void Roll() {
            var r = new Random();
            dieValue = r.Next(6) + 1;
        }

        public int GetDieValue() {
            return dieValue;
        }
    }
}
