using System;

namespace BasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic .NET Console Application!");
            Console.WriteLine();
            
            // Get user input
            Console.Write("What's your name? ");
            string? name = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine($"Hello, {name}! Nice to meet you.");
            }
            else
            {
                Console.WriteLine("Hello, Anonymous!");
            }
            
            // Simple calculation example
            Console.WriteLine();
            Console.WriteLine("Let's do a simple calculation:");
            Console.Write("Enter a number: ");
            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int doubled = number * 2;
                Console.WriteLine($"{number} multiplied by 2 equals {doubled}");
            }
            else
            {
                Console.WriteLine("That's not a valid number!");
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

