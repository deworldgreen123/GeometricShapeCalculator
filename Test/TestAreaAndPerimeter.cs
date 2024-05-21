using GSC;

namespace Test;

public class TestAreaAndPerimeter
{
    [Fact]
    public void TestAreaOfCircle()
    {
        var c = new ShapeCalculator();
        var res = c.CalculateAreaOfCircle(3);
        Assert.Equal(3 * 3 * double.Pi, res);
    }
    [Fact]
    public void TestAreaOfRectangle()
    {
        var c = new ShapeCalculator();
        var res = c.CalculateAreaOfRectangle(3, 5);
        Assert.Equal(3 * 5, res);
    }
    [Fact]
    public void TestAreaOfSquare()
    {
        var c = new ShapeCalculator();
        var res = c.CalculateAreaOfSquare(3);
        Assert.Equal(3 * 3, res);
    }
    [Fact]
    public void TestPerimeterOfCircle()
    {
        var c = new ShapeCalculator();
        var res = c.CalculatePerimeterOfCircle(3);
        Assert.Equal(2 * 3 * double.Pi, res);
    }
    [Fact]
    public void TestPerimeterOfRectangle()
    {
        var c = new ShapeCalculator();
        var res = c.CalculatePerimeterOfRectangle(3, 5);
        Assert.Equal(2*3 + 2*5, res);
    }
    [Fact]
    public void TestPerimeterOfSquare()
    {
        var c = new ShapeCalculator();
        var res = c.CalculatePerimeterOfSquare(3);
        Assert.Equal(4*3, res);
    }
    
    [Fact]
    public void TestAreaOfCircleException()
    {
        var c = new ShapeCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => c.CalculateAreaOfCircle(-3));
    }
    [Fact]
    public void TestAreaOfRectangleException()
    {
        var c = new ShapeCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => c.CalculateAreaOfRectangle(-3, 3));
    }
    [Fact]
    public void TestAreaOfSquareException()
    {
        var c = new ShapeCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => c.CalculateAreaOfSquare(-3));
    }
    [Fact]
    public void TestPerimeterOfCircleException()
    {
        var c = new ShapeCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => c.CalculatePerimeterOfCircle(-3));
    }
    [Fact]
    public void TestPerimeterOfRectangleException()
    {
        var c = new ShapeCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => c.CalculatePerimeterOfRectangle(-3, 3));
    }
    [Fact]
    public void TestPerimeterOfSquareException()
    {
        var c = new ShapeCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => c.CalculatePerimeterOfSquare(-3));
    }
}