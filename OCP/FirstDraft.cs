namespace OCP;

class FirstDraft
{
    public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
    {
        double finalAmount = default;

        if (invoiceType is InvoiceType.FinalInvoice)
        {
            finalAmount = amount - 100;
        }
        else if (invoiceType is InvoiceType.ProposedInvoice)
        {
            finalAmount = amount - 50;
        }

        return finalAmount;
    }

    // code is more clean with switch but still break the OC principle
    public double GetInvoiceDiscountWithSwitch(double amount, InvoiceType invoiceType) => invoiceType switch
    {
        InvoiceType.FinalInvoice => amount - 100,
        InvoiceType.ProposedInvoice => amount - 50,
        _ => 0
    };

    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    }
}
