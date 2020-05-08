using System;

class SingleDimArrayApp
{
  protected int[] numbers;

  SingleDimArrayApp()
  {
    numbers = new int[6];
    for (int i = 0; i < 6; i++)
    {
      numbers[i] = i * i;
    }
  }

  protected void PrintArray()
  {
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.WriteLine("numbers[{0}]={1}", i, numbers[i]);
    }
  }
  
  public static void Main()
  {
    SingleDimArrayApp app = new SingleDimArrayApp();
    app.PrintArray();
  }
}

