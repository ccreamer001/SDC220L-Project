using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print informative header with Week 1 indicator, title, and name[cite: 8]
            Console.WriteLine("========================================");
            Console.WriteLine("Project Week 1: User Interactions and I/O");
            Console.WriteLine("Developer: Christopher Creamer");
            Console.WriteLine("========================================");

            // Print welcome message and basic instructions[cite: 8]
            Console.WriteLine("\nWelcome to the Console Calculator!");
            Console.WriteLine("Instructions: Follow the prompts to perform integer and floating-point operations.\n");
            Console.WriteLine("Quote: \"Code is like humor. When you have to explain it, it’s bad.\"\n");

            try
            {
                // Integer Operations: Allow user to enter two integers, add them, and display result[cite: 8]
                Console.WriteLine("--- Integer Addition ---");
                Console.Write("Enter first integer: ");
                int int1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int int2 = Convert.ToInt32(Console.ReadLine());

                int intSum = int1 + int2;
                Console.WriteLine($"Result: {int1} + {int2} = {intSum:F2}\n");

                // Floating-Point Operations: Allow user to enter two floats, subtract first from second, and display result[cite: 8]
                Console.WriteLine("--- Floating-Point Subtraction ---");
                Console.Write("Enter first floating-point value: ");
                double float1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second floating-point value: ");
                double float2 = Convert.ToDouble(Console.ReadLine());

                double floatDiff = float2 - float1; 
                Console.WriteLine($"Result: {float2} - {float1} = {floatDiff:F2}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n[Error]: Invalid numeric format entered. Please restart and enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Error]: An unexpected error occurred: {ex.Message}");
            }

            // Closing Message thanking the user[cite: 8]
            Console.WriteLine("\nThank you for using your calculator! Have a great day.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}