using DecoratorPattern;

// 宣告 Notifier 的使用者
Client client = new();

// 宣告 Notifier 實體
var notifier = new ConcreteNotifier();
Console.WriteLine("Client: I get a simple Notifier:");
// Client 使用 ConcreteNotifier 來發送通知訊息
client.UseNotifierSendMessage(notifier);
Console.WriteLine();

// 宣告 SMS裝飾者 並將其裝飾在 ConcreteNotifier 上
SMSDecorator smsDecorator = new(notifier);
Console.WriteLine("Client: Now I've got a decorated Notifier:");
// Client 使用 安裝了 SMS裝飾者 的 ConcreteNotifier 來發送通知訊息
client.UseNotifierSendMessage(smsDecorator);

// 宣告 WeChat裝飾者 並將其裝飾在 ConcreteNotifier 上
WeChatDecorator weChatDecorator = new(notifier);
Console.WriteLine("Client: Now I've got a decorated Notifier:");
// Client 使用 安裝了 WeChat裝飾者 的 ConcreteNotifier 來發送通知訊息
client.UseNotifierSendMessage(weChatDecorator);