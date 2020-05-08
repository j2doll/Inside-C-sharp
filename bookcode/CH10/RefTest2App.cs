using System;

class Foo
{
	public int i;
}

class RefTest2App
{
	public void ChangeValue(Foo f)
	{
		f.i = 42;
	}

	public static void Main()
	{
		RefTest2App app = new RefTest2App();

		Foo test = new Foo();
		test.i = 6;

		Console.WriteLine("BEFORE METHOD CALL");
		Console.WriteLine("test.i={0}", test.i);
		Console.WriteLine("\n");

		app.ChangeValue(test);

		Console.WriteLine("AFTER METHOD CALL");
		Console.WriteLine("test.i={0}", test.i);
		Console.WriteLine("\n");
	}
}
