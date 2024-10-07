namespace Mindbox.Geometry;

/// <summary>
/// Контракт для любой геометрической фигуры
/// </summary>
public interface IShape
{
    /// <summary>
    /// Рассчитать площадь фигуры
    /// </summary>
    public double CalculateSquare();
}