namespace Mindbox.Geometry;

/// <summary>
/// Набор фабричных методов создания конкретных фигур
/// </summary>
public static class ShapeFactory
{
    public static IShape CreateCircle(double radius) 
        => new Circle(radius);

    public static IShape CreateTriangle(double a, double b, double c) 
        => new Triangle(a, b, c);
}