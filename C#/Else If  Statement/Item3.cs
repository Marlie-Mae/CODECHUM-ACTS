using System;

class Program
{
    static void Main(string[] args)
      {
        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int sum = firstNumber + secondNumber;

        if (sum > 0)
         {
            Console.WriteLine("Positive");
        }
        else if (sum < 0)
        {
            Console.WriteLine("Negative");
        }
       else
        {
        Console.WriteLine("Zero");
        }

        Console.ReadKey();
    }
}