using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your income: $");
            float income = float.Parse(Console.ReadLine());

            if (age >= 60)
            {
                if (income < 10000)
                {
                    Console.WriteLine("Eligible for senior citizen discount");
                }
                else
                {
                    Console.WriteLine("Not eligible for senior citizen discount");
                }
            }
            else
            {
                Console.WriteLine("Not eligible for senior citizen discount");
            }
        }
    }
}
