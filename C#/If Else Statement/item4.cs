using System;

class Item4
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int currentYear = 2022;

        int age = currentYear - birthYear;

        if (age >= 60)
        {
            Console.WriteLine("senior citizen");
        }
        else
        {
            Console.WriteLine("not senior citizen");
        }
    }
}