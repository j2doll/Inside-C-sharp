// Module3Client.cs
// build with the following command line switches
// 	csc /addmodule:Module3Server.netmodule Module3Client.cs 
using System;
using System.Diagnostics;
using System.Reflection;

[assembly:AssemblyKeyFile("InsideCSharp.key")]

class Module3ClientApp
{
	public static void Main()
	{
		Assembly DLLAssembly = 
            Assembly.GetAssembly(typeof(Module3Server));
		Console.WriteLine("Module1Server.dll Assembly Information");
		Console.WriteLine("\t" + DLLAssembly);

		Process p = Process.GetCurrentProcess();
		string AssemblyName = p.ProcessName + ".exe";
		Assembly ThisAssembly = Assembly.LoadFrom(AssemblyName);
		Console.WriteLine("Module1Client.dll Assembly Information");
		Console.WriteLine("\t" + ThisAssembly);
	}
}

