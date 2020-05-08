using System;
using System.Reflection;
using System.IO;

class LateBindingApp
{
    public static void Main()
    {
		
        string[] fileNames = Directory.GetFiles
            (Environment.CurrentDirectory, 
            CommProtocol.DLLMask);
        foreach(string fileName in fileNames)
        {
            Console.WriteLine("Loading DLL '{0}'", fileName);

            Assembly a = Assembly.LoadFrom(fileName);

            Type[] types = a.GetTypes();
            foreach(Type t in types)
            {
                if (t.IsSubclassOf(typeof(CommProtocol)))
                {
                    object o = Activator.CreateInstance(t);

                    MethodInfo mi = t.GetMethod("DisplayName");

                    Console.Write("\t");
                    mi.Invoke(o, null);
                }
                else
                {
                    Console.WriteLine
                        ("\tThis DLL does not have " +
                        "CommProtocol-derived class defined");
                }
            }
        }
    }
}
