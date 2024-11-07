using System;

class Program {
    static void Main() {
        Console.Write("Enter side: ");
        double side = Convert.ToDouble(Console.ReadLine());

        double area = (1.0 / 4.0) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2);

        Console.WriteLine($"Area of Pentagon: {area:F2}");
    }
}
