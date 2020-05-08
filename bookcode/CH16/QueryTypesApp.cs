using System;
using System.Reflection;

interface DemoInterface
{
}

class DemoAttr : System.Attribute
{
}

enum DemoEnum
{
}

public class DemoBaseClass
{
}

public class DemoDerivedClass : DemoBaseClass
{
}

class DemoStruct
{
}

class QueryTypesApp
{
	public static void QueryType(string typeName)
	{
		try
		{
			Type type = Type.GetType(typeName);
			Console.WriteLine("Type name: {0}", type.FullName);
			Console.WriteLine("\tHasElementType = {0}",
 							type.HasElementType);
			Console.WriteLine("\tIsAbstract = {0}", type.IsAbstract);
			Console.WriteLine("\tIsAnsiClass = {0}", type.IsAnsiClass);
			Console.WriteLine("\tIsArray = {0}", type.IsArray);
			Console.WriteLine("\tIsAutoClass = {0}", type.IsAutoClass);
			Console.WriteLine("\tIsAutoLayout = {0}",
							 type.IsAutoLayout);
			Console.WriteLine("\tIsByRef = {0}", type.IsByRef);
			Console.WriteLine("\tIsClass = {0}", type.IsClass);
			Console.WriteLine("\tIsCOMObject = {0}", type.IsCOMObject);
			Console.WriteLine("\tIsContextful = {0}",
 							type.IsContextful);
			Console.WriteLine("\tIsEnum = {0}", type.IsEnum);
			Console.WriteLine("\tIsExplicitLayout = {0}", 
 							type.IsExplicitLayout);
			Console.WriteLine("\tIsImport = {0}", type.IsImport);
			Console.WriteLine("\tIsInterface = {0}",
 							type.IsInterface);
			Console.WriteLine("\tIsLayoutSequential = {0}",
 							type.IsLayoutSequential);
			Console.WriteLine("\tIsMarshalByRef = {0}",
 							type.IsMarshalByRef);
			Console.WriteLine("\tIsNestedAssembly = {0}",
 							type.IsNestedAssembly);
			Console.WriteLine("\tIsNestedFamANDAssem = {0}",
 							type.IsNestedFamANDAssem);
			Console.WriteLine("\tIsNestedFamily = {0}",
 							type.IsNestedFamily);
			Console.WriteLine("\tIsNestedFamORAssem = {0}",
 							type.IsNestedFamORAssem);
			Console.WriteLine("\tIsNestedPrivate = {0}",
 							type.IsNestedPrivate);
			Console.WriteLine("\tIsNestedPublic = {0}",
 							type.IsNestedPublic);
			Console.WriteLine("\tIsNotPublic = {0}", type.IsNotPublic);
			Console.WriteLine("\tIsPointer = {0}", type.IsPointer);
			Console.WriteLine("\tIsPrimitive = {0}", type.IsPrimitive);
			Console.WriteLine("\tIsPublic = {0}", type.IsPublic);
			Console.WriteLine("\tIsSealed = {0}", type.IsSealed);
			Console.WriteLine("\tIsSerializable = {0}",
 							type.IsSerializable);
			Console.WriteLine("\tIsServicedComponent = {0}",
 							type.IsServicedComponent);
			Console.WriteLine("\tIsSpecialName = {0}",
 							type.IsSpecialName);
			Console.WriteLine("\tIsUnicodeClass = {0}",
 							type.IsUnicodeClass);
		//	Console.WriteLine("\tIsUnmanagedValueType = {0}",
 		//					type.IsUnmanagedValueType);
			Console.WriteLine("\tIsValueType = {0}", type.IsValueType);
		}
		catch(System.NullReferenceException)
		{
			Console.WriteLine("{0} is not a valid type", typeName);
		}
	}

	public static void Main(string[] args)
	{
		QueryType("System.Int32");
		QueryType("System.Int64");
		QueryType("System.Type");

		QueryType("DemoAttr");
		QueryType("DemoEnum");
		QueryType("DemoBaseClass");
		QueryType("DemoDerivedClass");
		QueryType("DemoStruct");
	}
}


