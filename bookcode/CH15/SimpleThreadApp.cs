using System;
using System.Threading;

class SimpleThreadApp
{
	public static void WorkerThreadMethod()
	{
		Console.WriteLine("Worker thread started");
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

