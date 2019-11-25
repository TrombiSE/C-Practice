using System;

class MainClass {
  public static void Main (string[] args) {
    int x = 60;
    while (x<70){
      Console.WriteLine(x);
      x++;
      string y = (x<65) ? "Yes" : "NO";
      Console.WriteLine(y);
    }
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
    }
    int j = 0;
    do{
      Console.WriteLine(j);
      j++;
    }while (j<10);
  }
}
