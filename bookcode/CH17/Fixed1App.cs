using System;

struct Foo
{
	public int x;
}

class Fixed1App
{
	unsafe static void Main()
	{
		// Create an instance of the structure.
		Foo foo = new Foo();

		// The fixed statement pins the foo object until 
		// the enclosing compound statement ends.
		fixed(Foo* f = &foo) // Assign the address of 
		// the foo object to a Foo*
		{
			// Alter the Foo.x member
			f->x = 42;

			// Show that we did alter the member via the 
			// standard -> operator
			Console.WriteLine("\nf->x = {0}", f->x);
		}
	}
}

