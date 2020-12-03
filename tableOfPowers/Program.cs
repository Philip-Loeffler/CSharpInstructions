using System;

namespace tableOfPowers {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Welcome to the Squares and cubes table");
        int squared;
        int cubed;
        Console.WriteLine("enter an integer");
        int number = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++) {
        squared = i * i;
        cubed = i * i * i;
        Console.Write(i);
        Console.Write("\t" + squared);
        Console.Write("\t" + cubed);
            }
            }
        }
    }
