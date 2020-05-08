using System;

class IncDecApp
{
	public static void Foo(int ij)
	{
		Console.WriteLine("IncDecApp.Foo i j = {0}", ij);
	}

	public static void Main()
	{
		int i = 1;

		Console.WriteLine("Before call to Foo(i++) = {0}", i);
		Foo(i++);
		Console.WriteLine("After call to Foo(i++) = {0}", i);

		Console.WriteLine("\n");

		Console.WriteLine("Before call to Foo(++i) = {0}", i);
		Foo(++i);
		Console.WriteLine("After call to Foo(++i) = {0}", i);
	}
}
