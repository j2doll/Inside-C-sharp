// Module1Client.cs
// build with the following command line switches
// 	csc Module1Client.cs /r:Module1Server.dll /r:System.Diagnostics.dll
using System;
using System.Diagnostics;
using System.Reflection;

class Module1ClientApp
{
    public static void Main()
    {
        Assembly DLLAssembly = Assembly.GetAssembly(typeof(Module1Server));
        Console.WriteLine(DLLAssembly);

        Process p = Process.GetCurrentProcess();
        string AssemblyName = p.ProcessName + ".exe";
        Assembly ThisAssembly = Assembly.LoadFrom(AssemblyName);
        Console.WriteLine(ThisAssembly);
    }
}
