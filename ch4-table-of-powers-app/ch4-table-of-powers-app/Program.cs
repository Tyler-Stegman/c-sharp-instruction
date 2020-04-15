using System;

namespace ch4_table_of_powers_app {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Squares and Cubes Table");
            Console.WriteLine();
            String choice = "y";
            while(choice.Contains("y") || choice.Contains("Y")) {
                Console.Write("Enter an integer: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t======\t======");
                for (int i = 1; i <= integer; i++) {
                    int squared = i * i;
                    int cubed = i * i * i;
                    Console.WriteLine(i + "\t" + squared + "\t" + cubed);
                }

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using the Squares and Cubes Table!");
        }
    }
}
