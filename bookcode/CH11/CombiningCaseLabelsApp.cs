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
                Console.WriteLine("\nVisa - Everyone's favorite tender.");
                break;

            case (int)Tenders.Visa:
            case (int)Tenders.MasterCard:
            case (int)Tenders.AmericanExpress:
                Console.WriteLine
                    ("\nDisplay Credit Card Authorization Dialog.");
                break;

            default:
                Console.WriteLine("\nSorry - Invalid tender.");
                break;
        }
    }
}

class CombiningCaseLabelsApp
{
	
    public static void Main()
    {
        Payment payment = new Payment(Tenders.MasterCard);
        payment.ProcessPayment();
    }
}
