using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Define properties
    // Complete Step 1:............
    public int Value1 { get; set; } = 5;
    private string Value2 { get; set; } = "Private Value";
    public string GetValue2()
    {
        return Value2;
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Define static members
    // Complete Step 2:............
    public static int C;
    static StaticDemo()
    {
        C = 10;
        Console.WriteLine("Static Constructor");
    }
    public static int Method()
    {
        Console.WriteLine("Static Method");
        return 15;
    }
}

// Define MathHelper static class
public static class MathHelper
{
    // Define static methods
    // Complete Step 3:............
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program1
{
    public static void Main()
    {
        // Demonstrate usage
        // Complete Step 4:............
        PropertyDemo p = new PropertyDemo();
        Console.WriteLine(p.Value1);
        Console.WriteLine(p.GetValue2());
        Console.WriteLine(StaticDemo.C);
        Console.WriteLine(StaticDemo.Method());
        Console.WriteLine(MathHelper.Add(2, 3));
    }
}