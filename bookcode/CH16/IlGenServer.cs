using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ILGenServer
{
	public class CodeGenerator
	{
		public CodeGenerator()
		{
			// get current currentDomain
			currentDomain = AppDomain.CurrentDomain;

			// create assembly in current currentDomain
			assemblyName = new AssemblyName();
			assemblyName.Name = "TempAssembly";

			assemblyBuilder = 
				currentDomain.DefineDynamicAssembly
								(assemblyName, AssemblyBuilderAccess.Run);

			// create a module in the assembly
			moduleBuilder = assemblyBuilder.DefineDynamicModule
  										("TempModule");

			// create a type in the module
			typeBuilder = moduleBuilder.DefineType
									("TempClass",
 									TypeAttributes.Public);
			// add a member (a method) to the type 
			methodBuilder = typeBuilder.DefineMethod
								   ("HelloWorld", 
								    MethodAttributes.Public,
 							    	null,null);

			// generate MSIL
			msil = methodBuilder.GetILGenerator();
			msil.EmitWriteLine("Hello World");
			msil.Emit(OpCodes.Ret);

			// last "build" step : create type
			t = typeBuilder.CreateType();
		}

		AppDomain currentDomain;
		AssemblyName assemblyName;
		AssemblyBuilder assemblyBuilder;
		ModuleBuilder moduleBuilder;
		TypeBuilder typeBuilder;
		MethodBuilder methodBuilder;
		ILGenerator msil;
		object o;

		Type t;
		public Type T
		{
			get
			{
				return this.t;
			}
		}
	}
}
