using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Post Date: ");
        string postDate = Console.ReadLine();
        
        Console.Write("Enter Post Time: ");
        string postTime = Console.ReadLine();
        
        Console.Write("Enter Post Reach: ");
        decimal postReach = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Post Engagement: ");
        decimal postEngagement = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Post Duration: ");
        decimal postDuration = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Post Category: ");
        string postCategory = Console.ReadLine();

        Console.WriteLine("\nPost Scheduled:");
        Console.WriteLine($"Date: {postDate}");
        Console.WriteLine($"Time: {postTime}");
        Console.WriteLine($"Reach: {postReach:F2}");
        Console.WriteLine($"Engagement: {postEngagement:F2}");
        Console.WriteLine($"Duration: {postDuration:F2}");
        Console.WriteLine($"Category: {postCategory}");
    }
}
