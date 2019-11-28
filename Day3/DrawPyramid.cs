using System;

class MainClass {
  static void DrawPyramid(int x){
    for(int i = 1; i<=x; i++){
      for (int j = i; j<=x; j++){
        Console.Write("  ");
      }
      for(int l = 1; l <= 2*i-1; l++){
        Console.Write("*"+" ");
      }
      Console.WriteLine();
    }
  }
  public static void Main (string[] args) {
    DrawPyramid(10);
  }
}
