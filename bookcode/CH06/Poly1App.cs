using System;

class Employee
{
	public void CalculatePay()
	{
		Console.WriteLine("Employee.CalculatePay()");
	}
}

class SalariedEmployee : Employee
{
	// *******************************************
	// The new keyword enables you to override the 
	// base class' implementation.
	// *******************************************
	new public void CalculatePay()
	{
		Console.WriteLine("SalariedEmployee.CalculatePay()");
	}
}

class Poly1App
{
	public static void Main()
	{
		Poly1App poly1 = new Poly1App();

		Employee baseE = new Employee();
		baseE.CalculatePay();

		SalariedEmployee s = new SalariedEmployee();
		s.CalculatePay();
	}
}

