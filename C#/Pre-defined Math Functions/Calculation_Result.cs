using System;

class Program 
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double absoluteDifference = Math.Abs(firstNumber - secondNumber);
        double res = Math.Sqrt(Math.Pow(absoluteDifference, 3));

        Console.WriteLine($"Result: {res:F2}");
    }
}
