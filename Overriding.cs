using System;

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.Speak();
        cat.Speak();
    }
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
        Console.WriteLine();
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof Woof");
        Console.WriteLine();
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow Meow");
        Console.WriteLine();
    }
}
