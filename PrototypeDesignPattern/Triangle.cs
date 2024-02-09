using System;
    public class Triangle : IShapePrototype
    {

        private int a;
        private int b;
        private int c;

        public Triangle(int _a, int _b, int _c)
        {
            this.a = _a;
            this.b = _b;
            this.c = _c;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a traingle with 3 sides: " + a + " " + b + " " + c);
        }

        IShapePrototype IShapePrototype.Clone()
        {
            return new Triangle(a, b, c);
        }
    }

