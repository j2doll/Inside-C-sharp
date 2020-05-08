using System;

class ScreenResolution
{
	public static readonly int ScreenWidth;
	public static readonly int ScreenHeight;

	static ScreenResolution()
	{
		// code would be here to 
		// calculate resolution
		ScreenWidth = 1024;
		ScreenHeight = 768;
	}
}

class ReadOnlyApp
{
	public static void Main()
	{
		Console.WriteLine("Width = {0}, Height = {1}", 
  				  	ScreenResolution.ScreenWidth, 
				  	ScreenResolution.ScreenHeight);
	}
}

