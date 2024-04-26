using System.Reflection;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        string filePath = "C:\\\\testFile.txt";
        int fileSizeInBytes = 20 * 1024 * 1024; // 20MB

        // 通过使用 FileStream 创建文件并将其大小设置为所需大小
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            fileStream.SetLength(fileSizeInBytes);
        }

        Console.WriteLine("File created successfully.");
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