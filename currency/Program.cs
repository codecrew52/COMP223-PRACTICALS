using System;
using System.Collections.Generic;

namespace CurrencyConverter  
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Currency converter");
      Console.WriteLine("Supported currencies:");
      Console.WriteLine("1. USD - US Dollar"); 
      Console.WriteLine("2. EUR - Euro");
      Console.WriteLine("3. JPY - Japanese Yen");
      Console.WriteLine("4. KES - Kenyan Shilling");
      
      Console.Write("Enter source currency code: ");
      string sourceCurrency = Console.ReadLine();
      
      Console.Write("Enter target currency code: ");
      string targetCurrency = Console.ReadLine();
      
      Console.Write("Enter amount to convert: ");
      double amount;
      if (!double.TryParse(Console.ReadLine(), out amount))
      {
        Console.WriteLine("Invalid amount entered. Please try again.");
        return;
      }

      Dictionary<string, double> rates = new Dictionary<string, double>()
      {
        {"USD", 1},
        {"EUR", 0.92},
        {"JPY", 136.23},
        {"KES", 103.25}
      };
      
      if (!rates.ContainsKey(sourceCurrency) || !rates.ContainsKey(targetCurrency))
      {
        Console.WriteLine("Unsupported currency code entered. Please try again.");
        return;
      }

      double rate = rates[targetCurrency] / rates[sourceCurrency];
      double result = amount * rate;

      Console.WriteLine($"{amount} {sourceCurrency} is {result} {targetCurrency}"); 
      
      Console.WriteLine("Thank you for using the Currency Converter. Thanks!");
    }
  }
}