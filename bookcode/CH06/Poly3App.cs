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

	virtual public void CalculatePay()
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

	override public void CalculatePay()
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

	override public void CalculatePay()
	{
		Console.WriteLine("SalariedEmployee.CalculatePay called for {0}", name);
	}
}

class Poly3App
{
	protected Employee[] employees;

	public void LoadEmployees()
	{
		// Simulating loading from a database.
		employees = new Employee[2];
		employees[0] = new ContractEmployee("Kate Dresen");
		employees[1] = new SalariedEmployee("Megan Sherman");
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
		Poly3App poly3 = new Poly3App();
		poly3.LoadEmployees();
		poly3.DoPayroll();
	}
}
