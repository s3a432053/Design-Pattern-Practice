namespace DecoratorPattern
{
    /// <summary>
    /// 使用 Notifier 發送通知 的角色
    /// </summary>
    public class Client
    {
        public void UseNotifierSendMessage(Notifier notifier)
        {
            Console.WriteLine("RESULT: " + notifier.SendMessage());
        }
    }
}
