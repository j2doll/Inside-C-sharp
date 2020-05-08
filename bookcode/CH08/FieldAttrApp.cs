using System; 
using System.Reflection;

public enum RegistryHives
{
	HKEY_CLASSES_ROOT,
	HKEY_CURRENT_USER,
	HKEY_LOCAL_MACHINE,
	HKEY_USERS,
	HKEY_CURRENT_CONFIG
}

public class RegistryKeyAttribute : Attribute
{
	public RegistryKeyAttribute(RegistryHives Hive, String ValueName)
	{
		this.Hive = Hive;
		this.ValueName = ValueName;
	}

	protected RegistryHives hive;
	public RegistryHives Hive
	{
		get { return hive; }
		set { hive = value; }
	}

	protected String valueName;
	public String ValueName
	{
		get { return valueName; }
		set { valueName = value; }
	}
}

class TestClass
{
	[RegistryKey(RegistryHives.HKEY_CURRENT_USER, "Foo")]
	public int Foo;

	public int Bar;
}

class FieldAttrApp
{
	public static void Main()
	{
		Type type = Type.GetType("TestClass");
		foreach(FieldInfo field in type.GetFields())
		{
			foreach (Attribute attr in field.GetCustomAttributes())
			{
				RegistryKeyAttribute registryKeyAttr = 
attr as RegistryKeyAttribute;
				if (null != registryKeyAttr)
				{
					Console.WriteLine
("{0} will be saved in {1}\\\\{2}", 
						field.Name, 
						registryKeyAttr.Hive, 
						registryKeyAttr.ValueName);
				}
			}
		}
	}
}
