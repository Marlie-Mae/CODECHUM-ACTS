using System;

class Program {
    static void Main() {
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int maxNumber = Math.Max(firstNumber, secondNumber);

        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}
