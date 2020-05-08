using System;

class RightAssocApp
{
	public static void Main()
	{
		int a = 1;
		int b = 2;
		int c = 3;
		
		Console.WriteLine("a={0} b={1} c={2}", a, b, c);		

		a = b = c;
		Console.WriteLine("After 'a=b=c': a={0} b={1} c={2}", a, b, c);		
	}
}

