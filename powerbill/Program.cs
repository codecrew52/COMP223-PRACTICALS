using System;

class PowerBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Power Bill Calculator!");
        double powerConsumption;
        do
        {
            Console.Write("Enter your power consumption in kWh: ");
            if (!double.TryParse(Console.ReadLine(), out powerConsumption) || powerConsumption < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number for power consumption.");
            }
        } while (powerConsumption < 0);
        string usageType;
        do
        {
            Console.Write("Enter your usage type (Residential, Commercial, or Industrial): ");
            usageType = Console.ReadLine()?.ToLower();
            if (string.IsNullOrEmpty(usageType) || (usageType != "residential" && usageType != "commercial" && usageType != "industrial"))
            {
                Console.WriteLine("Invalid usage type. Please enter Residential, Commercial, or Industrial.");
            }
        } while (string.IsNullOrEmpty(usageType) || (usageType != "residential" && usageType != "commercial" && usageType != "industrial"));
        double tariffRate;
        switch (usageType)
        {
            case "residential":
                tariffRate = 12.50;
                break;
            case "commercial":
                tariffRate = 15.75;
                break;
            case "industrial":
                tariffRate = 18.90;
                break;
            default:
                return;
        }

        double monthlyBill = powerConsumption * tariffRate;
        Console.WriteLine($"Your monthly power bill is: KES{monthlyBill:F2} (Tariff Rate: KES{tariffRate:F2}/kWh)");
    }
}
