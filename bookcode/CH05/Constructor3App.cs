using System;

class Constructor3App
{
	Constructor3App()
	{
		Console.WriteLine("I'm the constructor.");
	}

	public static void Main()
	{
		Constructor3App app;
        app = new Constructor3App();
	}
}

