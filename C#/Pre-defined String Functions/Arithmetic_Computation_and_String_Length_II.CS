using System;
public class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();
        Console.Write("Enter the third string: ");
        string str3 = Console.ReadLine();
        Console.Write("Enter the fourth string: ");
        string str4 = Console.ReadLine();
        Console.Write("Enter the fifth string: ");
        string str5 = Console.ReadLine();
        
        int len1 = str1.Length;
        int len2 = str2.Length;
        int len3 = str3.Length;
        int len4 = str4.Length;
        int len5 = str5.Length;
        
        Console.WriteLine("Length of the first string: " + len1);
        Console.WriteLine("Length of the second string: " + len2);
        Console.WriteLine("Length of the third string: " + len3);
        Console.WriteLine("Length of the fourth string: " + len4);
        Console.WriteLine("Length of the fifth string: " + len5);
       
       double result = ((len1 + len2) / (len3 - len4));
       Console.WriteLine("Result: " + result);
    }
}
