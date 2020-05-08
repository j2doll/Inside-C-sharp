// CommProtocol.cs
// build with the following command line switches
//		csc /t:library commprotocol.cs
public abstract class CommProtocol
{
	public static string DLLMask = "CommProtocol*.dll";
	public abstract void DisplayName();
}

