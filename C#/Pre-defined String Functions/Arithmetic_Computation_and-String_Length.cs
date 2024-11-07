using System;
public class Program {
    public static void Main(string[] args) {
        
        Console.Write("Enter the first string: ");
        string first = Console.ReadLine();
        
        Console.Write("Enter the second string: ");
        string second = Console.ReadLine();
        
        Console.Write("Enter the third string: ");
        string third = Console.ReadLine();
        
        Console.WriteLine($"Length of the first string: {first.Length}");
        Console.WriteLine($"Length of the second string: {second.Length}");
        Console.WriteLine($"Length of the third string: {third.Length}");
        
        int result = (int)(first.Length + second.Length) /third.Length;
        Console.WriteLine($"Result: {result}");
    }
}
