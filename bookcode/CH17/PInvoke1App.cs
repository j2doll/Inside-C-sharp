using System;
using System.Runtime.InteropServices;

class PInvoke1App
{
	[DllImport("user32.dll")]
	static extern int MessageBoxA(int hWnd, 
                                 string msg,
                                 string caption, 
                                 int type);

	public static void Main() 
	{
		MessageBoxA(0, 
                     "Hello, World!", 
                     "This is called from a C# app!", 
                     0);
	}
}

