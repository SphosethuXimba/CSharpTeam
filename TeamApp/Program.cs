using System;

namespace TeamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Team Application");

            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.WriteLine("1 - Greeting");
            Console.WriteLine("2 - Calculator");
            Console.WriteLine("3 - Exit");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Greeting();
            }
            else if (choice == 2)
            {
                Calculator();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Goodbye!");
            }
        }

        static void Greeting()
        {
            Console.WriteLine("Hello from the greeting feature!");
        }

        static void Calculator()
        {
            Console.WriteLine("Calculator feature coming soon...");
        }
    }
}