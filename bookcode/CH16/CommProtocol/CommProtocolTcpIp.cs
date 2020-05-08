// CommProtocolTcpIp.cs
// Build with the following command line switches
//		csc /t:library CommProtocolTcpIp.cs /r:CommProtocol.dll
using System;

public class CommProtocolTcpIp : CommProtocol
{
	public override void DisplayName()
	{
		Console.WriteLine("This is the TCP/IP protocol");
	}
}

