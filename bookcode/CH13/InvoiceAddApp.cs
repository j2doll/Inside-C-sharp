using System;
using System.Collections;

class InvoiceDetailLine
{
    double lineTotal;
    public double LineTotal
    {
        get
        {
            return this.lineTotal;
        }
    }

    public InvoiceDetailLine(double LineTotal)
    {
        this.lineTotal = LineTotal;
    }
}

class Invoice
{
    public ArrayList DetailLines;

    public Invoice()
    {
        DetailLines = new ArrayList();
    }

    public void PrintInvoice()
    {
        Console.WriteLine("\nLine Nbr\tTotal");

        int i = 1;
        double total = 0;
        foreach(InvoiceDetailLine detailLine in DetailLines)
        {
            Console.WriteLine("{0}\t\t{1}", i++, detailLine.LineTotal);
            total += detailLine.LineTotal;
        }

        Console.WriteLine("=====\t\t===");
        Console.WriteLine("Total\t\t{1}", i++, total);
    }

    public static Invoice operator+ (Invoice invoice1, Invoice invoice2)
    {
        Invoice returnInvoice = new Invoice();

        foreach (InvoiceDetailLine detailLine in invoice1.DetailLines)
        {
            returnInvoice.DetailLines.Add(detailLine);
        }

        foreach (InvoiceDetailLine detailLine in invoice2.DetailLines)
        {
            returnInvoice.DetailLines.Add(detailLine);
        }
        return returnInvoice;
    }
}

class InvoiceAddApp
{
    public static void Main()
    {
        Invoice i1 = new Invoice();
        for (int i = 0; i < 2; i++)
        {
            i1.DetailLines.Add(new InvoiceDetailLine(i + 1));
        }

        Invoice i2 = new Invoice();
        for (int i = 0; i < 2; i++)
        {
            i2.DetailLines.Add(new InvoiceDetailLine(i + 1));
        }

        Invoice summaryInvoice = i1 + i2;

        summaryInvoice.PrintInvoice();
    }
}
