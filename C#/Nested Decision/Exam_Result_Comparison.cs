using System;

namespace Program 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first score: ");
            float score1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second score: ");
            float score2 = float.Parse(Console.ReadLine());

            if (score1 > score2)
            {
                if (score1 > 80)
                {
                    Console.WriteLine("Excellent!");
                }
                else
                {
                    Console.WriteLine("Good job!");
                }
            }
            else
            {
                Console.WriteLine("Keep up the good work!");
            }
        }
    }
}
