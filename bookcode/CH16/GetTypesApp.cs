using System;
using System.Diagnostics;
using System.Reflection;

class DemoAttr : System.Attribute
{
}

enum DemoEnum
{
}

class DemoBaseClass
{
}

class DemoDerivedClass : DemoBaseClass
{
}

class DemoStruct
{
}

class GetTypesApp
{
	protected static string GetAssemblyName(string[] args)
	{
		string assemblyName;

		if (0 == args.Length)
		{
			Process p = Process.GetCurrentProcess();
			assemblyName = p.ProcessName + ".exe";
		}
		else
			assemblyName = args[0];

		return assemblyName;
	}

	public static void Main(string[] args)
	{
		string assemblyName = GetAssemblyName(args);

		Console.WriteLine("Loading info for " + assemblyName);
		Assembly a = Assembly.LoadFrom(assemblyName);

		Type[] types = a.GetTypes();
		foreach(Type t in types)
		{
			Console.WriteLine("\nType information for: " + t.FullName);
			Console.WriteLine("\tBase class = " + t.BaseType.FullName);
		}
	}
}

