using System;
using System.Collections.Generic;

namespace ListAndDictionary {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create a list and a dictionary");

            //list
            List<double> prices = new List<double>();
            prices.Add(5.99);
            prices.Add(22.22);
            prices.Add(13.13);

            Console.WriteLine(prices[1]);
            for (int i = 0; i < prices.Count; i++) {
                Console.WriteLine(prices[i]);
            }

            foreach (var price in prices) {
                Console.WriteLine(price);
            }
        }
    }
}
