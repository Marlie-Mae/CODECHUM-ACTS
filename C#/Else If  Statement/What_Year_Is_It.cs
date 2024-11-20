using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        
        if (year % 100 == 0) {
            if (year % 400 ==0){
                Console.WriteLine("It's a leap century year.");
            } else {
                Console.WriteLine("It's a century year.");
            }
        } else if (year % 4 == 0) {
            Console.WriteLine("It's a leap year.");
        } else {
            Console.WriteLine("It's neither a leap year nor a century year.");
        }
    }
}
