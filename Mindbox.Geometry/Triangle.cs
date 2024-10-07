namespace Mindbox.Geometry;

/// <summary>
/// Треугольник
/// </summary>
/// <param name="a">Сторона 1</param>
/// <param name="b">Сторона 2</param>
/// <param name="c">Сторона 3</param>
public sealed class Triangle(double a, double b, double c) : IShape
{
    /// <inheritdoc/>
    /// <remarks>По формуле Герона</remarks>
    public double CalculateSquare()
    {
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    /// <summary>
    /// Проверить факт прямоугольности треугольника
    /// </summary>
    public bool IsRightTriangle()
    {
        var maxLengthSide = Math.Max(Math.Max(a, b), c);
        var minLengthSide = Math.Min(Math.Min(a, b), c);
        var midLengthSide = a + b + c - maxLengthSide - minLengthSide;
        return minLengthSide * minLengthSide + midLengthSide * midLengthSide == maxLengthSide * maxLengthSide;
    }
}