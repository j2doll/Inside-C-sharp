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
        words.Add("bar");
        words.Add("ba");
        words.Add("foo");
    }
}

class ContinueApp
{
    public static void Main()
    {
        MyArray myArray = new MyArray();
        ArrayList dupes = new ArrayList();

        Console.WriteLine("Processing array...");
        for (int i = 0; i < myArray.words.Count; i++)
        {
            for (int j = 0; j < myArray.words.Count; j++)
            {
                if (i == j) continue;

                if (myArray.words[i] == myArray.words[j]
                    && !dupes.Contains(j))
                {
                    dupes.Add(i);
                    Console.WriteLine("'{0}' appears on lines {1} and {2}", 
                        myArray.words[i],
                        i + 1,
                        j + 1);
                }
            }
        }
        Console.WriteLine("There were {0} duplicates found", 
            ((dupes.Count > 0) ? dupes.Count.ToString() : "no"));
    }
}
