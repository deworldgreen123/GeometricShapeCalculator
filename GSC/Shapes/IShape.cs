namespace GSC.Shapes;

internal interface IShape
{
    internal double Perimeter(params double[] shapeParameters);
    internal double Area(params double[] shapeParameters);

    void CheckParamsOnException(params double[] shapeParameters)
    {
        // example 
        if (shapeParameters.Length < 1) throw new InvalidOperationException( "ERROR: params.Length < 1");
    }
}