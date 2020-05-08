using System;

class WhenNotToCatchApp
{
    public void Foo()
    {
        try
        {
            Bar();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Bar()
    {
        try
        {
            Baz();
        }
        catch(Exception e)
        {
			// Bar should catch this because it 
			// doesn't do anything but rethrow it            

			throw; 
        }
    }

    public void Baz()
    {
        throw new Exception("Exception originally thrown by Baz");
    }

    public static void Main()
    {
        WhenNotToCatchApp test = new WhenNotToCatchApp();
        test.Foo(); // This method will ultimately
                  // print the error message.
    }
}

