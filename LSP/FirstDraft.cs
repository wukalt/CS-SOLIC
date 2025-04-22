namespace LSP;

public class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public double GetArea() => Width * Height;
}

public class Square : Rectangle
{
    public override double Width
    {
        set { base.Width = base.Height = value; }
    }

    public override double Height
    {
        set { base.Width = base.Height = value; }
    }
}