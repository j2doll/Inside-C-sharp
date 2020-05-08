using System;

enum Tenders : int
{
    Cash = 1,
    Visa,
    MasterCard,
    AmericanExpress
};

class Payment
{
    public Payment(Tenders tender)
    {
        this.Tender = tender;
    }

    protected Tenders tender;
    public Tenders Tender
    {
        get
        {
            return this.tender;
        }
        set
        {
            this.tender = value;
        }
    }

    public void ProcessPayment()
    {
        switch ((int)(this.tender))
        {
            case (int)Tenders.Cash:
                Console.WriteLine("\nVisa - Accepted");
                break;

            case (int)Tenders.Visa:
                Console.WriteLine("\nVisa - Accepted");
                break;

            case (int)Tenders.MasterCard:
                Console.WriteLine("\nMastercard - Accepted");
                break;

            case (int)Tenders.AmericanExpress:
                Console.WriteLine("\nAmerican Express - Accepted");
                break;

            default:
                Console.WriteLine("\nSorry - Invalid tender");
                break;
        }
    }
}

class SwitchApp
{
    public static void Main()
    {
        Payment payment = new Payment(Tenders.Visa);
        payment.ProcessPayment();
    }
}
