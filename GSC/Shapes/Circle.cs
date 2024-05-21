namespace GSC.Shapes;

internal sealed class Circle : IShape
{
    public double Perimeter(params double[] radius)
    {
        CheckParamsOnException(radius);
        return double.Pi * radius[0] * 2;
    }

    public double Area(params double[] radius)
    {
        CheckParamsOnException(radius);
        return double.Pi * radius[0] * radius[0];
    }

    private static void CheckParamsOnException(params double[] radius)
    {
        if (radius.Length < 1) throw new InvalidOperationException( "ERROR: params.Length < 1 in Circle");
        if (radius[0] <= 0)  throw new ArgumentOutOfRangeException(nameof(radius), "ERROR: radius <= 0");
    }
}