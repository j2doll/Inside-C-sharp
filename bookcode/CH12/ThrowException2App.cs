using System;

class ThrowException2App
{
    class CommaDelimitedFile
    {
        protected string fileName;

        public void Open(string fileName)
        {
            this.fileName = fileName;

            // Attempt to open file 
            // and throw exception upon error condition.
            throw new Exception("open failed");
        }

        public bool Read(string record)
        {
            // Code to read file
            return false; // EOF
        }
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("attempting to open file");

            CommaDelimitedFile file = new CommaDelimitedFile();
            file.Open("c:\\test.csv");

            string record = "";

            Console.WriteLine("reading from file");

            while (file.Read(record) == true)
            {
                Console.WriteLine(record);
            }
        
            Console.WriteLine("finished reading file");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

