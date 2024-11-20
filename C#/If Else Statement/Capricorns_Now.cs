using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter your birth month: ");
        int month = int.Parse(Console.ReadLine());
        
        Console.Write("Enter your birth day: ");
        int day = int.Parse(Console.ReadLine());
        
        if ((month == 12 && day >= 22) || (month == 1 && day <=19)) {
            Console.WriteLine("Your zodiac sign is Capricorn.");
        } else {
            Console.WriteLine("Your zodiac sign is not Capricorn.");
        }
    }
}
