using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        
        int num = Convert.ToInt32(Console.ReadLine());
        
        num += 1;
        
        Console.WriteLine("The updated number is: " + num);
    }
}
