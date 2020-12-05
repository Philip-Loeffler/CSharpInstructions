using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");


            String[] names = { "chris", "josh", "derek", "monroe" };
            Console.WriteLine("element at position one:" + names[1]);

            //index for loop
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }

            //foreach for loop
            foreach (string name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
