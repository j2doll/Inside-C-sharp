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

class ForEach2App
{
    public static void Main()
    {
        MyArray myArray = new MyArray();

        foreach (string word in myArray.words)
        {
            Console.WriteLine("{0}", word);
        }
    }	
}
