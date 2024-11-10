using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, or /): ");
            string operation = Console.ReadLine();

            decimal result;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        result = -999.99m;
                        break;
                    }

                    result = num1 / num2;
                    break;
                default:
                    result = -999.99m;
                    break;
            }

            Console.WriteLine("Result: {0:F2}", result);
        }
    }