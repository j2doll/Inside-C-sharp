using System;

class Foo
{
	public int i;
}

class RefTest1App
{
	public static void Main()
	{
		Foo test1 = new Foo();
		test1.i = 1;
		
		Foo test2 = new Foo();
		test2.i = 2;

		Console.WriteLine("BEFORE OBJECT ASSIGNMENT");
		Console.WriteLine("test1.i={0}", test1.i);
		Console.WriteLine("test2.i={0}", test2.i);
		Console.WriteLine("\n");

		test1 = test2;

		Console.WriteLine("AFTER OBJECT ASSIGNMENT");
		Console.WriteLine("test1.i={0}", test1.i);
		Console.WriteLine("test2.i={0}", test2.i);
		Console.WriteLine("\n");

		test1.i = 42;

		Console.WriteLine("AFTER CHANGE TO ONLY TEST1 MEMBER");
		Console.WriteLine("test1.i={0}", test1.i);
		Console.WriteLine("test2.i={0}", test2.i);
		Console.WriteLine("\n");
	}
}
