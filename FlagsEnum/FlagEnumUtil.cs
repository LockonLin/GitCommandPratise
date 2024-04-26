namespace _09_test.FlagsEnum;

public static class FlagEnumUtil {
    public static string ChangeToString(int decimalValue) {
        var status = (BayStatus)decimalValue;

        var statusFlags = new List<string>();
        foreach (BayStatus value in Enum.GetValues(typeof(BayStatus))) {
            if (status.HasFlag(value)) {
                statusFlags.Add(Enum.GetName(typeof(BayStatus), value));
            }
        }

        return string.Join(", ", statusFlags);
    }
}

[Flags]
public enum BayStatus {
    库位有托盘 = 1 << 0,
    库位无托盘 = 1 << 1,
    库位针床下压 = 1 << 2,
    库位针床弹开 = 1 << 3,
    自动模式 = 1 << 4,
    手动模式 = 1 << 5,
    设备离线 = 1 << 6,
    设备空闲 = 1 << 7,
    设备工作中 = 1 << 8,
    设备停止 = 1 << 9,
    设备暂停 = 1 << 10,
    设备异常 = 1 << 11,
    设备完成 = 1 << 12,
    设备掉电异常 = 1 << 13,
    烟雾报警状态 = 1 << 14,
    烟雾待机状态 = 1 << 15,
    通道失火状态 = 1 << 16,
    通道常温状态 = 1 << 17,
    设备火灾 = 1 << 18
}
