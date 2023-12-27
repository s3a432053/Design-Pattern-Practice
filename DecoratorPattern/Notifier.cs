namespace DecoratorPattern
{
    /// <summary>
    /// 抽象 通知者
    /// 定義 SendMessage 方法
    /// </summary>
    public abstract class Notifier
    {
        public abstract string SendMessage();
    }
}
