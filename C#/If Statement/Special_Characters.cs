using System;
class Program {
    static void Main() {
        Console.Write("Enter character: ");
        char a = Convert.ToChar(Console.ReadLine());
        
        if (!char.IsLetterOrDigit(a)) {
            Console.WriteLine("Character is a special character.");
        }
    }
}
