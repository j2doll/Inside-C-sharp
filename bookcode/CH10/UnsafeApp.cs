using System;

class BasicTypes
{
    // NOTE: You must declare that code that uses the sizeof
    // operator as unsafe.
    static unsafe public void ShowSizes() 
    {
        Console.WriteLine("\nBasic type sizes");
        Console.WriteLine("sizeof short = {0}", sizeof(short));
        Console.WriteLine("sizeof int = {0}", sizeof(int));
        Console.WriteLine("sizeof long = {0}", sizeof(long));
        Console.WriteLine("sizeof bool = {0}", sizeof(bool));
    }
}

class UnsafeApp
{
    unsafe public static void Main() 
    {
        BasicTypes.ShowSizes();
    }
}
