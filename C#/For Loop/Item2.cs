using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter the value of x: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Enter the value of y: ");
    int y = int.Parse(Console.ReadLine());

    for (int i = x; i <= y; i++) {
      if (i % 5 == 0) {
        Console.WriteLine(i + " Divisible by 5 spotted!");
      } else {
        Console.WriteLine(i);
      }
    }
  }
}