using System;

class Point
{
	public Point(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public int x;
	public int y;
}

class Chart
{
	public void DrawLine(params Point[] p)
	{
		Console.WriteLine("\nThis method would print a line " + 
		                  "along the following points:");
		for (int i = 0; i < p.GetLength(0); i++)
		{
			Console.WriteLine("{0}, {1}", p[i].x, p[i].y);
		}
	}
}

class VarArgsApp
{
	public static void Main()
	{
		Point p1 = new Point(5,10);
		Point p2 = new Point(5, 15);
		Point p3 = new Point(5, 20);
		
		Chart chart = new Chart();
		chart.DrawLine(p1, p2, p3);		
	}
}