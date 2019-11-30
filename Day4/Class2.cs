using System;

class MainClass {
  class Dog{
    public string name;
    public int age;
    }
  public static void Main (string[] args) {
    Dog bob1 = new Dog();
    bob1.name = "Bobby";
    bob1.age = 5;
    Console.WriteLine(bob1.name);
    Console.WriteLine(bob1.age);
  }
}
