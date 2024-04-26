using System.Reflection;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        TestClass a = new();
        a.TestProperty = new() { 1, 2, 3 };
        a.TestProperty = a.TestProperty.Concat(new List<int>() { 4, 5, 6 }).ToList();
        Console.WriteLine(a.TestProperty.Count);
    }
}

public class TestClass
{
    

    public List<int>? TestProperty
    {
        get { return JsonSerializer.Deserialize<List<int>>(TestJsonString); }
        set { TestJsonString = JsonSerializer.Serialize(value); }
    }
    
    public string TestJsonString { get; set; } = "[]";
}

public delegate void PerformAction();

public class DelegateExample
{
    private PerformAction _actionToPerform;

    public DelegateExample(PerformAction actionToPerform)
    {
        _actionToPerform = actionToPerform;
    }

    public void DoWork()
    {
        _actionToPerform();
    }
}

public class ActionClass
{
    public void PerformAction()
    {
        Console.WriteLine("Action performed");
    }
}



public class Parent
{
    public string? GetAttribute()
    {
        System.Console.WriteLine(this.GetType().Name);
        return ((MyAttribute?)this.GetType().GetCustomAttribute(typeof(MyAttribute)))?.Test;
    }

}

[MyAttribute("test")]
public class Children : Parent
{
    public string Prop { get; set; } = "test";
}

public class MyAttribute : Attribute
{
    public MyAttribute(string test)
    {
        Test = test;
    }

    public string Test { get; set; }
}