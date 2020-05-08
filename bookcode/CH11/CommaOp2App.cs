using System;
	
class CommaOp2App
{
    const int StartChar = 33;
    const int EndChar = 125;
	
    const int CharsPerLine = 3;
    const int NewLine = 13;
    const int Space = 32;
	
    static public void Main()
    {
        for (int i = StartChar, extra = Space; 
            i <= EndChar; 
            i++, extra = ((0 == (i - (StartChar-1)) % CharsPerLine) 
            ? NewLine : Space))
        {
            Console.Write("{0}={1} {2}", i, (char)i, (char)extra);
        }
    }
}

