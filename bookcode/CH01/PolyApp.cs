using System;

class Employee
{
	public Employee(string firstName, string lastName,
                   int age, double payRate)
 	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
		this.payRate = payRate;
	}

	protected string firstName;
	protected string lastName;
	protected int age;
	protected double payRate;

	public virtual double CalculatePay(int hoursWorked) 
	{ 
		Console.WriteLine("Employee.CalculatePay");
		return 42; // bogus value
  }
}

class SalariedEmployee : Employee
{
	public SalariedEmployee(string firstName, string lastName,
                   int age, double payRate)
	: base(firstName, lastName, age, payRate)
	{}

	public override double CalculatePay(int hoursWorked) 
	{ 
		Console.WriteLine("SalariedEmployee.CalculatePay");
		return 42; // bogus value
  }
}

class ContractorEmployee : Employee
{
	public ContractorEmployee(string firstName, string lastName,
                   int age, double payRate)
	: base(firstName, lastName, age, payRate)
	{}

	public override double CalculatePay(int hoursWorked) 
	{ 
		Console.WriteLine("ContractorEmployee.CalculatePay");
		return 42; // bogus value
  }
}

class HourlyEmployee : Employee
{
	public HourlyEmployee(string firstName, string lastName,
                   int age, double payRate)
	: base(firstName, lastName, age, payRate)
	{}

	public override double CalculatePay(int hoursWorked) 
	{ 
		Console.WriteLine("HourlyEmployee.CalculatePay");
		return 42; // bogus value
  }
}

class PolyApp
{
	protected Employee[] employees;

	protected void LoadEmployees()
	{
		Console.WriteLine("Loading employees...");

		// In a real application, we'd probably get this from a 
		// database.
		employees = new Employee[3];

		employees[0] = new SalariedEmployee ("Amy", "Anderson", 28, 100);
		employees[1] = new ContractorEmployee ("Tom", "Archer", 35, 110);
		employees[2] = new HourlyEmployee ("Fred", "Flintstone", 2000, 5);

		Console.WriteLine("\n");
	}

	protected void CalculatePay()
	{
		foreach(Employee emp in employees)
		{
			emp.CalculatePay(40);
		}
	}

	public static void Main()
	{
		PolyApp app = new PolyApp();

		app.LoadEmployees();
		app.CalculatePay();
	}
}

