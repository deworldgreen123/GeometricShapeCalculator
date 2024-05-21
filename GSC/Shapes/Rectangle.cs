namespace GSC.Shapes;

internal sealed class Rectangle : IShape
{
    public double Perimeter(params double[] sides)
    {
        CheckParamsOnException(sides);
        return sides[0] * 2 + sides[1] * 2;
    }

    public double Area(params double[] sides)
    {
        CheckParamsOnException(sides);
        return sides[0] * sides[1];
    }

    private static void CheckParamsOnException(params double[] sides)
    {
        if (sides.Length < 2) throw new InvalidOperationException( "ERROR: params.Length < 2 in Rectangle");
        if (sides[0] <= 0 || sides[1] <= 0)  throw new ArgumentOutOfRangeException(nameof(sides), "ERROR: sides <= 0");
    }
}