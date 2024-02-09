using System;

class Rectangle : IShapePrototype
{
    private int _width;
    private int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public IShapePrototype Clone()
    {
        return new Rectangle(_width, _height); // Copy constructor
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {_width} and height {_height}");
    }
}
