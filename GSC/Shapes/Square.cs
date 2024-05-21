namespace GSC.Shapes;

internal sealed class Square : IShape
{
    public double Perimeter(params double[] length)
    {
        CheckParamsOnException(length);
        return length[0] * 4;
    }

    public double Area(params double[] length)
    {
        CheckParamsOnException(length);
        return length[0] * length[0];
    }

    private static void CheckParamsOnException(params double[] length)
    {
        if (length.Length < 1) throw new InvalidOperationException("ERROR: params.Length < 1 in Square");
        if (length[0] <= 0)  throw new ArgumentOutOfRangeException(nameof(length), "ERROR: length <= 0");
    }
}