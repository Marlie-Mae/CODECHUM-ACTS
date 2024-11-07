using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first character: ");
        char firstChar = Console.ReadLine()[0];

        Console.Write("Enter second character: ");
        char secondChar = Console.ReadLine()[0]; 

        int sum = (int)firstChar + (int)secondChar;

        Console.WriteLine($"Sum: {sum}");
    }
}
