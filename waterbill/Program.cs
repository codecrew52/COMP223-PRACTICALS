using System;
using System.Globalization;

class WaterBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Water Bill Calculator!");
        Console.Write("Enter the water consumption in cubic meters: ");
        if (!double.TryParse(Console.ReadLine(), out double waterConsumption) || waterConsumption < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for water consumption.");
            return;
        }
        Console.Write("Enter the usage type (residential/commercial/industrial): ");
        string usageType = Console.ReadLine().ToLower();

        double rate;
        switch (usageType)
        {
            case "residential":
                rate = 25.00;
                break;
            case "commercial":
                rate = 30.50;
                break;
            case "industrial":
                rate = 35.75;
                break;
            default:
                Console.WriteLine("Invalid usage type. Please enter residential, commercial, or industrial.");
                return;
        }

        double totalBill = waterConsumption * rate;
        Console.WriteLine("\nWater Bill Summary:");
        Console.WriteLine($"Usage Type: {usageType}");
        Console.WriteLine($"Water Consumption: {waterConsumption} cubic meters");
        Console.WriteLine($"Rate: {rate.ToString("F2", CultureInfo.CreateSpecificCulture("en-KES"))} per cubic meter");
        Console.WriteLine($"Total Bill: {totalBill.ToString("F2", CultureInfo.CreateSpecificCulture("en-KES"))}");

        Console.ReadLine();
    }
}
