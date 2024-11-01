using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the price: ");
        float price = float.Parse(Console.ReadLine());
        
        price *= 1.1f;
        
        Console.WriteLine("The new price is: {0:F2}", price);
    }
}
