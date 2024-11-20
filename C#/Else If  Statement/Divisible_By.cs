using System;
class Program {
    public static void Main(string[] args) {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        
        if (num % 4 == 0) {
            Console.WriteLine("The number is divisible by 4.");
        } else if (num % 3 == 0) {
            Console.WriteLine("The number is divisible by 3.");
        } else if (num % 2 == 0) {
            Console.WriteLine("The number is divisible by 2.");
        } else {
            Console.WriteLine("The number is not divisible by 2, 3, or 4.");
        }
    }
}
