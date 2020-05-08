class Employee { }

class ContractEmployee : Employee { }

class CastExample2
{
	public static void Main ()
	{
		ContractEmployee ce = new Employee(); // won't compile
	}
}

