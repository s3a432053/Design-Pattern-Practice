namespace CompositePattern.SafeShoppingExample
{
    // 購物袋 (Container)
    public class Bags : IArticles
    {
        private string name;
        private List<IArticles> bags = new ();
        public Bags(string name)
        {
            this.name = name;
        }

        public void Add(IArticles articles)
        {
            bags.Add(articles);
        }

        public void Remove(IArticles articles)
        {
            bags.Remove(articles);
        }

        public float Calculation()
        {
            float s = 0;
            foreach (Object bag in bags)
            {
                s += ((IArticles)bag).Calculation();
            }
            return s;
        }

        public void Show()
        {
            foreach (Object bag in bags)
            {
                ((IArticles)bag).Show();
            }
        }
    }
}
