using System; 

class Control
{
  virtual public void SayHi() 
  {
     Console.WriteLine("base control class");
  }
}

class Button : Control
{
  override public void SayHi() 
  {
    Console.WriteLine("button control");
  }
}

class Combo : Control
{
  override public void SayHi()
  {
    Console.WriteLine("combobox control");
  }
}

class JaggedArrayApp
{
	public static void Main()
	{
    Control[][] controls;
    controls = new Control[2][];

    controls[0] = new Control[3];
    for (int i = 0; i < controls[0].Length; i++)
    {
      controls[0][i] = new Button();
    }

    controls[1] = new Control[2];
    for (int i = 0; i < controls[1].Length; i++)
    {
      controls[1][i] = new Combo();
    }

    for (int i = 0; i < controls.Length;i++)
    {
      for (int j=0;j< controls[i].Length;j++)
      {
        Control control = controls[i][j];
        control.SayHi();
      }
    }    

    string str = Console.ReadLine();
	}
}

