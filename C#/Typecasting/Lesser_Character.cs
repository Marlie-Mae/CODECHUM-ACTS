using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter character 1: ");
        char char1 = Console.ReadLine()[0];  

        Console.Write("Enter character 2: ");
        char char2 = Console.ReadLine()[0];  

        char lesserChar = char1 < char2 ? char1 : char2;

        Console.WriteLine($"The lesser character is: {lesserChar}");
    }
}
