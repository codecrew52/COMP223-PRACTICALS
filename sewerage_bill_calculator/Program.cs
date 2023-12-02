using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Sewerage Bill Calculator.");
        Console.Write("Enter water consumption in cubic meters: ");
        if (!double.TryParse(Console.ReadLine(), out double waterConsumption) || waterConsumption < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for water consumption.");
            return;
        }

        Console.Write("Enter usage type (Residential, Commercial, or Industrial): ");
        string usageType = Console.ReadLine().Trim().ToLower();
        double rate;
        switch (usageType)
        {
            case "residential":
                rate = 10.00;
                break;
            case "commercial":
                rate = 12.50;
                break;
            case "industrial":
                rate = 15.00;
                break;
            default:
                Console.WriteLine("Invalid usage type. Please enter Residential, Commercial, or Industrial.");
                return;
        }

        double billAmount = CalculateBill(waterConsumption, rate);
        Console.WriteLine($"Monthly sewerage bill: {billAmount} KES");
    }

    static double CalculateBill(double waterConsumption, double rate)
    {
        return waterConsumption * rate;
    }
}
