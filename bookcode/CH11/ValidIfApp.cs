using System;

interface ITest
{

}

class TestClass : ITest
{
}

class InvalidIfApp
{
	protected static TestClass GetTestClass()
	{
		return new TestClass();
	}

	public static void Main()
	{
		int foo = 1;
		if (foo > 0) 
		{
		}

		TestClass t = GetTestClass();
		if (t != null) 
		{
			Console.WriteLine("{0}", t);

			ITest i = t as ITest; 
			if (i != null)
			{
				// ITest methods
			}
		}

    }
}
