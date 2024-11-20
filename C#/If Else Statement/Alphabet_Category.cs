using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter a character: ");
        char character = char.ToLower(Console.ReadLine()[0]);
        
        string vowels = "aeiou";
        
        if (vowels.Contains(character)) {
            Console.WriteLine("The character is a vowel.");
        } else {
            Console.WriteLine("The character is a consonant.");
        }
    }
}
