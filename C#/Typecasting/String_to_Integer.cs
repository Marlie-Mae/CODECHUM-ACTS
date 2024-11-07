using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine($"String converted to integer: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer string.");
        }
    }
}
