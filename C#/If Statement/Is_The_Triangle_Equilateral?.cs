using System;
class Program {
    static void Main() {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter z: ");
        int z = Convert.ToInt32(Console.ReadLine());
    
        if (x==y && y==z) {
            Console.WriteLine("Triangle is equilateral.");
        }
    }
}
