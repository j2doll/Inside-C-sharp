using System;
using System.Reflection;

public class Apple 
{
    public int nSeeds;
    public void Ripen() 
    {
    }
}

public class TypeOfApp
{
    public static void Main() 
    {
        Type t = typeof(Apple);
        string className = t.ToString();

        Console.WriteLine("\nInformation about the class {0}", 
            className);
      
        Console.WriteLine("\n{0} methods", className);
        Console.WriteLine("-----------------------------");
        MethodInfo[] methods = t.GetMethods();
        foreach (MethodInfo method in methods) 
        {
            Console.WriteLine(method.ToString());
        }

        Console.WriteLine("\nAll {0} members", className);
        Console.WriteLine("-----------------------------");
        MemberInfo[] allMembers = t.GetMembers();
        foreach (MemberInfo member in allMembers) 
        {
            Console.WriteLine(member.ToString());
        }      
    }
}
