using System.Security.Cryptography;
using System.Text;

namespace _09_test.Rsa;

public class EncryptTester {
    public void Test() {
        RsaUtil.RefreshReyPair();
        const string message = "Hello World!";

        Console.WriteLine(message);

        // // 使用公钥加密，私钥解密
        // var encryptedMessage = RsaUtil.Encrypt(message);
        // Console.WriteLine(encryptedMessage);
        // var decryptedMessage = RsaUtil.Decrypt(encryptedMessage);
        // Console.WriteLine(decryptedMessage);
        //
        // // 使用私钥签名，公钥验证
        // var signedMessage = RsaUtil.SignData(message);
        // Console.WriteLine(signedMessage);
        // var verifyResult = RsaUtil.VerifyData(message, signedMessage);
        // Console.WriteLine(verifyResult);

        // 使用AES加密
        const string key = "1705311779416000";
        var encryptedMessage = AesUtil.Encrypt(message, key);
        Console.WriteLine(encryptedMessage);
        var decryptedMessage = AesUtil.Decrypt(encryptedMessage, key);
        Console.WriteLine(decryptedMessage);
    }
}

/// <summary>
/// Rsa加密工具类
/// </summary>
public static class RsaUtil {
    private static RsaKeys? RsaKeys { get; set; }

    public static void RefreshReyPair() {
        using var rsa = RSA.Create();
        RsaKeys = new RsaKeys {
            PublicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey()),
            PrivateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey()),
        };
    }

    public static string GetPublicKey() {
        if (RsaKeys == null) {
            throw new ArgumentException("Rsa密钥尚未初始化，请先刷新密钥或导入密钥");
        }
        return RsaKeys.PublicKey;
    }

    public static void ImportKeyPair(RsaKeys rsaKeys) {
        RsaKeys = rsaKeys;
    }

    /// <summary>
    /// 使用公钥加密
    /// </summary>
    /// <param name="data">需要加密的数据</param>
    /// <returns>加密后的数据</returns>
    /// <exception cref="ArgumentException">Rsa密钥尚未初始化，请先刷新密钥或导入密钥</exception>
    public static string Encrypt(string data) {
        if (RsaKeys == null) {
            throw new ArgumentException("Rsa密钥尚未初始化，请先刷新密钥或导入密钥");
        }
        using var rsa = RSA.Create();
        rsa.ImportRSAPublicKey(Convert.FromBase64String(RsaKeys.PublicKey), out _);
        var encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(data), RSAEncryptionPadding.Pkcs1);
        return Convert.ToBase64String(encryptedData);
    }

    /// <summary>
    /// 使用私钥解密
    /// </summary>
    /// <param name="data">需要解密的数据</param>
    /// <returns>解密后的数据</returns>
    /// <exception cref="ArgumentException">Rsa密钥尚未初始化，请先刷新密钥或导入密钥</exception>
    public static string Decrypt(string data) {
        if (RsaKeys == null) {
            throw new ArgumentException("Rsa密钥尚未初始化，请先刷新密钥或导入密钥");
        }
        using var rsa = RSA.Create();
        rsa.ImportRSAPrivateKey(Convert.FromBase64String(RsaKeys.PrivateKey), out _);
        var decryptedData = rsa.Decrypt(Convert.FromBase64String(data), RSAEncryptionPadding.Pkcs1);
        return Encoding.UTF8.GetString(decryptedData);
    }

    /// <summary>
    /// 使用私钥签名数据
    /// </summary>
    /// <param name="data">需要签名的数据</param>
    /// <returns>签名</returns>
    /// <exception cref="ArgumentException">Rsa密钥尚未初始化</exception>
    public static string SignData(string data) {
        if (RsaKeys == null) {
            throw new ArgumentException("Rsa密钥尚未初始化，请先刷新密钥或导入密钥");
        }
        using var rsa = RSA.Create();
        rsa.ImportRSAPrivateKey(Convert.FromBase64String(RsaKeys.PrivateKey), out _);
        var signedData = rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        return Convert.ToBase64String(signedData);
    }

    /// <summary>
    /// 使用公钥验证签名
    /// </summary>
    /// <param name="data">需要验证的数据</param>
    /// <param name="signedData">签名</param>
    /// <returns>校验是否通过</returns>
    /// <exception cref="ArgumentException">Rsa密钥尚未初始化</exception>
    public static bool VerifyData(string data, string signedData) {
        if (RsaKeys == null) {
            throw new ArgumentException("Rsa密钥尚未初始化，请先刷新密钥或导入密钥");
        }
        using var rsa = RSA.Create();
        rsa.ImportRSAPublicKey(Convert.FromBase64String(RsaKeys.PublicKey), out _);
        return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(signedData), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    }
}

/// <summary>
/// AES加密工具类
/// </summary>
public static class AesUtil {
    /// <summary>
    /// 加密
    /// </summary>
    /// <param name="data">需要加密的数据</param>
    /// <param name="key">密钥</param>
    /// <returns>加密后的数据</returns>
    public static string Encrypt(string data, string key) {
        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = new byte[16];
        using var encryptor = aes.CreateEncryptor();
        var encryptedData = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(data), 0, Encoding.UTF8.GetBytes(data).Length);
        return Convert.ToBase64String(encryptedData);
    }

    /// <summary>
    /// 解密
    /// </summary>
    /// <param name="data">需要解密的数据</param>
    /// <param name="key">密钥</param>
    /// <returns>解密后的数据</returns>
    public static string Decrypt(string data, string key) {
        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = new byte[16];
        using var decryptor = aes.CreateDecryptor();
        var decryptedData = decryptor.TransformFinalBlock(Convert.FromBase64String(data), 0, Convert.FromBase64String(data).Length);
        return Encoding.UTF8.GetString(decryptedData);
    }
}

public class RsaKeys {
    public string PublicKey { get; init; } = string.Empty;
    public string PrivateKey { get; init; } = string.Empty;
}
