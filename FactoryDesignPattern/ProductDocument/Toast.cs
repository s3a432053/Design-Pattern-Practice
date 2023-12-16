namespace FactoryDesignPattern.ProductDocument
{
    // 繼承 麵包介面 的 吐司
    public class Toast : IBread
    {
        // 吐司名稱
        public string Name { get; set; }
        // 建構子 設定吐司名稱
        public Toast(string name)
        {
            Name = name;
        }
        // 設定吐司名稱
        public string GetBreadName()
        {
            return $"Toast: {Name}";
        }
    }
}
