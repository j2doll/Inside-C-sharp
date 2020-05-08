using System;

class SQLServerDb
{
	// bunch of other non-salient members
	public static void RepairDatabase()
	{
		Console.WriteLine("repairing database...");
	}
}

class StaticMethod1App
{
	public static void Main()
	{
		SQLServerDb.RepairDatabase();
	}
}

