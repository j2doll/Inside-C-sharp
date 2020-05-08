using System;
	
class NestedForApp
{
    const int StartChar = 33;
    const int EndChar = 125;
	const int CharactersPerLine = 3;
	
    static public void Main()
    {
        for (int i = StartChar; i <= EndChar; i+=CharactersPerLine)
        {
            for (int j = 0; j < CharactersPerLine;  j++)
            {
                Console.Write("{0}={1} ", i+j, (char)(i+j));
            }
            Console.WriteLine("");
        }
    }
}
