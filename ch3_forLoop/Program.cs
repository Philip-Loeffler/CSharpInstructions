using System;

namespace ch3_forLoop {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("for loops!");

        Console.Write("Enter a whole number");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
        Console.WriteLine("hello" + i);

            }
            }
        }
    }
