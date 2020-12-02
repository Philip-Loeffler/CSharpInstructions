using System;

namespace ch3_switchStatement {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("switch statement demo!");
        Console.WriteLine("enter a number between 1 and 7!");

        int n = Int32.Parse(Console.ReadLine());
        String dow = " ";
        switch (n) {
            case 1:
                dow = "Monday";
                break;
            case 2:
                dow = "Tuesday";
                break;
            case 3:
                dow = "Wednesday";
                break;
            case 4:
                dow = "Thursday";
                break;
            case 5:
                dow = "Friday";
                break;
            case 6:
                dow = "Saturday";
                break;
            case 7:
                dow = "Sunday";
                break;
            default:
                dow = "invald dow";
                break;




            }
        Console.WriteLine("day of week is" + dow);



        Console.WriteLine("bye!");


            }
        }
    }
