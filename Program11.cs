using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && input.Length == 1)
        {
            char character = input[0];
            Console.WriteLine($"The ASCII value of '{character}' is {(int)character}");
        }
        else
        {
            Console.WriteLine("Please enter only a single character.");
        }
    }
}
