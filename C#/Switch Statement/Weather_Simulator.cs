using System;
class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the weather condition: ");
        string weather = Console.ReadLine();
        
        char firstLetter = weather[0];
        
        switch(firstLetter) {
            case 'S':
                if (weather == "Sunny") {
                    Console.WriteLine("Suggestion: Enjoy the sunshine");
                } else {
                    Console.WriteLine("Invallid weather condition.");
                } break;
            case 'C':
                if (weather == "Cloudy") {
                    Console.WriteLine("Suggestion: Stay indoors");
                } else {
                    Console.WriteLine("Invallid weather condition.");
                } break;
            case 'R':
                if (weather == "Rainy") {
                    Console.WriteLine("Suggestion: Bring an umbrella");
                } else {
                    Console.WriteLine("Invallid weather condition.");
                } break;
            case 'W':
                if (weather == "Windy") {
                    Console.WriteLine("Suggestion: Fly a kite");
                } else {
                    Console.WriteLine("Invallid weather condition.");
                } break;
            default:
                Console.WriteLine("Invalid weather condition.");
                break;
        }
    }
}
