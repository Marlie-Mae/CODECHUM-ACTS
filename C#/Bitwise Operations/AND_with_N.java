using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int N = int.Parse(Console.ReadLine());

        int result = N & 25;

        Console.WriteLine($"{N} AND 25 = {result}");
    }
}
