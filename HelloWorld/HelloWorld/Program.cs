using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("abc");
            int n1 = 5;
            int n2 = 2;
            Int32 n4 = 11;
            Console.WriteLine("sum = " + (n1 + n2));
            var t1 = "Hello";

            // this is a single line comment

            /*
             * This
             * is
             * a
             * multi-
             * line (block)
             * comment
             */

            double d1 = 5.7;
            double d2 = 54.2;
            Console.WriteLine("double sum is " + (d1 + d2));

            Console.WriteLine("Enter a whole number: ");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("you entered: " + n4);
            if (n4 > 10) {
                Console.WriteLine("Your number is greater than 10");
            } else {
                Console.WriteLine("Your number is less than or equal to 10");
            }
            String choice = "y";
            while (choice.Contains("y")) {
                Console.WriteLine("In the loop...");
                Console.WriteLine("Continue?");
                choice = Console.ReadLine();
            }
        }
    }
}
