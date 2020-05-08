using System;
using System.Globalization;

class FooLib
{
	protected bool IsValidParam(string value)
	{
		bool success = false;

		if (value.Length == 3)
		{
			char c1 = value[0];
			if (CharacterInfo.IsNumber(c1))
			{
				char c2 = value[2];
				if (CharacterInfo.IsNumber(c2))
				{
					if (value[1] == '.')
						success = true;
				}
			}
		}

		return success;
	}

	public void DoWork(string value)
	{
		if (!IsValidParam(value))
			throw new Exception("", new FormatException("Invalid parameter specified"));
		Console.WriteLine("Work done with '{0}'", value);
	}	
}

class FooLibClientApp
{
	public static void Main(string[] args)
	{
		FooLib lib = new FooLib();
		try
		{
			lib.DoWork(args[0]);
		}
		catch(Exception e)
		{
			Exception inner = e.InnerException;
			Console.WriteLine(inner.Message);
		}
	}
}

