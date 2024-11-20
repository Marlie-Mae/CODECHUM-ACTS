using System;
class Program {
    static void Main(string[] args){
        Console.Write("Enter your birth year: ");
        int birthyear = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the current year: ");
        int currentyear = int.Parse(Console.ReadLine());
        
        int age = currentyear- birthyear;
        
        if (Math.Sqrt(age) % 1 == 0) {
            Console.WriteLine("Your age is a perfect square.");
        } else {
            Console.WriteLine("Your age is not a perfect square.");
        }
    }
}
