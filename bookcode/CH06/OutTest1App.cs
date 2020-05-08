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

	public void GetColors(out int red, out int green, out int blue)
	{
		red = this.red;
		green = this.green;
		blue = this.blue;
	}
}

class OutTest1App
{
	public static void Main()
	{
		Color color = new Color();
		int red;
		int green;
		int blue;

		color.GetColors(out red, out green, out blue);
		Console.WriteLine("red = {0}, green = {1}, blue = {2}",
					red, green, blue);
	}
}
