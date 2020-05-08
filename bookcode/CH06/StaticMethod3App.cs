using System;

class SQLServerDb
{
	static string progressString1 = "repairing database...";
	string progressString2 = "repairing database...";

	public static void RepairDatabase()
	{
		Console.WriteLine(progressString1); // This will work.
		Console.WriteLine(progressString2); // This will fail 
											// compilation.
	}

}

class StaticMethod3App
{
	public static void Main()
	{
		SQLServerDb.RepairDatabase();
	}
}

