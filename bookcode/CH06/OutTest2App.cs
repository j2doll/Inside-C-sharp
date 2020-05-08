using System;

class Window
{
	public Window(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	protected int x;
	protected int y;

	public void Move(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public void ChangePos(ref int x, ref int y)
	{
		this.x += x;;
		this.y += y;

		x = this.x;
		y = this.y;
	}
}

class OutTest2App
{
	public static void Main()
	{
		Window wnd = new Window(5, 5);

		int x = 5;
		int y = 5;

		wnd.ChangePos(ref x, ref y);
		Console.WriteLine("{0}, {1}", x, y);

		x = -1;
		y = -1;
		wnd.ChangePos(ref x, ref y);
		Console.WriteLine("{0}, {1}", x, y);
	}
}
