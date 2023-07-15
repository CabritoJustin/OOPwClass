using System;

namespace OOPwClass
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unit Converter");
            Console.WriteLine();

            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to my unit converter");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Please select the conversion type:");
                Console.WriteLine("1. Length Converter");
                Console.WriteLine("2. Volume Converter");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice (1-3): ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                    continue;
                }

                if (choice == 3)
                {
                    exitProgram = true;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank you for using this unit converter!!");
                    Console.ResetColor();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        LengthConverter.ConvertLength();
                        break;
                    case 2:
                        VolumeConverter.ConvertVolume();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}