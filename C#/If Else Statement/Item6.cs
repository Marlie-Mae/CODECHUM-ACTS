using System;

class Item6
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Enter z: ");
        double z = double.Parse(Console.ReadLine());

        if ((z >= Math.Min(x, y)) && (z <= Math.Max(x, y)))
        {
            Console.WriteLine($"{z} is within {x} and {y}");
        }
        else
        {
            Console.WriteLine($"{z} is outside {x} and {y}");
        }
    }
}