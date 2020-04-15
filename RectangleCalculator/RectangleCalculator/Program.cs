using System;

namespace RectangleCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();
            String choice = "y";
            while (choice.Contains("y")) {
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (width * length));
                Console.WriteLine("Perimeter: " + ((2 * width) + (2 * length)));
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using the Rectangle Calculator");
        }
    }
}
