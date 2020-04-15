using System;

namespace ch7_contact_list {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Contact List application");
            Console.WriteLine();
            String choice = "y";

            while (choice.Contains("y") || choice.Contains("Y")){
                Console.Write("Enter first name: ");
                string firstname = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastname = Console.ReadLine();
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                Console.Write("Enter phone: ");
                string phone = Console.ReadLine();
                Contact c = new Contact(firstname, lastname, email, phone);
                Console.WriteLine(c.Display());
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Thank you for using the Contact List application");
        }
    }
}
