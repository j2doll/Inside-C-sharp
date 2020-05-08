using System;

public class TestException : Exception
{
    // You would probably have extra methods and properties
    // here that augment the .NET Exception that you derive from.

    // Base Exception class constructors.
    public TestException()
        :base() {}
    public TestException(String message)
        :base(message) {}
    public TestException(String message, Exception innerException)
        :base(message, innerException) {}
}
public class DerivedExceptionTestApp
{
    public static void ThrowException()
    {
        throw new TestException("error condition");
    }
    public static void Main()
    {
        try
        {
            ThrowException();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}

