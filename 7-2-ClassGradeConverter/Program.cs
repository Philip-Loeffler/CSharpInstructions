using System;
using product_manager;
using GradeClass;
namespace _7_2_ClassGradeConverter {
    class Program {
        static void Main(string[] args) {
            String choice = "y";
            Grade grade = new Grade();
            Console.WriteLine("Welcome to the Letter Grade Converter");

            while (choice.Equals("y")) {
                grade.number = MyConsole.getInt("enter numerical grade");

                Console.WriteLine(GradeChecker(grade.number));

                MyConsole.getString("continue (y/n)");
            }
            Console.WriteLine("badabing, badaBYE");
        }






        public static String GradeChecker(int number) {
            Grade grade = new Grade();
            if (number >= 88) {
                return grade.letter = "lettergrade: A";
            } else if (number >= 80) {
                return grade.letter = "lettergrade: B";
            } else if (number >= 67) {
                return grade.letter = "lettergrade: C";
            } else if (number >= 60) {
                return grade.letter = "lettergrade: D";
            } else {
                return grade.letter = "lettergrade: F";
            }


        }
    }
}
