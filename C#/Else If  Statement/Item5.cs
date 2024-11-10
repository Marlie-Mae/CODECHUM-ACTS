using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int x = int.Parse(Console.ReadLine());

        if (x % 7 == 0 && x % 3 != 0)
        {
            Console.Write("Code");
        }
        else if (x % 3 == 0 && x % 7 != 0)
        {
            Console.Write("Chum");
        }
        else if (x % 7 == 0 && x % 3 == 0)
        {
            Console.Write("CodeChum");
        }
        else
        {
            Console.WriteLine("None of the above");
        }
    }
}