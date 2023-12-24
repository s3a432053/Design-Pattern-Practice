namespace CompositePattern.TransparentShoppingExample
{
    // 定義 Container、Leaf 的共同規格
    // 包含 Add、Remove 方法
    public interface IArticles
    {
        public void Add(IArticles articles);
        public void Remove(IArticles articles);
        public float Calculation();
        public void Show();
    }
}
