using System;

class Circle : IShapePrototype
{
    private int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public Circle(Circle c)
    {
        _radius = c._radius;
    }

    public IShapePrototype Clone()
    {
        return new Circle(this); // Copy constructor
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {_radius}");
    }
}
