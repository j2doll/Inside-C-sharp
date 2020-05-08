using System;

class Unsafe1App
{
	public static unsafe void GetValues(int* x, int* y)
	{
		*x = 6;
		*y = 42;
	}

	public static unsafe void Main()
	{
		int a = 1;
		int b = 2;
		Console.WriteLine("Before GetValues() : a = {0}, b = {1}", a, b);
		GetValues(&a, &b);
		Console.WriteLine("After GetValues() : a = {0}, b = {1}", a, b);
	}
}

