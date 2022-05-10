namespace SOLID.LSP.LSP.Violation;
public class Quadrate : Rectangle
{
    public override double Height 
    {
        set { base.Height = base.Width = value; }
    }

    public override double Width 
    {
        set { base.Height = base.Width = value; }
    }
}
