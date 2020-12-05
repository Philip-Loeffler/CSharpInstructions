using System;
using ProductManager.business;

namespace ProductManager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the product manager");

            Product p1 = new Product();
            p1.code = ".net";
            p1.description = "Murach's c# and .Net";
            p1.price = 58.99;
            Console.WriteLine(p1);

            Product p2 = new Product("java", "murachs java programming", 59.50);
            Console.WriteLine("$p2:" + p2);



            Console.WriteLine("bye");

        }
    }
}
