namespace DecoratorPattern
{
    /// <summary>
    /// 裝飾者
    /// 如果你將其他的裝飾者裝飾到 QQDecorator 上 那麼 QQDecorator 也能成為被裝飾者
    /// </summary>
    public class QQDecorator : BaseDecorator
    {
        public QQDecorator(Notifier comp) : base(comp)
        {
        }

        // 運行要送 Message 給 QQ 邏輯 並且呼叫 BaseDecorator 的 SendMessage 方法
        public override string SendMessage()
        {
            return $"QQDecorator({base.SendMessage()})";
        }
    }
}
