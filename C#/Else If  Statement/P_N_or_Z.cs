using System;
class Program {
    public static void Main(string[] args) {
        int positivecount = 0;
        int negativecount = 0;
        int zerocount = 0;
        
        for (int i = 1; i <= 5; i++) {
            string ordinal = i == 1 ? "first" : (i == 2? "second" : (i == 3 ? "third" : (i == 4 ? "fourth" : "fifth")));
            Console.Write("Enter " + ordinal + " integer: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number > 0) {
                positivecount++;
            } else if (number < 0) {
                negativecount++;
            } else {
                zerocount++;
            }
        }
        
        Console.WriteLine("Positive count: " + positivecount);
        Console.WriteLine("Negative count: " + negativecount);
        Console.WriteLine("Zero count: " + zerocount);
    }
}
