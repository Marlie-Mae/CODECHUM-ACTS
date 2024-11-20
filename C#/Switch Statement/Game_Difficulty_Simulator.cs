using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter the difficulty level (Easy, Medium, Hard): ");
        string difficulty = Console.ReadLine().ToLower();
        
        switch (difficulty) {
            case "easy":
                Console.WriteLine("Message: You selected Easy difficulty. Enjoy the game!");
                break;
            case "medium":
                Console.WriteLine("Message: You selected Medium difficulty. Get ready for a challenge!");
                break;
            case "hard":
                Console.WriteLine("Message: You selected Hard difficulty. Brace yourself for a tough gameplay!");
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                break;
        }
    }
}
