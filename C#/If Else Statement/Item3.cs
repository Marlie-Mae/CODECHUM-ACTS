using System;

class Item3 
{
	static void Main(string[] args)
	{
		int total = 50;
 
        // Hey there, start typing your C# code here...
        
        Console.Write("Enter first positive integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second positive integer: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            total += num1;
        }
        else
        {
            total -= num1;
        }

        if (num2 % 2 == 0)
        {
            total += num2;
        }
        else
        {
            total -= num2;
        }

        Console.WriteLine(total);

    }
}