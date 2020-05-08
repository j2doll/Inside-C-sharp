using System;

class Part
{
	public Part(string sku)
	{
		this.Sku = sku;

		Random r = new Random(DateTime.Now.Millisecond);
		double d = r.NextDouble() * 100;
		
		this.OnHand = (int)d;
	}

	protected string Sku;
	public string sku
	{
		get
		{
			return this.Sku;
		}
		set
		{
			this.Sku = value;
		}
	}

	protected int OnHand;
	public int onhand
	{
		get
		{
			return this.OnHand;
		}
		set
		{
			this.OnHand = value;
		}
	}
}

class InventoryManager
{
	protected const int MIN_ONHAND = 50;

	public Part[] parts;
	public InventoryManager()
	{
		parts = new Part[5];
		for (int i = 0; i < 5; i++)
		{
			Part part = new Part("Part " + (i + 1));
			parts[i] = part;
			Console.WriteLine("Adding part '{0}' on hand = {1}", part.sku, part.onhand);
		}
	}

  public delegate void OutOfStockExceptionMethod(Part part);
	public void ProcessInventory(OutOfStockExceptionMethod exception)
	{
		Console.WriteLine("\nProcessing inventory...");
		foreach (Part part in parts)
		{
			if (part.onhand < MIN_ONHAND)
			{
				Console.WriteLine("{0} ({1}) is below minimum onhand {2}", 
					part.sku, part.onhand, MIN_ONHAND);

				exception(part);
			}
		}
	}
}

class CompositeDelegate2App
{
	public static void LogEvent(Part part)
	{
		Console.WriteLine("\tlogging event...");
	}

	public static void EmailPurchasingMgr(Part part)
	{
		Console.WriteLine("\temailing Purchasing manager...");
	}

	public static void EmailStoreMgr(Part part)
	{
		Console.WriteLine("\temailing store manager...");
	}

	public static void Main()
	{
		InventoryManager mgr = new InventoryManager();

		InventoryManager.OutOfStockExceptionMethod[] exceptionMethods 
			= new InventoryManager.OutOfStockExceptionMethod[3];

		exceptionMethods[0] = new InventoryManager.OutOfStockExceptionMethod(LogEvent);
		exceptionMethods[1] = new InventoryManager.OutOfStockExceptionMethod(EmailPurchasingMgr);
		exceptionMethods[2] = new InventoryManager.OutOfStockExceptionMethod(EmailStoreMgr);

		int location = 1;

		InventoryManager.OutOfStockExceptionMethod compositeDelegate;

		if (location == 2) 
		{
			compositeDelegate = exceptionMethods[0] + exceptionMethods[1];
		}
		else
		{
			compositeDelegate = exceptionMethods[0] + exceptionMethods[2];
		}

		mgr.ProcessInventory(compositeDelegate);
	}
}
