using System;

class GraphicsPackage
{
	public readonly int ScreenWidth;
	public readonly int ScreenHeight;

	public GraphicsPackage()
	{
		this.ScreenWidth = 1024;
		this.ScreenHeight = 768;
	}
}

class ReadOnlyApp
{
	public static void Main()
	{
		GraphicsPackage graphics = new GraphicsPackage();
		Console.WriteLine("Width = {0}, Height = {1}", 
											graphics.ScreenWidth, 
											graphics.ScreenHeight);
	}
}
