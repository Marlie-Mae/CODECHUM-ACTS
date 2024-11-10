using System;

class Item3
{
    static void Main(string[] args)
    {
        Console.Write("Enter first decimal number: ");
        decimal num1 = decimal.Parse(Console.ReadLine());

        Console.Write("Enter second decimal number: ");
        decimal num2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"{num1:F2} {num2:F2}");

        if (num1 > num2)
        {
            Console.WriteLine("The first one is greater than the second one");
        }
    }
}