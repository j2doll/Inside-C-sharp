using System;

class InstCount
{
	public InstCount()
	{
	instanceCount++;
	}

  static public int instanceCount;
	//instanceCount = 0;
}

class AppClass
{
    public static void Main()
    {
		Console.WriteLine(InstCount.instanceCount);

		InstCount ic1 = new InstCount();
		Console.WriteLine(InstCount.instanceCount);

		InstCount ic2 = new InstCount();
		Console.WriteLine(InstCount.instanceCount);
    }
}
