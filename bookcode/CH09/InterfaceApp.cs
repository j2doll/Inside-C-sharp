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

class InterfaceApp
{
    public static void Main()
    {
        MyControl myControl = new MyControl();

        // Call a function to place the control on 
        // the form. Now, when the editor needs to 
        // validate the control, it can do 
        // the following:
        
        IValidate val = (IValidate)myControl;
        bool success = val.Validate();
	Console.WriteLine("The validation of '{0}' was {1}successful", 
					myControl.data, 
					(true == success ? "" : "not "));
    }
}

