using System;

class Program 
{
    static void Main()
    {
        Console.Write("Enter the base: ");
        double basenum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double res = Math.Pow(basenum, exponent);

        Console.WriteLine($"Result: {res:F2}");
    }
}
