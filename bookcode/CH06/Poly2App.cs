using System;

class Employee
{
	public Employee(string name)
	{
		this.Name = name;
	}

	protected string Name;
	public string name
	{
		get
		{
			return this.Name;
		}
	}

	public void CalculatePay()
	{
		Console.WriteLine("Employee.CalculatePay called for {0}", name);
	}
}

class ContractEmployee : Employee
{
	public ContractEmployee(string name)
	: base(name)
	{
	}

	public new void CalculatePay()
	{
		Console.WriteLine("ContractEmployee.CalculatePay called for {0}", name);
	}
}

class SalariedEmployee : Employee
{
	public SalariedEmployee (string name)
	: base(name)
	{
	}

	public new void CalculatePay()
	{
		Console.WriteLine("SalariedEmployee.CalculatePay called for {0}", name);
	}
}

class Poly2App
{
	protected Employee[] employees;

	public void LoadEmployees()
	{
		// simulating loading from a database
		employees = new Employee[2];
		employees[0] = new ContractEmployee("Fred");
		employees[1] = new SalariedEmployee("Barney");
	}

	public void DoPayroll()
	{
		foreach(Employee emp in employees)
		{
			emp.CalculatePay();
		}
	}

	public static void Main()
	{
		Poly2App poly2 = new Poly2App();
		poly2.LoadEmployees();
		poly2.DoPayroll();
	}
}
