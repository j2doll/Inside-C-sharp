using System;

class BreakTestApp
{
    public static void Main()
    {
        for (int i = 1; i <= 100; i ++)
        {
            if (0 == i % 6) 
            {
                Console.WriteLine(i);
            }
      
            if (i == 66)
            {
                break;
            }
        }
    }
}

