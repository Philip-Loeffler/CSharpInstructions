using System;

namespace ch5_methods {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Calls some methods!");

        int n = GetInt("Enter a whole number");
        Console.WriteLine("you entered the number" + n);

        int age = GetInt("Enter actor age: ");
        Console.WriteLine("actors age" + age);



        Console.WriteLine("bye");


            }

        private static int GetInt(String prompt) {
        int n = 0;
        Boolean success = false;
        while (!success) {
        Console.Write(prompt);

        try {
        n = int.Parse(Console.ReadLine());
        success = true;
            } catch (Exception ex) {
        Console.WriteLine("invalid entry. not a whole number. try again");
            }
            }
        return n;
            }
        }
    }
