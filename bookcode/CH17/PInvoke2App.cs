using System;
using System.Runtime.InteropServices;

class PInvoke2App
{
	[DllImport("user32.dll", EntryPoint="MessageBoxA")]
	static extern int MsgBox(int hWnd, 
                            string msg, 
                            string caption, 
                            int type);

	public static void Main() 
	{
		MsgBox(0, 
                "Hello, World!", 
                "This is called from a C# app!", 
                0);
	}
}

