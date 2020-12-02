using System;

namespace TravelTimeCalculator {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Welcome to the travel time calculator");
        double minutesPerHour = 60;
        double distance;
        double mph;
        double roundedMinutes;
        double roundedHours;

        distance = double.Parse(Console.ReadLine());
        mph = double.Parse(Console.ReadLine());
        Console.WriteLine("Estimated Travel Time");

        double hours = (distance / mph);
        double minutes = ((distance / mph * minutesPerHour) % minutesPerHour);
        roundedMinutes = Math.Round(minutes, 0);
        roundedHours = Math.Floor(hours);
        Console.WriteLine("Hours" + roundedHours);
        Console.WriteLine("Minutes" + roundedMinutes);


            }
        }
    }
