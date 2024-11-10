using System;

class Item2
{
    static void Main(string[] args)
    {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"{a} {b}");

        if (a == b)
        {
            Console.WriteLine("equal");
        }
    }
}