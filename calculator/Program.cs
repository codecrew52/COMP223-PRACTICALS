using System;
using System.Data;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculator app");
            Console.WriteLine("Enter an expression or type 'exit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting calculator...!");
                break;
            }

            try
            {
                double result = EvaluateExpression(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static double EvaluateExpression(string expression)
    {
        DataTable table = new DataTable();
        table.Columns.Add("expression", typeof(string), expression);

        DataRow row = table.NewRow();
        table.Rows.Add(row);

        return double.Parse((string)row["expression"]);
    }
}
