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

	public double CalculatePay(int hoursWorked) 
	{ 
        // calculate pay here
        return (payRate * (double)hoursWorked); 
 }
}

class EmployeeApp
{
	public static void Main()
	{
		Employee emp = new Employee ("Amy", "Anderson", 28, 100);
		Console.WriteLine("\nAmy's pay is $" + emp.CalculatePay(40));
	}
}