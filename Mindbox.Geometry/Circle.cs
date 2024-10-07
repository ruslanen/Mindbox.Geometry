namespace Mindbox.Geometry;

/// <summary>
/// Круг
/// </summary>
/// <param name="radius">Радиус</param>
public sealed class Circle(double radius) : IShape
{
    public double CalculateSquare()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}