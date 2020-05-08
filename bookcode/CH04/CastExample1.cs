class Employee { }

class ContractEmployee : Employee { }

class CastExample1
{
	public static void Main ()
	{
		Employee e = new ContractEmployee();
	}
}

