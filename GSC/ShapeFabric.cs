using GSC.Enum;
using GSC.Shapes;

namespace GSC;

internal static class ShapeFabric
{
    internal static IShape GetShape(ShapeType type)
    {
        return type switch
        {
            ShapeType.CIRCLE => new Circle(),
            ShapeType.RECTANGLE => new Rectangle(),
            ShapeType.SQUARE => new Square(),
            _ => throw new ArgumentException("Wrong shape type:" + type)
        };
    } 
}