using System;
using System.Threading;

class ThreadAbortApp
{
	public static void WorkerThreadMethod()
	{
		try
		{
			Console.WriteLine("Worker thread started");
			
			Console.WriteLine("Worker thread - counting slowly to 10");
			for (int i = 0; i < 10; i++) 
			{
				Thread.Sleep(500);
				Console.Write("{0}...", i);
			}

			Console.WriteLine("Worker thread finished");
		}
		catch(ThreadAbortException e)
		{
		}
		finally
		{
			Console.WriteLine("Worker thread - I can't catch the exception, but I can cleanup");
		}
	}

  public static void Main()
  {	
		ThreadStart worker = new ThreadStart(WorkerThreadMethod);

		Console.WriteLine("Main - Creating worker thread");

		Thread t = new Thread(worker);
		t.Start();

		// Give the worker thread time to start.
		Console.WriteLine("Main - Sleeping for 2 seconds");
		Thread.Sleep(2000);

		Console.WriteLine("\nMain - Aborting worker thread");
		t.Abort();
  }
}

