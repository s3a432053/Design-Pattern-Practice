namespace CompositePattern.SafeShoppingExample
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
