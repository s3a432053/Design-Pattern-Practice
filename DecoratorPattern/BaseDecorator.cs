namespace DecoratorPattern
{
    /// <summary>
    /// 裝飾者 抽象
    /// </summary>
    public abstract class BaseDecorator : Notifier
    {
        protected Notifier _notifier;

        // 將裝飾者 裝飾到 被裝飾者上
        public BaseDecorator(Notifier notifier)
        {
            this._notifier = notifier;
        }

        // 將裝飾者 裝飾到 被裝飾者上
        public void SetNotifier(Notifier notifier)
        {
            this._notifier = notifier;
        }

        // 呼叫 Notifier 實體
        public override string SendMessage()
        {
            if (this._notifier != null)
            {
                return this._notifier.SendMessage();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
