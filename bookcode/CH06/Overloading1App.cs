using System;

class Log
{
	public Log(string fileName)
	{
		// Open fileName and seek to end.
	}

	public void WriteEntry(string entry)
	{
		Console.WriteLine(entry);
	}

	public void WriteEntry(int resourceId)
	{
		Console.WriteLine
		("Retrieve string using resource id and write to log");
	}
}

class Overloading1App
{
	public static void Main()
	{
		Log log = new Log("My File");
		log.WriteEntry("Entry one");
		log.WriteEntry(42);
	}
}
