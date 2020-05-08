using System;

public class FancyControl
{
	protected string Data;
	public string data
	{
		get
		{
			return this.Data;
		}
		set
		{
			this.Data = value;
		}
	}
}

interface ISerializable
{
	bool Save();
}

interface IValidate
{
	bool Validate();
}

class MyControl : FancyControl, IValidate
{
	public MyControl()
	{
		data = "my grid data";
	}

	public bool Validate()
	{
		Console.WriteLine("Validating...{0}", data);
		return true;
	}
}

class IsOperator1App
{
	public static void Main()
	{
		MyControl myControl = new MyControl();

		ISerializable ser = (ISerializable)myControl;

		// NOTE: This will throw a System.InvalidateCastException
		// because the class does not implement the ISerializable
		// interface.
		bool success = ser.Save();

		Console.WriteLine("The saving of '{0}' was {1}successful", 
						myControl.data, 
						(true == success ? "" : "not "));
	}
}

