class Employee { }

class ContractEmployee : Employee { }

class CastExample4
{
	public static void Main ()
	{
		Employee e = new Employee();
		ContractEmployee c = (ContractEmployee)e;
	}
}

