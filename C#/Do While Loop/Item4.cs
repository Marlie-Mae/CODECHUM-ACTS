using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter an integer: ");
    int n = int.Parse(Console.ReadLine());

    int num = 1;
    for (int i = 1; i <= n; i++) {
      Console.Write(num + " ");
      num += i;
    }
    Console.WriteLine();
  }
}