using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPwClass
{
    class VolumeConverter
    {
        public static void ConvertVolume()
        {
            Console.WriteLine("Volume Converter");
            Console.WriteLine("----------------");

            List<UnitConversion> conversions = new List<UnitConversion>
            {
                new UnitConversion("Liters", "Gallons", liters => liters * 0.264172),
                new UnitConversion("Gallons", "Liters", gallons => gallons / 0.264172),
                new UnitConversion("Cubic Meters", "Cubic Feet", cubicMeters => cubicMeters * 35.3147),
                new UnitConversion("Cubic Feet", "Cubic Meters", cubicFeet => cubicFeet / 35.3147)
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

                double volume;
                Console.Write("Enter the volume value: ");
                if (!double.TryParse(Console.ReadLine(), out volume))
                {
                    Console.WriteLine("Invalid volume value. Please enter a valid number.");
                    continue;
                }

                UnitConversion selectedConversion = conversions[choice - 1];
                double convertedValue = selectedConversion.ConversionFunc(volume);

                Console.WriteLine($"{volume} {selectedConversion.FromUnit} is equal to {convertedValue} {selectedConversion.ToUnit}.");
                Console.WriteLine();
            }
        }
    }
}