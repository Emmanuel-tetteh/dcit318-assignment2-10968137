using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Task3
{
    static void Main()
    {

        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        // Call the Move method on each instance
        car.Move();
        bicycle.Move();
    }
}
