using System; 
using System.Reflection;
	
public class SingleUseAttribute : Attribute
{
    public SingleUseAttribute(String str)
    {
    }
}
	
	// ERROR: This results in a "duplicate attribute" compiler error.
[SingleUse("abc")]
    [SingleUse("def")]
    class MyClass
{
}
	
class SingleUseApp
{
    public static void Main()
    {
    }
}
