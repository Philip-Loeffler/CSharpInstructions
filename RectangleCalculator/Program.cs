using System;

namespace RectangleCalculator {
    class Program {
        static void Main(string[] args) {
        String choice = "y";
        double length;
        double width;
        double area;
        double perimeter;


        Console.WriteLine("Welcome to the Area and Perimeter Calculator!");

        while (choice.Equals("y")) {
        Console.WriteLine("Enter length");
        length = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter width");
        width = Int32.Parse(Console.ReadLine());
        area = width * length;
        perimeter = 2 * (width + length);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
        Console.WriteLine("continue (y/n)");
        Console.ReadLine();
            }
        Console.WriteLine("peace ya fools");

            }
        }
    }
