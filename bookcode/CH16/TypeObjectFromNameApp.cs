using System;
using System.Reflection;

class TypeObjectFromNameApp
{
	public static void Main(string[] args)
	{
		Type t = Type.GetType("System.Int32");
		Console.WriteLine(t.Name);
	}
}

