using System; 

public enum RemoteServers
{
	JEANVALJEAN,
	JAVERT,
	COSETTE	
}

public class RemoteObjectAttribute : Attribute
{
	public RemoteObjectAttribute(RemoteServers Server)
	{
		this.server = Server;
	}

	protected RemoteServers server;
	public string Server
	{
		get 
		{ 
			return RemoteServers.GetName(typeof(RemoteServers),
                                            this.server);
		}
	}
}

[RemoteObject(RemoteServers.COSETTE)]
class MyRemotableClass
{
}
class ClassAttrApp
{
	public static void Main()
	{
		Type type = typeof(MyRemotableClass);
		foreach (Attribute attr in type.GetCustomAttributes())
		{
			RemoteObjectAttribute remoteAttr = 
                attr as RemoteObjectAttribute;
			if (null != remoteAttr)
			{
    			Console.WriteLine("Create this object on {0}.",
                                       remoteAttr.Server);
			}
		}
	}
}
