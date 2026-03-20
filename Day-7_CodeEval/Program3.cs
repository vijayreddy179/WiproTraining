using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
class InfoAttribute : Attribute
{
    public string Description { get; }
    public int Version { get; }

    public InfoAttribute(string des, int ver)
    {
        Description = des;
        Version = ver;
    }
}

[Info("This is a sample class.", 1)]
class Demo
{
    [Info("This is a sample property.", 3)]
    public string Name { get; set; }

    [Info("This is a sample method.", 2)]
    public void Show()
    {

    }
}

class Program3
{
    static void Main(string[] args)
    {
        Type type = typeof(Demo);

        InfoAttribute x =
            (InfoAttribute)Attribute.GetCustomAttribute(type, typeof(InfoAttribute));
        Console.WriteLine("Class Description: " + x.Description + ", Version: " + x.Version);

        var method = type.GetMethod("Show");
        InfoAttribute y =
            (InfoAttribute)Attribute.GetCustomAttribute(method, typeof(InfoAttribute));
        Console.WriteLine("Method Description: " + y.Description + ", Version: " + y.Version);

        var property = type.GetProperty("Name");
        InfoAttribute z =
            (InfoAttribute)Attribute.GetCustomAttribute(property, typeof(InfoAttribute));
        Console.WriteLine("Property Description: " + z.Description + ", Version: " + z.Version);
    }
}