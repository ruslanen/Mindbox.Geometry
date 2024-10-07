namespace Mindbox.Geometry.UnitTests;

public class TriangleTests
{
    [Fact]
    public void TriangleSquareTest()
    {
        var triangle = new Triangle(4, 5, 6);
        var square = triangle.CalculateSquare();
        Assert.Equal(9.92, square, 2);
    }

    [Fact]
    public void RightTriangleTest()
    {
        var triangle1 = new Triangle(3, 4, 5);
        Assert.True(triangle1.IsRightTriangle());
        
        var triangle2 = new Triangle(2, 4, 5);
        Assert.False(triangle2.IsRightTriangle());
    }
}