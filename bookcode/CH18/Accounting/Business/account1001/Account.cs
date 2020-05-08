// Accounting\Business\Account1001\Account.cs
using System;
using System.Reflection;

[assembly:AssemblyKeyFile("..\\..\\Account.key")]
[assembly:AssemblyVersion("1.0.0.1")] 
public class Account
{
	public static void PrintVersion()
	{				
Console.WriteLine("This is version 1.0.0.1 of the Account class");
	}
}

