 using System;

class ThrowException3
{
    class FileOps
    {
        public void FileOpen(String fileName)
        {
            // ...
            throw new Exception("Oh bother");
        }

        public void FileRead()
        {
        }
    }

    public static void Main()
    {
        // Code catching exception.
        try
        {
            FileOps fileOps = new FileOps();

            fileOps.FileOpen("c:\\test.txt");
            fileOps.FileRead();
        }
        catch(System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

