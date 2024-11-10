using System;

class Item5
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        string chars = Console.ReadLine();

        if (chars.ToLower() == "y")
        {
            Console.WriteLine("Here's your ice cream");
        }
        else
        {
            Console.WriteLine("Okay, maybe some other time");
        }
    }
}