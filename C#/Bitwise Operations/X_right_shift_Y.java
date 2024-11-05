using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter X: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Enter Y: ");
        int Y = int.Parse(Console.ReadLine());

        int result = X >> Y;

        Console.WriteLine($"{X} >> {Y} = {result}");
    }
}
