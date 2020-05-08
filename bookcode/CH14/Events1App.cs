using System;

class InventoryChangeEventArgs : EventArgs
{
	public InventoryChangeEventArgs(string sku, int change)
	{
		this.sku = sku;
		this.change = change;
	}

	string sku;
	public string Sku
	{
		get
		{
			return sku;
		}
	}

	int change;
	public int Change
	{
		get 
		{
			return change;
		}
	}
}

class InventoryManager // publisher
{
	public delegate void InventoryChangeEventHandler(object source, InventoryChangeEventArgs e);
	public event InventoryChangeEventHandler OnInventoryChangeHandler;

	public void UpdateInventory(string sku, int change)
	{
		if (0 == change)
			return; // no update on null change

		// code to update database would go here

		InventoryChangeEventArgs e = new InventoryChangeEventArgs(sku, change);

		if (OnInventoryChangeHandler != null)
			OnInventoryChangeHandler(this, e);
	}
}

class InventoryWatcher // subscriber
{
	public InventoryWatcher(InventoryManager inventoryManager)
	{
		this.inventoryManager = inventoryManager;
		inventoryManager.OnInventoryChangeHandler 
			+= new InventoryManager.InventoryChangeEventHandler(OnInventoryChange);
	}
	void OnInventoryChange(object source, InventoryChangeEventArgs e)
	{
		int change = e.Change;
		Console.WriteLine("Part '{0}' was {1} by {2} units", 
			e.Sku, 
			change > 0 ? "increased" : "decreased",
			Math.Abs(e.Change));
	}
	InventoryManager inventoryManager;
}

class Events1App
{
	public static void Main()
	{
		InventoryManager inventoryManager = new InventoryManager();

		InventoryWatcher inventoryWatch = new InventoryWatcher(inventoryManager);

		inventoryManager.UpdateInventory("111 006 116", -2);
		inventoryManager.UpdateInventory("111 005 383", 5);
	}
}
