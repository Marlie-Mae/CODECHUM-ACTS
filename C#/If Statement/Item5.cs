using System;

class Item5
{
    static void Main(string[] args)
    {
        Console.Write("Enter a single integer: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(num);

        if (num != 0 && IsEven(num))
        {
            Console.WriteLine("even");
        }
    }

    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
}