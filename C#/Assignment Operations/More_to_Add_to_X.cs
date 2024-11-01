using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter z: ");
        int z = Convert.ToInt32(Console.ReadLine());
        
        x += y;
        x += z;
        
        Console.WriteLine("Result: " + x);
    }
}
