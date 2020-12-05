using System;
namespace AnimalCounter {
    interface Countable {
        void IncrementCount();
        void ResetCount();
        int GetCount();
        String GetCountString();
    }
}
