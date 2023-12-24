namespace CompositePattern.TransparentShoppingExample
{
    // 商品 (Leaf)
    public class Commodity : IArticles
    {
        private string name;
        private int quantity;
        private int unitPrice;
        public Commodity(string name, int quantity, int unitPrice)
        {
            this.name = name;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        // Leaf 不需要 Add 所以不實作
        public void Add(IArticles articles) {}

        // Leaf 不需要 Remove 所以不實作
        public void Remove(IArticles articles) {}

        public float Calculation()
        {
            return quantity * unitPrice;
        }

        public void Show()
        {
            Console.WriteLine($"{name} (quantity: {quantity}, unitPrice: NT {unitPrice})");
        }
    }
}
