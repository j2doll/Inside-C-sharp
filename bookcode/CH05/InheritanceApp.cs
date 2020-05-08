using System;

class Database
{
	public Database()
	{
		CommonField = 42;
	}
	
	public int CommonField;

	public void CommonMethod()
	{
		Console.WriteLine("Database.Common Method");
	}
}

class SQLServer : Database
{
	public void SomeMethodSpecificToSQLServer() 
	{
		Console.WriteLine("SQLServer.SomeMethodSpecificToSQLServer");
	}
}

class Oracle : Database
{
	public void SomeMethodSpecificToOracle() 
	{
		Console.WriteLine("Oracle.SomeMethodSpecificToOracle");
	}
}

class InheritanceApp
{
	public static void Main()
	{
		SQLServer sqlserver = new SQLServer();

		sqlserver.SomeMethodSpecificToSQLServer();
		sqlserver.CommonMethod();
		Console.WriteLine("Inherited common field = {0}", sqlserver.CommonField);
	}
}
