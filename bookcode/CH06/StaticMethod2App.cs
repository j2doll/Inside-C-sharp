// This code will fail to compile. 
using System;

class SQLServerDb
{
	// Bunch of other non-salient members.
	public static void RepairDatabase()
	{
		Console.WriteLine("repairing database...");
	}
}

class StaticMethod2App
{
	public static void Main()
	{
		SQLServerDb db = new SQLServerDb();
		db.RepairDatabase();
	}
}

