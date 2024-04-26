// using System.Xml;
//
// namespace _09_test.XmlUtil;
//
// public class XmlHelper {
//     private const string TestMessage =
//         "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">"
//         + "<s:Body>"
//         + "<CreateAGVTaskResponse xmlns=\"http://tempuri.org/\">"
//         + "<CreateAGVTaskResult>"
//         + "<OrderId>4627</OrderId>"
//         + "<ReturnCode>202</ReturnCode>"
//         + "<ReturnTime>2024-01-16 10:47:18:9959</ReturnTime>"
//         + "<ReturnMessage>非法搬运逻辑(取货站/卸货站不存在)</ReturnMessage>"
//         + "</CreateAGVTaskResult>"
//         + "</CreateAGVTaskResponse>"
//         + "</s:Body>"
//         + "</s:Envelope>";
//
//     public static void Test() {
//         AgvResult result;
//         XmlDocument xmlContent = new();
//
//         xmlContent.LoadXml(TestMessage);
//
//         var body = xmlContent.GetElementsByTagName("CreateAGVTaskResult");
//         var bodyInner = body[0] ?? throw new InvalidOperationException($"Xml contains no return element, xml-{TestMessage}.");
//         if (!DateTimeOffset.TryParse(GetXmlElementValue(bodyInner, "/ReturnTime"), out DateTimeOffset returnTime)) {
//             throw new InvalidOperationException($"解析AGV返回内容中的ReturnTime【{GetXmlElementValue(bodyInner, "/ReturnTime")}】 不是有效的DateTimeOffset值");
//         }
//
//         result = new AgvResult {
//             OrderId = GetXmlElementValue(bodyInner, "/OrderId"),
//             ReturnCode = GetXmlElementValue(bodyInner, "/ReturnCode"),
//             ReturnMessage = GetXmlElementValue(bodyInner, "/ReturnMessage"),
//             ReturnTime = returnTime
//         };
//         return;
//
//         static string GetXmlElementValue(XmlNode parent, string elementName) {
//             var result = parent.(elementName)?.InnerText;
//             if (result == null) {
//                 throw new InvalidOperationException($"解析AGV返回内容失败,不存在名为{elementName}的元素");
//             } else {
//                 return result;
//             }
//         }
//     }
// }
//
// public class AgvResult {
//     public string OrderId { get; set; } = default!;
//     public string ReturnCode { get; set; } = default!;
//     public DateTimeOffset ReturnTime { get; set; }
//     public string ReturnMessage { get; set; } = default!;
// }
