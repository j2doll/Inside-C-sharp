using System;
using System.Reflection;

class TypeObjectFromInstanceApp
{
	public static void Main(string[] args)
	{
		int i = 6;
		Type t = i.GetType();
		Console.WriteLine(t.Name);
	}
}

