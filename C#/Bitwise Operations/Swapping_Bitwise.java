using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");

        num1 = num1 ^ num2; 
        num2 = num1 ^ num2; 
        num1 = num1 ^ num2; 

        Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");
    }
}
