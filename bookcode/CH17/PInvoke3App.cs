using System;
using System.Runtime.InteropServices;

class PInvoke3App
{
	// CharSet.Ansi will result in a call to MessageBoxA
	// CharSet.Unicode will result in a call to MessageBoxW
	[DllImport("user32.dll", CharSet=CharSet.Ansi)]
	static extern int MessageBox(int hWnd, 
                                string msg, 
                                string caption, 
                                int type);

	public static void Main() 
	{
		MessageBox(0, 
                    "Hello, World!", 
                    "This is called from a C# app!", 
                    0);
	}
}

