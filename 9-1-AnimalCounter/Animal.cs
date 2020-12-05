using System;
using AnimalCounter;
namespace AnimalCounter {
    abstract class Animal : Countable {

        public int count;

        public Animal() {
        }
        public void IncrementCount() {
            count++;
        }

        public void ResetCount() {
            count = 0;
        }

        public int GetCount() {
            return count;
        }

        public string GetCountString() {
            return $"{count}";
        }

    }
}
