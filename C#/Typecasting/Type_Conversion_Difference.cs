using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integerInput = int.Parse(Console.ReadLine());

        Console.Write("Enter a float: ");
        float floatInput = float.Parse(Console.ReadLine());

        float difference = integerInput - floatInput;

        Console.WriteLine($"The difference is: {difference:F2}");
    }
}
