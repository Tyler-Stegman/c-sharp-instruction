using System;

namespace ch3_temperature_converter_app {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();
            string choice = "y";
            while (choice.Contains("y") || choice.Contains("Y")) {
                Console.Write("Enter degrees in Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());
                double c = (f - 32) * 5 / 9;
                Console.WriteLine("Degrees in Celsius: " + Math.Round(c, 2));
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using the Temperature Converter!");
        }
    }
}
