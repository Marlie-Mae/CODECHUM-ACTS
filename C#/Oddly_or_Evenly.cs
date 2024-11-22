using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 4 == 0)
        {
            Console.WriteLine("Evenly divisible by 4");
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Oddly divisible by 3");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }
}
