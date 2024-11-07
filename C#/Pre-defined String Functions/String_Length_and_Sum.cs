using System;
public class Program{
    public static void Main(string[] args) {
        Console.Write("Enter the first string: ");
        string firstString = Console.ReadLine();
        
        Console.Write("Enter the second string: ");
        string secondString = Console.ReadLine();
        
        int firstStringLength = firstString.Length;
        int secondStringLength = secondString.Length;
        
        int sum= firstStringLength + secondStringLength;
        
        Console.WriteLine("Length of the first string: " + firstStringLength);
        Console.WriteLine("Length of the second string: " + secondStringLength);
        Console.WriteLine("Sum: " + sum);
    }
}
