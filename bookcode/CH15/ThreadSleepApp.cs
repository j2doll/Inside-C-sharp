using System;
using System.Threading;

class ThreadSleepApp
{
	public static void WorkerThreadMethod()
	{
		Console.WriteLine("Worker thread started");
		
		int sleepTime = 5000;

		Console.WriteLine("\tsleeping for {0} seconds", sleepTime / 1000);
		Thread.Sleep(sleepTime); // sleep for five seconds
		Console.WriteLine("\twaking up");
	}

  public static void Main()
  {	
		ThreadStart worker = new ThreadStart(WorkerThreadMethod);

		Console.WriteLine("Main - Creating worker thread");

		Thread t = new Thread(worker);
		t.Start();

		Console.WriteLine("Main - Have requested the start of worker thread");
  }
}

