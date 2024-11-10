using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter decimal value 1: ");
        decimal year1 = decimal.Parse(Console.ReadLine());
        Console.Write("Enter decimal value 2: ");
        decimal year2 = decimal.Parse(Console.ReadLine());
        Console.Write("Enter decimal value 3: ");
        decimal year3 = decimal.Parse(Console.ReadLine());

        decimal totalEarnings = year1 + year2 + year3;

        if (totalEarnings < 200000)
        {
            Console.WriteLine("average");
        }
        else if (totalEarnings >= 200000 && totalEarnings < 400000)
        {
            Console.WriteLine("rich");
        }
        else if (totalEarnings >= 400000 && totalEarnings < 600000)
        {
            Console.WriteLine("super rich");
        }
        else
        {
            Console.WriteLine("crazy rich");
        }
    }
}