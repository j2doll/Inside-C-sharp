using System;

public class Foo
{
	private static Foo m_f;
	private int m_member;
	private int m_ref;

	public static void Main(String[] args)
	{
		int ticks = Environment.TickCount;

		Foo f2 = null;

		for (int i=0; i < 10000000; ++i)
		{
			Foo f = new Foo();

			// Assign static to f2.
			if (f2 != null)
			{
				if (--f2.m_ref == 0)
					f2.Dispose();
			}
			if (m_f != null)
				++m_f.m_ref;
			f2 = m_f;

			// Assign f to the static.
			if (m_f != null)
			{
				if (--m_f.m_ref == 0)
					m_f.Dispose();
			}
			if (f != null)
				++f.m_ref;
			m_f = f;

			// f goes out of scope.
			if (--f.m_ref == 0)
				f.Dispose();
		}

		// Assign f2 to static
		if (m_f != null)
		{
			if (--m_f.m_ref == 0)
				m_f.Dispose();
		}
		if (f2 != null)
			++f2.m_ref;
		m_f = f2;

		// f2 goes out of scope.
		if (--f2.m_ref == 0)
			f2.Dispose();

		ticks = Environment.TickCount - ticks;
		Console.WriteLine("Ticks = {0}", ticks);
	}

	public Foo()
	{
		m_ref = 1;
	}

	public virtual void Dispose()
	{
	}
}
