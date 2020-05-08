using System;

class WhenToCatchApp
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
            // Call method to set a "commitment boundary"
            Console.WriteLine("setting commitment boundary");

            // Call Baz to save data
            Console.WriteLine("calling Baz to save data");
            Baz();

            Console.WriteLine("commiting saved data");
        }
        catch(Exception)
        {
        		// In this case, Bar should catch the exception 
				// because it's doing something significant 
				//(rolling back uncommitted database changes).
            
            	Console.WriteLine("rolling back uncommited changes " +
 						"and then rethrowing exception");

            throw;
        }
    }

    public void Baz()
    {
        throw new Exception("db failure in Baz");
    }

    public static void Main()
    {
        WhenToCatchApp test = new WhenToCatchApp();
        test.Foo(); // This method will ultimately print the error msg.
    }
}

