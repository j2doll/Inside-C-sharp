using System;

class Foo
{
	public int x; 
}

class FixedApp
{
	unsafe static void SetFooValue(int* x)
	{
		Console.WriteLine("Dereferenced pointer to modify foo.x");
		*x = 42;
	}

	unsafe static void Main()
	{
		// Create an instance of the structure.
		Console.WriteLine("Creating the Foo class");
		Foo foo = new Foo();

		Console.WriteLine("foo.x intialized to {0}", foo.x);

		// The fixed statement pins the foo object until 
		// the enclosing compound statement ends.
		Console.WriteLine("Setting pointer to foo.x");
		// Assign the address of the foo object to a Foo*
		fixed(int* f = &foo.x) 
		{
			Console.WriteLine("Calling SetFooValue passing " +
                                 "pointer to foo.x");
			SetFooValue(f);
		}

		// Show that we did alter the member via its pointer
		Console.WriteLine("After return from " +
                           "SetFooValue, foo.x = {0}", foo.x);
	}
}

