using System;

class File
{
}

class CommaDelimitedFile
{
	public CommaDelimitedFile(String FileNamefileName)
	{
		Console.WriteLine("Constructed with a file name");
	}

	public CommaDelimitedFile(File file)
	{
		Console.WriteLine("Constructed with a file object");
	}
}

class Overloading2App
{
	public static void Main()
	{
		File file = new File();
		CommaDelimitedFile file2 = new CommaDelimitedFile(file);
		CommaDelimitedFile file3 = 
			new CommaDelimitedFile("Some file name");
	}
}
