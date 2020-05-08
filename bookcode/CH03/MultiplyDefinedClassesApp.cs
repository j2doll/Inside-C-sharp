using A;
using B;

namespace A
{
	class C
	{
		public static void foo()
		{
			System.Console.WriteLine("A.C.foo");
		}
	}
}

namespace B
{
	class C
	{
		public static void foo()
		{
			System.Console.WriteLine("B.C.foo");
		}
	}
}

class MultiplyDefinedClassesApp
{
	public static void Main()
	{
		C.foo();
	}
}
