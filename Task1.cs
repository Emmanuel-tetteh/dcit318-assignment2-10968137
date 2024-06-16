using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some Generic Sound");

    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("meow meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();

        myAnimal.MakeSound();

        Dog myDog = new Dog();

        myDog.MakeSound();

        Cat myCat = new Cat();

        myCat.MakeSound();
    }
}