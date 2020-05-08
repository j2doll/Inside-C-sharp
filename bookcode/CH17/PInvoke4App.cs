using System;
using System.Runtime.InteropServices;

class PInvoke4App
{
	[DllImport("user32.dll", CharSet=CharSet.Unicode)]
	static extern int MessageBox(int hWnd, 
                                [MarshalAs(UnmanagedType.LPWStr)]
                                string msg, 
                                [MarshalAs(UnmanagedType.LPWStr)]
                                string caption, 
                                int type);

	public static void Main() 
	{
		MessageBox(0, 
                    "Hello World!", 
                    "This is called from a C# app!", 
                    0);
	}
}

