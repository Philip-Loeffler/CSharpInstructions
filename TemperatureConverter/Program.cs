using System;

namespace TemperatureConverter {
    class Program {
        static void Main(string[] args) {
        double fahrenheit;
        String choice = "y";
        Console.WriteLine("Welcome to the temperature converter!");
        while (choice.Equals("y")) {
        Console.WriteLine("Enter the degree's in Fahrenheit!");
        fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        double convertedCelsius = Math.Round(celsius, 2);
        Console.WriteLine("Degree's in Celsius!" + convertedCelsius);
        Console.WriteLine("would you like to continue? (y/n)");
            }
        Console.WriteLine("bye");
            }
        }
    }
