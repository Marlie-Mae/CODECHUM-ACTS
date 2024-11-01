using System;

class MainClass
{
    static void Main()
    {
        Console.Write("Enter kilometers per hour: ");
        float kmph = float.Parse(Console.ReadLine());

        Console.Write("Enter number of hours traveled: ");
        int hour = int.Parse(Console.ReadLine());

        float distanceKm = kmph * hour;

        float distanceMiles = distanceKm * 0.621371f;

        Console.WriteLine("Distance in miles: {0:F3}", distanceMiles);
    }
}
