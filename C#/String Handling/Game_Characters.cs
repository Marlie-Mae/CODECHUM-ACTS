using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the name of your first character: ");
        string character1 = Console.ReadLine();

        Console.Write("Enter the name of your second character: ");
        string character2 = Console.ReadLine();

        Console.Write("Enter the name of your third character: ");
        string character3 = Console.ReadLine();

        Console.Write("Enter the name of your fourth character: ");
        string character4 = Console.ReadLine();

        Console.WriteLine($"My most played characters in the game are {character1}, {character2}, {character3}, and {character4}.");
    }
}
