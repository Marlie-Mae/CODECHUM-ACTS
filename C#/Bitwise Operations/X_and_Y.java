using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int Y = int.Parse(Console.ReadLine());

        int result = X & Y;

        Console.WriteLine($"{X} AND {Y} = {result}");
    }
}
