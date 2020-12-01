using System;

namespace GradeConverter {
    class Program {
        static void Main(string[] args) {
        String choice = "y";
        String letterGrade;

        Console.WriteLine("Welcome to the letter Grade converter");

        while (choice.Equals("y")) {

        Console.WriteLine("Enter numerical grade");
        int numericGrade = Int32.Parse(Console.ReadLine());
        if (numericGrade >= 88) {
        Console.WriteLine("lettergrade: A");
            } else if (numericGrade >= 80) {
        Console.WriteLine("lettergrade: B");
            } else if (numericGrade >= 67) {
        Console.WriteLine("lettergrade: C");
            } else if (numericGrade >= 60) {
        Console.WriteLine("lettergrade: D");
            } else {
        Console.WriteLine("lettergrade: F");
            }
        Console.WriteLine("continue? (y/n)");
        Console.ReadLine();

            }
        Console.WriteLine("peace ya jerk");
            }

        }
    }

