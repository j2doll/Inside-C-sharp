class Employee { }

class ContractEmployee : Employee { }

class CastExample3
{
	public static void Main ()
	{
		ContractEmployee ce = (ContractEmployee)new Employee(); 
	}
}

