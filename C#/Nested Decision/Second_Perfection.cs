using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            int sqrt = (int)Math.Sqrt(num);
            int cbrt = (int)Math.Cbrt(num);

            if (sqrt * sqrt == num && cbrt * cbrt * cbrt == num)
            {
                Console.WriteLine("Perfect in every way");
            }
            else if (cbrt * cbrt * cbrt == num)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Perfect in even cubes");
                }
                else
                {
                    Console.WriteLine("Perfect in an odd way");
                }
            }
            else
            {
                Console.WriteLine("Nothing special");
            }
        }
    }
}
