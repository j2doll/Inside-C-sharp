using System; 
using System.Reflection;
	
[AttributeUsage(AttributeTargets.All, AllowMultiple=true)]
    public class SingleUseAttribute : Attribute
{
    public SingleUseAttribute(String str)
    {
    }
}
	
[SingleUse("abc")]
    [SingleUse("def")]
    class MyClass
{
}
	
class MultiUseApp
{
    public static void Main()
    {
    }
}
