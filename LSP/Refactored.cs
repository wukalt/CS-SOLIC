namespace LSPRef;

interface IShape
{
    double GetArea();
}

// use interfaces 
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea() => Width * Height;
}

public class Square : IShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double GetArea() => Side * Side;
}