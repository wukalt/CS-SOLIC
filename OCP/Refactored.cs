namespace OCP;

abstract class Invoice
{
    public abstract double GetDiscount(double amount);
}

class FinalInvoice : Invoice
{
    public override double GetDiscount(double amount) 
        => amount - 100;
}

class ProposedInvoice : Invoice
{
    public override double GetDiscount(double amount) 
        => amount - 50;
}

class InvoiceProcessor
{
    public double GetInvoiceDiscount(double amount, Invoice invoice) 
        => invoice.GetDiscount(amount);
}
