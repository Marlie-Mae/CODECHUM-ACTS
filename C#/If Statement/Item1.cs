using System;

class Item1
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(age);

        if (age >= 18)
        {
            Console.WriteLine("adult");
        }
    }
}
