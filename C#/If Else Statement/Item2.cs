using System;

class Item2
{
    static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int sum = a + b;

        if (sum > c)
        {
            Console.WriteLine($"{a} + {b} > {c} = yes");
        }
        else
        {

            Console.WriteLine($"{a} + {b} > {c} = no");
        }
    }
}