using System;

class MathOpsApp
{
	public static void Main()
	{
		// The System.Random class is part of the .NET Framework
		// class library. It's default constructor seeds using the current 
		// date/time.
		Random rand =  new Random();
		int a, b, c;
		
		a = rand.Next() % 100; // Limit max to 99.
		b = rand.Next() % 100; // Limit max to 99.

		Console.WriteLine("a={0} b={1}", a, b);

		c = a * b;
		Console.WriteLine("a * b = {0}", c);

		c = a / b;
		Console.WriteLine("a / b = {0}", c);

		c = a + b;
		Console.WriteLine("a + b = {0}", c);

		c = a - b;
		Console.WriteLine("a - b = {0}", c);

		c = a % b;
		Console.WriteLine("a % b = {0}", c);
	}
}

