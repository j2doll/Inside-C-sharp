using System;
using System.Reflection;
using MyUtilities;

class GetModulesApp
{
	public static void Main(string[] args)
	{
		string assemblyName = AssemblyUtils.GetAssemblyName(args);

		Console.WriteLine("Loading info for " + assemblyName);
		Assembly a = Assembly.LoadFrom(assemblyName);

		Module[] modules = a.GetModules();
		foreach(Module m in modules)
		{
			Console.WriteLine("Module: " + m.Name);
		}
	}
}

