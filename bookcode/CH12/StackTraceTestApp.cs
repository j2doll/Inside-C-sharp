using System;

class StackTraceTestApp
{
    public void Open(String fileName)
    {
        Lock(fileName);
        // ...
    }
    public void Lock(String fileName)
    {
        // Error condition raised.
        throw new Exception("failed to lock file");
    }
    public static void Main()
    {
        StackTraceTestApp test = new StackTraceTestApp();

        try
        {
            test.Open("c:\\test.txt");
            // Use file.
        }
        catch(Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
} 

