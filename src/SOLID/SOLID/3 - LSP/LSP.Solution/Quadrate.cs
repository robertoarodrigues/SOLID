namespace SOLID.LSP.LSP.Solution;
public class Quadrate : Parallelogram
{
    public Quadrate(int height, int width) : base(height, width)
    {
        if (width != height)
            throw new ArgumentException("Both sides of the square must be equal");
    }
}
