namespace SOLID.LSP.LSP.Solution;
public abstract class Parallelogram
{
    protected Parallelogram(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Height { get; private set; }
    public double Width { get; private set; }
    public double Area { get { return Height * Width; } }
}
