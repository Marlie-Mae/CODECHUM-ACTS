using System;

class Item6
{
    static void Main(string[] args)
    {
        Console.Write("Enter first decimal number: ");
        decimal num1 = decimal.Parse(Console.ReadLine());

        Console.Write("Enter second decimal number: ");
        decimal num2 = decimal.Parse(Console.ReadLine());

        Console.Write("Enter third decimal number: ");
        decimal num3 = decimal.Parse(Console.ReadLine());

        Console.Write($"{num1:F2} {num2:F2}");

        if (num3 > num1 + num2)
        {
            Console.Write($" {num3:F2}");
        }

        Console.WriteLine();
    }
}