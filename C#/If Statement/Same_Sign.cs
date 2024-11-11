using System;
class Program {
    static void Main() {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        if ((num1 >0 && num2 >0) || (num1 <0 && num2 <0)) {
            Console.WriteLine("Numbers have the same sign.");
        }
    }
}
