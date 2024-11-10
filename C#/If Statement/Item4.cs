using System;

class Item4
{
    static void Main(string[] args)
    {
        Console.Write("Enter a single character: ");
        char chars= Console.ReadLine()[0];

        Console.WriteLine(chars);

        if (IsVowel(chars))
        {
            Console.WriteLine("vowel");
        }
    }

    static bool IsVowel(char chars)
    {
        // Convert character to lowercase for comparison
        chars = char.ToLower(chars);

        // Check if the character is a vowel
        return chars == 'a' || chars == 'e' || chars == 'i' || chars == 'o' || chars == 'u';
    }
}