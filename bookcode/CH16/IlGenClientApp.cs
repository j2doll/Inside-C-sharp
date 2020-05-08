using System;
using System.Reflection;
using ILGenServer;

public class ILGenClientApp
{
	public static void Main()
	{
		Console.WriteLine("Calling DLL function to generate " + 
						"a new type and method in memory...");
		CodeGenerator gen = new CodeGenerator();

		Console.WriteLine("Retrieving dynamically generated type...");
		Type t = gen.T;
		if (null != t)
		{
			Console.WriteLine("Instantiating the new type...");
			object o = Activator.CreateInstance(t);

			Console.WriteLine("Retrieving the type's " +
							"HelloWorld method...");
			MethodInfo helloWorld = t.GetMethod("HelloWorld");
			if (null != helloWorld)
			{
				Console.WriteLine("Invoking our dynamically " +
								"created HelloWorld method...");
				helloWorld.Invoke(o, null);
			}
			else
			{
				Console.WriteLine("Could not locate " +
								"HelloWorld method");
			}
		}
		else
		{
			Console.WriteLine("Could not access Type from server");
		}
	}
}

