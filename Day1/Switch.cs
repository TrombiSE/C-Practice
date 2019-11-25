using System;

class MainClass {
  public static void Main (string[] args) {
    int i = 0;
    for (;i<=10;i++){
      Console.WriteLine(i);
    }
    switch (i) {
      case 5:
        Console.WriteLine("five");
        break;
      case 10:
        Console.WriteLine("ten");
        break;
      case 11:
        Console.WriteLine("equal");
        break;
      default:
        Console.WriteLine("Something Wrong");
        break;
    }
  }
}
