using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter a negative number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Absolute value: {0}", Math.Abs(num));
    }
}
