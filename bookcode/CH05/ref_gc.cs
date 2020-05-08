using System;

public class Foo
{
	private static Foo m_f;
	private int m_member;

	public static void Main(String[] args)
	{
		int ticks = Environment.TickCount;

		Foo f2 = null;

		for (int i=0; i < 10000000; ++i)
		{
			Foo f = new Foo();

			// Assign static to f2.
			f2 = m_f;

			// Assign f to the static.
			m_f = f;

			// f goes out of scope.
		}

		// Assign f2 to static
		m_f = f2;

		// f2 goes out of scope.

		ticks = Environment.TickCount - ticks;
		Console.WriteLine("Ticks = {0}", ticks);
	}

	public Foo()
	{
	}
}


