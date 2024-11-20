using System;

class Program 
{
    static void Main()
    {
        Console.Write("Enter the Quadrilateral type (S for Square, R for Rectangle, P for Parallelogram, T for Trapezoid): ");
        char type = char.ToUpper(Console.ReadLine()[0]);

        switch (type)
        {
            case 'S':
                Console.WriteLine("Properties of a Square:");
                Console.WriteLine(" - All sides are equal");
                Console.WriteLine(" - All angles are 90 degrees");
                break;

            case 'R':
                Console.WriteLine("Properties of a Rectangle:");
                Console.WriteLine(" - Opposite sides are equal");
                Console.WriteLine(" - All angles are 90 degrees");
                break;

            case 'P':
                Console.WriteLine("Properties of a Parallelogram:");
                Console.WriteLine(" - Opposite sides are parallel");
                Console.WriteLine(" - Opposite angles are equal");
                break;

            case 'T':
                Console.WriteLine("Properties of a Trapezoid:");
                Console.WriteLine(" - One pair of opposite sides are parallel");
                Console.WriteLine(" - Adjacent angles are supplementary");
                break;

            default:
                Console.WriteLine("Invalid Quadrilateral type.");
                break;
        }
    }
}
