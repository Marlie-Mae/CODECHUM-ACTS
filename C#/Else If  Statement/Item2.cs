using System;

class Program
{
    static void Main()
    {
        char gender;

        Console.Write("Enter a character: ");
        gender = Console.ReadLine()[0];

        if (gender == 'M' || gender == 'm')
        {
            Console.WriteLine("Male");
        }
        else if (gender == 'F' || gender == 'f')
        {
            Console.WriteLine("Female");
        }
        else
        {
            Console.WriteLine("Prefer not to say");
        }
    }
}