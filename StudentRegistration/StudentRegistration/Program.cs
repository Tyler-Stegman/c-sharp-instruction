using System;

namespace StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");
            String choice = "y";
            while (choice.Contains("y")) {
                Console.WriteLine("Enter first name: ");
                String FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                String LastName = Console.ReadLine();
                Console.WriteLine("Enter year of birth: ");
                int BirthYear = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Welcome " + FirstName + " " + LastName + "!");
                Console.WriteLine("Your registration is complete.");
                Console.WriteLine("Your temporary password is: " + FirstName + "*" + BirthYear);
                Console.WriteLine("Continue?");
                choice = Console.ReadLine();
            }
        }
    }
}
