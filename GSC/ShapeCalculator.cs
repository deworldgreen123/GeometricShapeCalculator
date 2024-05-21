using GSC.Enum;

namespace GSC;

public class ShapeCalculator : IShapeCalculator
{
    public double CalculateAreaOfSquare(double length)
    {
        var shape = ShapeFabric.GetShape(ShapeType.SQUARE);
        return shape.Area(length);
    }

    public double CalculateAreaOfRectangle(double length, double width)
    {
        var shape = ShapeFabric.GetShape(ShapeType.RECTANGLE);
        return shape.Area(length, width);
    }

    public double CalculateAreaOfCircle(double radius)
    {
        var shape = ShapeFabric.GetShape(ShapeType.CIRCLE);
        return shape.Area(radius);
    }

    public double CalculatePerimeterOfSquare(double length)
    {
        var shape = ShapeFabric.GetShape(ShapeType.SQUARE);
        return shape.Perimeter(length);
    }

    public double CalculatePerimeterOfRectangle(double length, double width)
    {
        var shape = ShapeFabric.GetShape(ShapeType.RECTANGLE);
        return shape.Perimeter(length, width);
    }

    public double CalculatePerimeterOfCircle(double radius)
    {
        var shape = ShapeFabric.GetShape(ShapeType.CIRCLE);
        return shape.Perimeter(radius);
    }
}