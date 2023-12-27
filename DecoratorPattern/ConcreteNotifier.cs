namespace DecoratorPattern
{
    /// <summary>
    /// Notifier 實體
    /// 被裝飾者
    /// </summary>
    public class ConcreteNotifier : Notifier
    {
        public override string SendMessage()
        {
            return "ConcreteNotifier send Message";
        }
    }
}
