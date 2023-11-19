using System;

class PayeCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the PAYE Tax Calculator!");
        Console.Write("Enter your monthly income (KES): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal income) || income < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive numeric value for income.");
            return;
        }

        Console.Write("Enter your total allowances (KES): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal allowances) || allowances < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive numeric value for allowances.");
            return;
        }

        Console.Write("Enter your total deductions (KES): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal deductions) || deductions < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive numeric value for deductions.");
            return;
        }

        decimal taxableIncome = income - allowances - deductions;
        if (taxableIncome < 0)
            taxableIncome = 0; 

        decimal tax = CalculatePayeTax(taxableIncome);
        Console.WriteLine($"Your PAYE Tax is: {tax} KES");
        Console.WriteLine("Thank you for using the PAYE Tax Calculator!");
    }

    static decimal CalculatePayeTax(decimal taxableIncome)
    {
        if (taxableIncome <= 24000)
            return taxableIncome * 0.10m;
        else if (taxableIncome <= 40000)
            return 2400 + (taxableIncome - 24000) * 0.15m;
        else if (taxableIncome <= 60000)
            return 2400 + 2400 + (taxableIncome - 40000) * 0.20m;
        else if (taxableIncome <= 100000)
            return 2400 + 2400 + 4000 + (taxableIncome - 60000) * 0.25m;
        else if (taxableIncome <= 150000)
            return 2400 + 2400 + 4000 + 10000 + (taxableIncome - 100000) * 0.30m;
        else if (taxableIncome <= 250000)
            return 2400 + 2400 + 4000 + 10000 + 15000 + (taxableIncome - 150000) * 0.35m;
        else
            return 2400 + 2400 + 4000 + 10000 + 15000 + 35000 + (taxableIncome - 250000) * 0.40m;
    }
}
