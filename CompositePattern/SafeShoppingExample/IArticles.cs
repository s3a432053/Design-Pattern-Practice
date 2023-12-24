namespace CompositePattern.SafeShoppingExample
{
    // 定義 Container、Leaf 的共同規格
    // 沒有 Add、Remove 方法
    public interface IArticles
    {
        public float Calculation();
        public void Show();
    }
}
