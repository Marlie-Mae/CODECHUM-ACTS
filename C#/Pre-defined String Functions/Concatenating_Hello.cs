using System;
namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            string concantenatedString = inputString + "Hello";
            Console.WriteLine("Concatenated string: " + concantenatedString);
        }
    }
}
