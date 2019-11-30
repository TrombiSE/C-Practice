using System;

class MainClass {
  class Person{
    int age;
    string name;
    public void SayHi(){
      Console.WriteLine("Hi");
    }
  }
  public static void Main (string[] args) {
    Person p1 = new Person();
    p1.SayHi();
  }
}
