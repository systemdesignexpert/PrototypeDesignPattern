class GraphicsApp
{
    private static void Main(string[] args)
    {
        IShapePrototype originalCircle = new Circle(10);
        IShapePrototype originalRectangle = new Rectangle(20, 15);
        IShapePrototype originalTriangle = new Triangle(3, 4, 5);

        // Cloning prototypes to create new instances
        Circle cloned = new Circle(10);
        
        IShapePrototype clonedCircle = originalCircle.Clone();
        IShapePrototype clonedRectangle = originalRectangle.Clone();
        originalTriangle.Draw();
        IShapePrototype clonedTriangle = originalTriangle.Clone();



        originalCircle.Draw(); // Original circle
        clonedCircle.Draw();   // Cloned circle
        clonedTriangle.Draw();

        originalRectangle.Draw(); // Original rectangle
        clonedRectangle.Draw();   // Cloned rectangle
    }
}
