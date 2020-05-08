using System;

class IfTest2App
{
    const string CPlusPlus = "C++";
    const string VisualBasic = "Visual Basic";
    const string Java = "Java";

    public static void Main()
    {
        Console.Write("What is your current language of choice " +
                      "(excluding C#)?");
        string inputString = Console.ReadLine();
			
        if (0 == String.Compare(inputString, CPlusPlus, true))
        {
            Console.WriteLine("\nYou'll have no problem picking " +
                              "up C# !");
        }
        else if (0 == String.Compare(inputString, VisualBasic, true))
        {
            Console.WriteLine("\nYou'll find lots of cool VB features " +
                              "in C# !");
        }
        else if (0 == String.Compare(inputString, Java, true))
        {
            Console.WriteLine("\nYou'll have an easier time " + 
                              "picking up C# <G> !!");
        }
        else
        {
            Console.WriteLine("\nSorry - doesn't compute.");
        }
    }
}
