// Module2ClientApp.cs
// build with the following command line switches
// 	csc /addmodule:Module2Server.netmodule Module2Client.cs 
using System;
using System.Diagnostics;
using System.Reflection;

class Module2ClientApp
{
	public static void Main()
	{
		Assembly DLLAssembly = 
            Assembly.GetAssembly(typeof(Module2Server));
		Console.WriteLine("Module1Server.dll Assembly Information");
		Console.WriteLine("\t" + DLLAssembly);

		Process p = Process.GetCurrentProcess();
		string AssemblyName = p.ProcessName + ".exe";
		Assembly ThisAssembly = Assembly.LoadFrom(AssemblyName);
		Console.WriteLine("Module1Client.dll Assembly Information");
		Console.WriteLine("\t" + ThisAssembly);
	}
}

