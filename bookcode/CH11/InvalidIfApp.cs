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
		if (foo) // ERROR: attempting to convert int to bool
		{
		}

		TestClass t = GetTestClass();
		if (t) // ERROR: attempting to convert TestClass to bool
		{
			Console.WriteLine("{0}", t);

			ITest i = t as ITest; 
			if (i) // ERROR: attempting to convert ITest to bool
			{
				// ITest methods
			}
		}
	}
}
