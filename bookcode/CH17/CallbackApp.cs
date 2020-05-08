using System;
using System.Runtime.InteropServices;
using System.Text;

class CallbackApp
{
 [DllImport("user32.dll")]
 static extern int GetWindowText(int hWnd, StringBuilder text, int count);

 delegate bool CallbackDef(int hWnd, int lParam);

 [DllImport("user32.dll")]
 static extern int EnumWindows (CallbackDef callback, int lParam);

 static bool PrintWindow(int hWnd, int lParam)
 {
  StringBuilder text = new StringBuilder(255);
  GetWindowText(hWnd, text, 255);

  Console.WriteLine("Window caption: {0}", text);
  return true;
 }

 static void Main()
 {
  CallbackDef callback = new CallbackDef(PrintWindow);
  EnumWindows(callback, 0);
 }
}

