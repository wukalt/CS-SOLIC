namespace ISPRef;

public interface IPrinter
{
    void Print(string document);
}

public interface IScanner
{
    void Scan(string document);
}

public class Printer : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine("Printing: " + document);
    }
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print(string document)
    {
        Console.WriteLine("Printing: " + document);
    }

    public void Scan(string document)
    {
        Console.WriteLine("Scanning: " + document);
    }
}