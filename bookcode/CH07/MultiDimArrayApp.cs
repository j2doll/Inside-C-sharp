using System;

class MultiDimArrayApp
{
  protected int currentMonth;
  protected double[,] sales;

  MultiDimArrayApp()
  {
    currentMonth=10; 

    sales = new double[2, currentMonth];
    for (int i = 0; i < sales.GetLength(0); i++)
    {
      for (int j=0; j < 10; j++)
      {
        sales[i,j] = (i * 100) + j;
      }
    }
    Console.WriteLine(sales.Length);
  }

  protected void PrintSales()
  {
    for (int i = 0; i < sales.GetLength(0); i++)
    {
      for (int j=0; j < sales.GetLength(1); j++)
      {
        Console.WriteLine("[{0}][{1}]={2}", i, j, sales[i,j]);
      }
    }
  }
  
  public static void Main()
  {
    MultiDimArrayApp app = new MultiDimArrayApp();
    app.PrintSales();
  }
}

