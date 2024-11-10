using System;

class Program
{
    static string CheckNum(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }
        else if (num % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        
        string result = CheckNum(num);
        Console.WriteLine(result);
    }
}