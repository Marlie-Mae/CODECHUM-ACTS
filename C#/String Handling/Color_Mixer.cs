using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter color 1: ");
        string color1 = Console.ReadLine();

        Console.Write("Enter color 2: ");
        string color2 = Console.ReadLine();

        Console.Write("Enter color 3: ");
        string color3 = Console.ReadLine();

        Console.WriteLine($"Mixing {color1}, {color2}, and {color3} creates a new color!");
    }
}
