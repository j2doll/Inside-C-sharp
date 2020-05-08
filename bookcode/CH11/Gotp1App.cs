using System;
using System.Collections;

class MyArray
{
    public ArrayList words;
    public const string TerminatingWord = "stop";

    public MyArray()
    {
        words = new ArrayList();

        for (int i = 1; i <= 5; i++) words.Add(i.ToString());
        words.Add(TerminatingWord);
        for (int i = 6; i <= 10; i++) words.Add(i.ToString());
    }
}

class Goto1App
{
    public static void Main()
    {
        MyArray myArray = new MyArray();

        Console.WriteLine("Processing array...");

        foreach (string word in myArray.words)
        {
            if (word == MyArray.TerminatingWord) goto finished;
            Console.WriteLine(word);
        }

        finished:
            Console.WriteLine("Finished processing array");    
    }
}
