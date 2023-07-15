using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPwClass
{
    class LengthConverter
    {
        public static void ConvertLength()
        {
            Console.WriteLine("Length Converter");
            Console.WriteLine("----------------");

            List<UnitConversion> conversions = new List<UnitConversion>
            {
                new UnitConversion("Meters", "Feet", meters => meters * 3.28084),
                new UnitConversion("Feet", "Meters", feet => feet / 3.28084),
                new UnitConversion("Kilometers", "Miles", kilometers => kilometers * 0.621371),
                new UnitConversion("Miles", "Kilometers", miles => miles / 0.621371),
                new UnitConversion("Inches", "Centimeters", inches => inches * 2.54),
                new UnitConversion("Centimeters", "Inches", centimeters => centimeters / 2.54),
                new UnitConversion("Yards", "Meters", yards => yards * 0.9144),
                new UnitConversion("Meters", "Yards", meters => meters / 0.9144)
            };

            bool exitConverter = false;

            while (!exitConverter)
            {
                Console.WriteLine("Select the conversion type:");
                for (int i = 0; i < conversions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {conversions[i].FromUnit} to {conversions[i].ToUnit}");
                }
                Console.WriteLine($"{conversions.Count + 1}. Back to Main Menu");

                Console.Write("Enter your choice (1-{0}): ", conversions.Count + 1);
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine($"Invalid choice. Please enter a number from 1 to {conversions.Count + 1}.");
                    continue;
                }

                if (choice == conversions.Count + 1)
                {
                    exitConverter = true;
                    Console.WriteLine("Returning to the main menu.");
                    continue;
                }

                if (choice < 1 || choice > conversions.Count)
                {
                    Console.WriteLine($"Invalid choice. Please enter a number from 1 to {conversions.Count + 1}.");
                    continue;
                }

                double length;
                Console.Write("Enter the length value: ");
                if (!double.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Invalid length value. Please enter a valid number.");
                    continue;
                }

                UnitConversion selectedConversion = conversions[choice - 1];
                double convertedValue = selectedConversion.ConversionFunc(length);

                Console.WriteLine($"{length} {selectedConversion.FromUnit} is equal to {convertedValue} {selectedConversion.ToUnit}.");
                Console.WriteLine();
            }
        }
    }
}