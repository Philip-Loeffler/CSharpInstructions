using System;

namespace ch2_control_structures {
    class Program {
        static void Main(string[] args)
            {
        Console.WriteLine("Welcome to the control structure app!");

        String choice = "y";
        while (choice.Equals("y"))
            {
        Console.Write("enter color letter (r,g,b): ");

        String c = Console.ReadLine();
        if (c.Equals("r"))
            {
        Console.Write("you picked red");
            }
        else if (c.Equals("b"))
            {
        Console.Write("you picked blue");
            }
        else if ()
            {

            }
            {
        Console.Write("you picked red");
            }
        else
            {
        Console.Write("incorrect color letter");
            }

        Console.Write("enter a whole number");
        int nbr = Int32.Parse(Console.ReadLine());
        Console.WriteLine("you entered" + nbr);
        Console.Write("continue");
        choice = Console.ReadLine();
            }


        Console.WriteLine("bye");
            }
        }
    }
