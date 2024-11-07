using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string first = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string second = Console.ReadLine();

        Console.WriteLine($"{first} {second} {first}");
    }
}
