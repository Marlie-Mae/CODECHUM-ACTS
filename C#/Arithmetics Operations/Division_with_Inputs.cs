using System;

class MainClass
{
    static void Main()
    {
        // Hey there, start typing your C# code here...
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y != 0)
        {
            int quotient = x / y;
            Console.WriteLine($"Quotient: {quotient}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed, please input another number.");
        }
    }
}
