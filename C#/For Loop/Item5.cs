using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter an integer for x: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Enter an integer for y: ");
    int y = int.Parse(Console.ReadLine());

    Console.Write("Enter an integer for z: ");
    int z = int.Parse(Console.ReadLine());

    for (int i = x; i <= y; i += z) {
      Console.Write(i);
      if (i + z <= y) {
        Console.Write(", ");
      }
    }
    Console.WriteLine();
  }
}