// CommProtocolIGN.cs
// build with the following command line switches
//		csc /t:library CommProtocolIGN.cs /r:CommProtocol.dll
using System;

public class CommProtocolIGN : CommProtocol
{
	public override void DisplayName()
	{
		Console.WriteLine("This is the IBM Global Network");
	}
}

