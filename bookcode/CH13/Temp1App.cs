using System;
using System.Text;

struct Celsius
{
    public Celsius(float temp)
    {
        this.temp = temp;
    }

    public static implicit operator Celsius(float temp)
    {
        Celsius c;
        c = new Celsius(temp);
        return(c);
    }

    public static implicit operator float(Celsius c)
    {
        return((((c.temp - 32) / 9) * 5));
    }

    public float temp;
}

struct Fahrenheit
{
    public Fahrenheit(float temp)
    {
        this.temp = temp;
    }

    public static implicit operator Fahrenheit(float temp)
    {
        Fahrenheit f;
        f = new Fahrenheit(temp);
        return(f);
    }

    public static implicit operator float(Fahrenheit f)
    {
        return((((f.temp * 9) / 5) + 32));
    }

    public float temp;
}

class Temp1App
{
    public static void Main()
    {
        float t;

        t=98.6F;
        Console.Write("Conversion of {0} to Celsius = ", t);
        Console.WriteLine((Celsius)t);

        t=0F;
        Console.Write("Conversion of {0} to Farenheit = ", t);
        Console.WriteLine((Fahrenheit)t);
    }
}
