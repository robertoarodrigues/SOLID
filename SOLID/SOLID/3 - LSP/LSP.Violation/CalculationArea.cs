namespace SOLID.LSP.LSP.Violation;
public class CalculationArea
{
    public static void GetAreaRectangle(Rectangle rectangle)
    {
        //Calculate the area of ​​the rectangle"
    }

    public static void Calculate()
    {
        var quad = new Quadrate()
        {
            Height = 10,
            Width = 5
        };

        GetAreaRectangle(quad);
    }
}
