using System;

class Overloading3App
{
	void Foo(double input)
	{
		Console.WriteLine("Overloading3App.Foo(double)");
	}

	// ERROR: Only differs by return value – won't compile.
	double Foo(double input)
	{
		Console.WriteLine("Overloading3App.Foo(double) (second version)");
	}

	public static void Main()
	{
		Overloading3App app = new Overloading3App();

		double i = 5;
		app.Foo(i);
	}
}
