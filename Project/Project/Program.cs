using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    class Program
    {
        // Memory collection to store up to 10 values
        private static List<double> memoryList = new List<double>();
        private const int MaxMemorySize = 10;

        static void Main(string[] args)
        {
            // Print informative header with Week 3 indicator, title, and name
            Console.WriteLine("========================================");
            Console.WriteLine("Project Week 3: Arrays, Lists & Math");
            Console.WriteLine("Developer: Christopher Creamer");
            Console.WriteLine("========================================");

            Console.WriteLine("\nWelcome to the Console Calculator!");
            Console.WriteLine("Instructions: Use the menu below to calculate, manage memory, and view lists.\n");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Add numbers");
                Console.WriteLine("2. Subtract numbers");
                Console.WriteLine("3. Multiply numbers");
                Console.WriteLine("4. Divide numbers");
                Console.WriteLine("5. Square Root (Math Library)");
                Console.WriteLine("6. Power (Math Library)");
                Console.WriteLine("7. View Memory List (Up to 10 values)");
                Console.WriteLine("8. Clear Memory");
                Console.WriteLine("9. Quit");
                Console.Write("Enter your choice (1-9): ");

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
                        PerformSquareRoot();
                        break;
                    case "6":
                        PerformPower();
                        break;
                    case "7":
                        ViewMemory();
                        break;
                    case "80": // Or 8
                        ClearMemory();
                        break;
                    case "8":
                        ClearMemory();
                        break;
                    case "9":
                        running = false;
                        Console.WriteLine("\nThank you for using your calculator! Have a great day.");
                        break;
                    default:
                        Console.WriteLine("\n[Error]: Invalid selection. Please enter a number between 1 and 9.");
                        break;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void StoreResult(double value)
        {
            if (memoryList.Count >= MaxMemorySize)
            {
                memoryList.RemoveAt(0); // Remove oldest value if capacity is reached
            }
            memoryList.Add(value);
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
            StoreResult(result);
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
            StoreResult(result);
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
            StoreResult(result);
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
                StoreResult(result);
            }
        }

        static void PerformSquareRoot()
        {
            Console.WriteLine("\n--- Square Root (Math Library) ---");
            Console.Write("Enter number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("[Error]: Cannot calculate square root of a negative number.");
            }
            else
            {
                double result = Math.Sqrt(num);
                Console.WriteLine($"Result: sqrt({num}) = {result:F2}");
                StoreResult(result);
            }
        }

        static void PerformPower()
        {
            Console.WriteLine("\n--- Power (Math Library) ---");
            Console.Write("Enter base number: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent: ");
            double exp = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(baseNum, exp);
            Console.WriteLine($"Result: {baseNum}^{exp} = {result:F2}");
            StoreResult(result);
        }

        static void ViewMemory()
        {
            Console.WriteLine("\n--- Stored Memory List (Max 10) ---");
            if (memoryList.Count == 0)
            {
                Console.WriteLine("Memory is currently empty.");
            }
            else
            {
                for (int i = 0; i < memoryList.Count; i++)
                {
                    Console.WriteLine($"Slot {i + 1}: {memoryList[i]:F2}");
                }
            }
        }

        static void ClearMemory()
        {
            memoryList.Clear();
            Console.WriteLine("\n[Info]: Memory cleared successfully.");
        }
    }
}