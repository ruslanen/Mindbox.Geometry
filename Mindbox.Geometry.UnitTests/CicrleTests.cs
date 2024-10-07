namespace Mindbox.Geometry.UnitTests;

public class CircleTests
{
    [Fact]
    public void CircleSquareTest()
    {
        var circle = new Circle(5);
        var square = circle.CalculateSquare();
        Assert.Equal(78.54, square, 2);
    }
}