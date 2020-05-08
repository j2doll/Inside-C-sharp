using System;

class A
{
	public A()
  {
		Console.WriteLine("A");
	}
}

class B : A
{
public B() : base()
  {
		Console.WriteLine("B");
	}
}

class BaseDefaultInitializerApp
{
	public static void Main()
	{
		B b = new B();
	}
}
