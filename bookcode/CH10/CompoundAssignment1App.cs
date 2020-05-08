using System;

class CompoundAssignment1App
{
	protected int[] elements;
	public int[] GetArrayElement()
	{
		return elements;
	}

	CompoundAssignment1App()
	{
		elements = new int[1];
		elements[0] = 42;
	}

	public static void Main()
	{
		CompoundAssignment1App app = new CompoundAssignment1App();
		
		Console.WriteLine("{0}", app.GetArrayElement()[0]);
		app.GetArrayElement()[0] = app.GetArrayElement()[0] + 5;
		Console.WriteLine("{0}", app.GetArrayElement()[0]);
	}
}

