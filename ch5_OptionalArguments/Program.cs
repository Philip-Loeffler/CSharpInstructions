using System;

namespace ch5_OptionalArguments {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("optional args");
        int nb1 = 22;
        int nb2 = 44;
        int nb3 = 11;


        Console.WriteLine("sum is" + Sum(nb1, nb2, nb3));

        Console.WriteLine("bye!");

            }

        // n3 is an optional param
        static int Sum(int n1, int n2, int n3 = 0) {
        return n1 + n2 + n3;
            }
        }
    }
