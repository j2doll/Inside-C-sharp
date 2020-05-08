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
	public B()
  {
		Console.WriteLine("B");
	}
}

class DefaultInitializerApp
{
	public static void Main()
	{
		B b = new B();
	}
}
