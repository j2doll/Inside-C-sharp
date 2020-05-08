using System;

enum Tenders : int
{
    ChargeOff,
    Cash,
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

    protected void ChargeOff()
    {
        Console.WriteLine("Charge off.");
    }

    protected bool ValidateCreditCard()
    {
        Console.WriteLine("Card approved.");
        return true;
    }

    protected void ChargeCreditCard()
    {
        Console.WriteLine("Credit Card charged.");
    }

    protected void PrintReceipt()
    {
        Console.WriteLine("Thank you and come again.");
    }
  
    public void ProcessPayment()
    {
        switch ((int)(this.tender))
        {
            case (int)Tenders.ChargeOff:
                ChargeOff();
                goto case Tenders.Cash;

            case (int)Tenders.Visa:
            case (int)Tenders.MasterCard:
            case (int)Tenders.AmericanExpress:
                if (ValidateCreditCard())
                    ChargeCreditCard();
                goto case Tenders.Cash;

            case (int)Tenders.Cash:
                PrintReceipt();
                break;

            default:
                Console.WriteLine("\nSorry - Invalid tender.");
                break;
        }
    }
}

class GotoCaseApp
{
    public static void Main()
    {
        Payment payment = new Payment(Tenders.Visa);
        payment.ProcessPayment();
    }
}

