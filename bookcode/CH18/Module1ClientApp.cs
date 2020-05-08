// Module1Client.cs
// build with the following command line switches
// 	csc Module1Client.cs /r:Module1Server.dll 
using System;
using System.Diagnostics;
using System.Reflection;

class Module1ClientApp
{
	public static void Main()
	{
		Assembly DLLAssembly = Assembly.GetAssembly(typeof(Module1Server));
		Console.WriteLine("Module1Server.dll Assembly Information"); 
Console.WriteLine("\t" + DLLAssembly);

		Process p = Process.GetCurrentProcess();
		string AssemblyName = p.ProcessName + ".exe";
		Assembly ThisAssembly = Assembly.LoadFrom(AssemblyName);
		Console.WriteLine("Module1Client.exe Assembly Information"); 
Console.WriteLine("\t" + ThisAssembly);
	}
}

