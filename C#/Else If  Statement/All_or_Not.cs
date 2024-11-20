using System;
class Program{
    static void Main(string[] args) {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());
        
        if (num1 > 0 && num2 > 0 && num3  > 0) {
            Console.WriteLine("All numbers are positive.");
        } else if (num1 < 0 && num2 < 0 && num3 < 0) {
            Console.WriteLine("All numbers are negative.");
        } else if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 ==0) {
            Console.WriteLine("All numbers are even.");
        } else if (num1 % 2 !=0 && num2 % 2!= 0 && num3 % 2 != 0) {
            Console.WriteLine("All numbers are odd.");
        } else {
            Console.WriteLine("Numbers are different.");
        }
    }
}
