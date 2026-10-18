using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print informative header with Week 2 indicator, title, and name
            Console.WriteLine("========================================");
            Console.WriteLine("Project Week 2: Software Design & Control");
            Console.WriteLine("Developer: Christopher Creamer");
            Console.WriteLine("========================================");

            // Print welcome message and basic instructions
            Console.WriteLine("\nWelcome to the Console Calculator!");
            Console.WriteLine("Instructions: Select an operation from the menu below.\n");

            bool running = true;

            // Looping control to keep the application running until the user quits
            while (running)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Subtract two numbers");
                Console.WriteLine("3. Multiply two numbers");
                Console.WriteLine("4. Divide two numbers");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformAddition();
                        break;
                    case "2":
                        PerformSubtraction();
                        break;
                    case "3":
                        PerformMultiplication();
                        break;
                    case "4":
                        PerformDivision();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("\nThank you for using your calculator! Have a great day.");
                        break;
                    default:
                        Console.WriteLine("\n[Error]: Invalid selection. Please enter a number between 1 and 5.");
                        break;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PerformAddition()
        {
            Console.WriteLine("\n--- Addition ---");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result:F2}");
        }

        static void PerformSubtraction()
        {
            Console.WriteLine("\n--- Subtraction ---");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 - num2;
            Console.WriteLine($"Result: {num1} - {num2} = {result:F2}");
        }

        static void PerformMultiplication()
        {
            Console.WriteLine("\n--- Multiplication ---");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 * num2;
            Console.WriteLine($"Result: {num1} * {num2} = {result:F2}");
        }

        static void PerformDivision()
        {
            Console.WriteLine("\n--- Division ---");
            Console.Write("Enter numerator: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter denominator: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("[Error]: Division by zero is not allowed.");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result:F2}");
            }
        }
    }
}