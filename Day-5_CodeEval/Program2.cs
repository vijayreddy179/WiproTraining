using System;

public class PropertyDemo
{
    public int p1 { get; set; }
    private string p2 { get; set; }

    public PropertyDemo()
    {
        p1 = 5;
        p2 = "Private Value";
    }

    public string GetPrivateProperty()
    {
        return p2;
    }
}

public class StaticDemo
{
    public static int c;

    static StaticDemo()
    {
        c = 10;
        Console.WriteLine("Static Constructor");
    }

    public static int StaticMethod()
    {
        Console.WriteLine("Static Method");
        return c + 5;
    }
}

public static class MathHelper
{
    public static int Sub(int a, int b)
    {
        return a - b;
    }
}

public class Program2
{
    public static void Main()
    {
        PropertyDemo d = new PropertyDemo();
        Console.WriteLine(d.p1);
        Console.WriteLine(d.GetPrivateProperty());

        Console.WriteLine(StaticDemo.c);
        Console.WriteLine(StaticDemo.StaticMethod());

        Console.WriteLine(MathHelper.Sub(10, 5));
    }
}
