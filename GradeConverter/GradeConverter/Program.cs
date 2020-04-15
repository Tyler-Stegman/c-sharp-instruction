using System;

namespace GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grader Converter");
            Console.WriteLine();
            String choice = "y";
            while (choice.Contains("y") || choice.Contains("Y")) {
                Console.Write("Enter numberical grade: ");
                int Grade = int.Parse(Console.ReadLine());
                if (Grade >= 88) {
                    Console.WriteLine("Letter grade: A");
                    Console.WriteLine();
                }
                else if (Grade >= 80 && Grade <= 87) {
                    Console.WriteLine("Letter Grade: B");
                    Console.WriteLine();
                }
                else if (Grade >= 67 && Grade <= 79) {
                    Console.WriteLine("Letter Grade: C");
                    Console.WriteLine();
                }
                else if (Grade >= 60 && Grade <= 66) {
                    Console.WriteLine("Letter Grade: D");
                    Console.WriteLine();
                } 
                else if (Grade <= 59) {
                    Console.WriteLine("Letter Grade: F");
                    Console.WriteLine();
                }
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Thank you for using the Grade Converter!");
        }
    }
}
