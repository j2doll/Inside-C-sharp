using System; 
using System.Reflection;

public class TransactionableAttribute : Attribute
{
	public TransactionableAttribute()
	{
	}
}

class TestClass
{
	[Transactionable]
	public void Foo()
	{}

	public void Bar()
	{}

	[Transactionable]
	public void Baz()
	{}
}

class MethodAttrApp
{
	public static void Main()
	{
		Type type = Type.GetType("TestClass");
		foreach(MethodInfo method in type.GetMethods())
		{
			foreach (Attribute attr in
				   method.GetCustomAttributes())
			{
				if (attr is TransactionableAttribute)
				{
					Console.WriteLine("{0} is transactionable.", 
                                                          method.Name);
				}
			}
		}
	}
}
