using System;

sealed class MyPoint
{
	public MyPoint(int x, int y)
	{
		this.x = x;
		this.y = y;
	}
	
	private int X;	
	public int x
	{
		get
		{
			return this.X;
		}
		set
		{
			this.X = value;
		}
	}

	private int Y;	
	public int y
	{
		get
		{
			return this.Y;
		}
		set
		{
			this.Y = value;
		}
	}
}

class SealedApp
{
	public static void Main()
	{
		MyPoint pt = new MyPoint(6,16);
		Console.WriteLine("x = {0}, y = {1}", pt.x, pt.y);
	}
}
