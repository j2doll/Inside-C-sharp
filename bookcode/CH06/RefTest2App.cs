using System;

class Color
{
	public Color()
	{
		this.red = 255;
		this.green = 0;
		this.blue = 125;
	}

	protected int red;
	protected int green;
	protected int blue;

	public void GetColors(ref int red, ref int green, ref int blue)
	{
		red = this.red;
		green = this.green;
		blue = this.blue;
	}
}

class RefTest2App
{
	public static void Main()
	{
		Color color = new Color();
		int red = 0;
		int green = 0;
		int blue = 0;
		color.GetColors(ref red, ref green, ref blue);
		Console.WriteLine("red = {0}, green = {1}, blue = {2}",
red, green, blue);
	}
}
