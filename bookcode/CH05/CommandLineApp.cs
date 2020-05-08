using System;
class CommandLineApp
{
	public static void Main(string[] args)
	{
		foreach (string arg in args)
		{
			Console.WriteLine("Argument: {0}", arg);
		}
	}
}
