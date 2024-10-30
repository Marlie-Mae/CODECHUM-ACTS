using System;
class Program {
    static void Main() {
        string name = "John Doe";
        int id = 12345;
        double cash = 99.99;
        
        Console.WriteLine("Invoice for Customer: {0}", name);
        Console.WriteLine("Order ID: {0}", id);
        Console.WriteLine("Total Amount: ${0:F2}", cash);
    }
}
