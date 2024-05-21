namespace GSC;

public interface IShapeCalculator
{
    public double CalculateAreaOfSquare(double length);
    public double CalculateAreaOfRectangle(double length, double width);
    public double CalculateAreaOfCircle(double radius);
    public double CalculatePerimeterOfSquare(double length);
    public double CalculatePerimeterOfRectangle(double length, double width);
    public double CalculatePerimeterOfCircle(double radius);
}