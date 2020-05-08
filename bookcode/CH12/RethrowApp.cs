using System;

class RethrowApp
{
    static public void Main()
    {
        Rethrow rethrow = new Rethrow();

        try
        {
            rethrow.Foo();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Foo()
    {
        try 
        {
            Bar();
        }
        catch(Exception)
        {
            // Handle error.
            throw;
        }
    }

    public void Bar()
    {
        throw new Exception("thrown by Rethrow.Bar");
    }
}

