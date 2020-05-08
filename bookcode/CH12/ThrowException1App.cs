using System;

public class ThrowException1App
{
 public static void ThrowException()
    {
        throw new Exception();
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("try...");
        }
        catch(Exception e)
        {
            Console.WriteLine("catch...");
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
}

