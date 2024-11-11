using System;
class Program {
    static void Main() {
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        if ((year % 4 == 0 && year% 100 !=0) || (year % 400 ==0)) {
            Console.WriteLine("Year is a leap year.");
        }
    }
}
