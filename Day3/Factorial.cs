using System;

class MainClass {
  static int Fact(int num){
    if (num == 1){
      return 1;
    }
    return num * Fact(num-1);
  }
  public static void Main (string[] args) {
    Console.WriteLine(Fact(10));
  }
}
