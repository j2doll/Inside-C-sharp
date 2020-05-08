using System;
using System.Threading;

class Database
{
	public void SaveData(string text)
	{
		lock(this)
		{
			Console.WriteLine("Database.SaveData - Started");

			Console.WriteLine("Database.SaveData - Working");
			for (int i = 0; i < 100; i++)
			{
				Console.Write(text);
			}

			Console.WriteLine("\nDatabase.SaveData - Ended");
		}
	}
}

class ThreadLockApp
{
	public static Database db = new Database();

	public static void WorkerThreadMethod1()
	{
		Console.WriteLine("Worker thread #1 - Started");
		
		Console.WriteLine("Worker thread #1 - Calling Database.SaveData");
		db.SaveData("x");

		Console.WriteLine("Worker thread #1 - Returned from Output");
	}

	public static void WorkerThreadMethod2()
	{
		Console.WriteLine("Worker thread #2 - Started");
		
		Console.WriteLine("Worker thread #2 - Calling Database.SaveData");
		db.SaveData("o");

		Console.WriteLine("Worker thread #2 - Returned from Output");
	}

  public static void Main()
  {	
		ThreadStart worker1 = new ThreadStart(WorkerThreadMethod1);
		ThreadStart worker2 = new ThreadStart(WorkerThreadMethod2);

		Console.WriteLine("Main - Creating worker threads");

		Thread t1 = new Thread(worker1);
		Thread t2 = new Thread(worker2);

		t1.Start();
		t2.Start();
  }
}

