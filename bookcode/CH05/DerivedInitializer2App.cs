using System;

class A
{
	public A()
  {
		Console.WriteLine("A");
	}

	public A(int foo)
	{
		Console.WriteLine("A = {0}", foo);
	}
}

class B : A
{
	public B(int foo) : base(foo)
  {
		Console.WriteLine("B = {0}", foo);
	}
}

class DerivedInitializer2App
{
	public static void Main()
	{
		B b = new B(42);
	}
}
