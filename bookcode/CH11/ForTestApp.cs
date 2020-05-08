using System;

class ForTestApp
{
    const int StartChar = 33;
    const int EndChar = 125;

    static public void Main()
    {
        for (int i = StartChar; i <= EndChar; i++)
        {
            Console.WriteLine("{0}={1}", i, (char)i);
        }
    }
}
