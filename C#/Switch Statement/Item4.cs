using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string gradeInput = Console.ReadLine().ToUpper();

        switch (gradeInput)
        {
            case "A":
                Console.WriteLine("Good Job");
                break;
            case "B":
                Console.WriteLine("Good Job");
                break;
            case "C":
                Console.WriteLine("You did okay");
                break;
            case "D":
                Console.WriteLine("You need to study harder");
                break;
            case "F":
                Console.WriteLine("You need to study harder");
                break;
            default:
                Console.WriteLine("Stop lying and tell me your actual grade");
                break;
        }
    }
}