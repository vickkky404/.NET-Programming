using System;

class Program
{
    static void Main(string[] args)
    {
        String name = "Dotnet";
        int age = 24;
        //Console.WriteLine("Hello, World!");
        NewMethod(name , age);
    }

    public static void NewMethod(string name , int age)
    {
        Console.WriteLine("Hello" + name + "your age: " + age);
    }
}
