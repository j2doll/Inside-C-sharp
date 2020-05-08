using System;

class Temperature
{
    public Temperature(float Temp)
    {
        this.temp = Temp;
    }

    protected float temp;
    public float Temp
    {
        get
        {
            return this.temp;
        }
    }
}

class Celsius : Temperature
{
    public Celsius(float Temp)
        : base(Temp) {}

    public static implicit operator Celsius(float Temp)
    {
        return new Celsius(Temp);
    }

    public static implicit operator Celsius(Fahrenheit F)
    {
        return new Celsius(F.Temp);
    }

    public static implicit operator float(Celsius C)
    {
        return((((C.temp - 32) / 9) * 5));
    }
}

class Fahrenheit : Temperature
{
    public Fahrenheit(float Temp)
        : base(Temp) {}

    public static implicit operator Fahrenheit(float Temp)
    {
        return new Fahrenheit(Temp);
    }

    public static implicit operator Fahrenheit(Celsius C)
    {
        return new Fahrenheit(C.Temp);
    }

    public static implicit operator float(Fahrenheit F)
    {
        return((((F.temp * 9) / 5) + 32));
    }
}

class Temp2App
{
    public static void DisplayTemp(Celsius Temp)
    {
        Console.Write("Conversion of {0} {1} to Fahrenheit = ", 
            Temp.ToString(), Temp.Temp);
        Console.WriteLine((Fahrenheit)Temp);
    }

    public static void DisplayTemp(Fahrenheit Temp)
    {
        Console.Write("Conversion of {0} {1} to Celsius = ", 
            Temp.ToString(), Temp.Temp);
        Console.WriteLine((Celsius)Temp);
    }

    public static void Main()
    {
        Fahrenheit f = new Fahrenheit(98.6F);
        DisplayTemp(f);

        Celsius c = new Celsius(0F);
        DisplayTemp(c);
    }
}
