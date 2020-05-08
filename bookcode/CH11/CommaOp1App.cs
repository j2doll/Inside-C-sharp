using System;
	
class CommaOpApp
{
    const int StartChar = 33;
    const int EndChar = 125;
	
    const int CharactersPerLine = 3;
	
    static public void Main()
    {
        for (int i = StartChar, j = 1; i <= EndChar; i++, j++)
        {
            Console.Write("{0}={1} ", i, (char)i);
            if (0 == (j % CharactersPerLine))
            {
                // new line if j is divisible by 3
                Console.WriteLine(""); 
            }
        }
    }
}
