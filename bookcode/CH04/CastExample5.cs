using System;

class Employee { }

class ContractEmployee : Employee { }

class CastExample5
{
	public static void Main ()   
    {
		Employee e = new Employee();
		Console.WriteLine("e = {0}", 
                       e == null ? "null" : e.ToString());

		ContractEmployee c  = e as ContractEmployee;
		Console.WriteLine("c = {0}", 
		                   c == null ? "null" : c.ToString());
	}
}

