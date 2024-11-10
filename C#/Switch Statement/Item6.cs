using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade level: ");
        if (int.TryParse(Console.ReadLine(), out int gradeLevel))
        {
            switch (gradeLevel)
            {
                case 1:
                    Console.WriteLine("Freshies");
                    break;
                case 2:
                    Console.WriteLine("Sophomores");
                    break;
                case 3:
                    Console.WriteLine("Juniors");
                    break;
                case 4:
                    Console.WriteLine("Seniors");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}