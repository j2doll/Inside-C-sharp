using System;
using System.Collections;
	
class MyArray
{
    public ArrayList words;
	
    public MyArray()
    {
        words = new ArrayList();
        words.Add("foo");
        words.Add("bar");
        words.Add("baz");
    }
}
	
class ForEach1App
{
    public static void Main()
    {
        MyArray myArray = new MyArray();
	
        for (int i = 0; i < myArray.words.Count; i++)
        {
            Console.WriteLine("{0}", myArray.words[i]);
        }
    }	
}
