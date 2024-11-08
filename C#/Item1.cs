using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("The values that are divisible by 3 from 1 to " + n + " are:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}