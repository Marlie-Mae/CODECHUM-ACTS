using System;

namespace Program 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your genre preference (a for adventure, m for mystery, f for fantasy, s for science fiction): ");
            char genre = char.Parse(Console.ReadLine());

            if (age >= 8 && age <= 12)
            {
                if (genre == 'a')
                {
                    Console.WriteLine("The Adventures of Tom Sawyer");
                }
                else if (genre == 'm')
                {
                    Console.WriteLine("Nancy Drew: The Secret of the Old Clock");
                }
                else
                {
                    Console.WriteLine("No recommendation available");
                }
            }
            else if (age >= 13)
            {
                if (genre == 'f')
                {
                    Console.WriteLine("Harry Potter and the Sorcerer's Stone");
                }
                else if (genre == 's')
                {
                    Console.WriteLine("Ender's Game");
                }
                else
                {
                    Console.WriteLine("No recommendation available");
                }
            }
            else
            {
                Console.WriteLine("No recommendation available");
            }
        }
    }
}
