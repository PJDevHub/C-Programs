using System;

class Triangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i + 1; j++)
            {
                Console.Write(rows - i + 1);
            }
            Console.WriteLine();
        }
    }
}
