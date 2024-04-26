namespace _09_test.Timers;

public class TimerTest {
    static TimerTest() {
        var myClass = new MyClass();
        // 创建一个 Timer，每隔 1 秒触发一次回调
        Timer timer = new Timer(_ => Task.Run(() => myClass.TimerCallback()), null, 0, 1000);

        // 等待程序退出
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}

class MyClass {
    public async Task TimerCallback() {
        // 异步操作
        Console.WriteLine($"TimerCallback started.Time:{DateTime.Now}");
        await YourAsyncMethod();
        Console.WriteLine($"TimerCallback executed.Time:{DateTime.Now}");
    }

    private async Task YourAsyncMethod() {
        // 这里执行异步操作
        await Task.Delay(3000); // 例如，等待1秒
    }
}
