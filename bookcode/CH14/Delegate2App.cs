using System;

class DBConnection
{
	public DBConnection(string name)
	{
		this.name = name;
	}

	protected string Name;
	public string name
	{
		get
		{
			return this.Name;
		}
		set
		{
			this.Name = value;
		}
	}
}

class DBManager
{
  static DBConnection[] activeConnections;
	public void AddConnections()
	{
		activeConnections = new DBConnection[5];
		for (int i = 0; i < 5; i++)
		{
			activeConnections[i] = new DBConnection("DBConnection " + (i + 1));
		}
	}

  public delegate void EnumConnectionsCallback(DBConnection connection);
	public static void EnumConnections(EnumConnectionsCallback callback)
	{
		foreach (DBConnection connection in activeConnections)
		{
			callback(connection);
		}
	}
}

class Delegate2App
{
	public static DBManager.EnumConnectionsCallback myCallback = 
			new DBManager.EnumConnectionsCallback(ActiveConnectionsCallback);

	public static void ActiveConnectionsCallback(DBConnection connection)
	{
		Console.WriteLine("Callback method called for " + connection.name);
	}

	public static void Main()
	{
		DBManager dbMgr = new DBManager();
		dbMgr.AddConnections();

		DBManager.EnumConnections(myCallback);
	}
}
