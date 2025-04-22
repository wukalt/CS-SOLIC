namespace ISP;

public interface IMachine
{
    void Print(string document);
    void Scan(string document);
}

public class Printer : IMachine
{
    public void Print(string document)
    {
        Console.WriteLine("Printing: " + document);
    }

    public void Scan(string document)
    {
        throw new NotImplementedException("This printer does not support scanning!");
    }
}