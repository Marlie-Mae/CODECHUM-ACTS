using System;

class MainClass
{
    static void Main()
    {
        // Hey there, start typing your C# code here...
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
    }
}
