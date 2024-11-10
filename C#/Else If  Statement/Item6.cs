using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter integer x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter integer y: ");
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            Console.Write("x is greater than y");
        }
        else if (x < y)
        {
            Console.Write("x is lesser than y");
        }
        else
        {
            Console.Write("x is equal to y");
        }
    }
    }