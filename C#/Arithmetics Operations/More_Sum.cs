using System;

class MainClass
{
    static void Main()
    {
        // Hey there,  start typing your C# code here...
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter z: ");
        int z = Convert.ToInt32(Console.ReadLine());

        int sum = x + y + z;
        Console.WriteLine($"Sum: {sum}");
    }
}
