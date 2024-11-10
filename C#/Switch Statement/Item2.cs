using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the day of the week: ");
        if (int.TryParse(Console.ReadLine(), out int dayNum))
        {
            string dayName;
            switch (dayNum)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    return;
            }

            Console.WriteLine(dayName);
        }
    }
}