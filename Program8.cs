using System;

class PowerCalculator
{
    static void Main()
    {
        Console.Write("Enter the base number: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        double result;

        if (exponent < 0)
        {
            result = 1 / Math.Pow(baseNumber, -exponent); 
        }
        else
        {
            result = Math.Pow(baseNumber, exponent);
        }
        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
    }
}
