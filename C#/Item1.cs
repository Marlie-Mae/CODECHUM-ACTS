using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter age category: ");
        string input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input))
        {
            char category = char.ToUpper(input[0]);

            decimal monthlyAllowance = 0.00m;
            string categoryString = "";

            switch (category)
            {
                case 'B':
                    categoryString = "Baby";
                    break;
                case 'T':
                    categoryString = "Teenager";
                    monthlyAllowance = 2000.00m;
                    break;
                case 'A':
                    categoryString = "Adult";
                    monthlyAllowance = 15000.00m;
                    break;
                case 'S':
                    categoryString = "Senior Citizen";
                    monthlyAllowance = 4000.00m;
                    break;
            }

            if (!string.IsNullOrEmpty(categoryString))
                Console.WriteLine($"{categoryString} = P{monthlyAllowance:F2}");
        }
    }
}