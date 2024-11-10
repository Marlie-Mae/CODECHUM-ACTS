using System;

class Item1
{
    static void Main(string[] args)
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("adult");
        }
        else
        {
            Console.WriteLine("minor");
        }
    }
}