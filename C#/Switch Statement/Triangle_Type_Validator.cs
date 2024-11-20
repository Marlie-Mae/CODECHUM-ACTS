using System;

class Program 
{
    static void Main()
    {
        Console.Write("Enter the triangle type identifier (E for Equilateral, I for Isosceles, S for Scalene): ");
        char triangleType = char.ToUpper(Console.ReadLine()[0]);

        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        switch (triangleType)
        {
            case 'E':
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The given sides form an Equilateral triangle.");
                }
                else
                {
                    Console.WriteLine("The given sides do not form an Equilateral triangle.");
                }
                break;

            case 'I':
                if ((side1 == side2 && side1 != side3) || (side1 == side3 && side1 != side2) || (side2 == side3 && side2 != side1))
                {
                    Console.WriteLine("The given sides form an Isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("The given sides do not form an Isosceles triangle.");
                }
                break;

            case 'S':
                if (side1 != side2 && side2 != side3 && side1 != side3)
                {
                    Console.WriteLine("The given sides form a Scalene triangle.");
                }
                else
                {
                    Console.WriteLine("The given sides do not form a Scalene triangle.");
                }
                break;

            default:
                Console.WriteLine("Invalid triangle type identifier.");
                break;
        }
    }
}
