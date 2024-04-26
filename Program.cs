using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using _09_test.FlagsEnum;
using _09_test.Rsa;
using _09_test.Timers;

public class Program {
    public static void Main() {
        // var tester = new EncryptTester();
        // tester.Test();
        // Console.WriteLine(TestEnum.A.ToString());
        // Console.Read();
        var dic = new Dictionary<string, List<int>>();
        dic.Add("1234", new List<int> {
            1,
            2,
            3
        });
        dic.Add("5678", new List<int> {
            4,
            5,
            6
        });

        var str = JsonSerializer.Serialize(dic);
        var dic2 = JsonSerializer.Deserialize<Dictionary<string, List<int>>>(str);
        Console.WriteLine(str);
        Console.Read();
    }
}

public enum TestEnum {
    A = 1,
    B = 2,
    C = 3,
}
