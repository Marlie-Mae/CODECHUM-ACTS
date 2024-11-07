using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string containing a float: ");
        string input = Console.ReadLine();

        if (float.TryParse(input, out float floatNumber))
        {
            Console.WriteLine($"Floating-point number: {floatNumber:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid float string.");
        }
    }
}
