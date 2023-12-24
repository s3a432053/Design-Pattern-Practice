namespace CompositePattern.SafeShoppingExample
{
    // 安全式 組合模式 執行者
    public class SafeExecutor
    {
        public void ExecutePattern()
        {
            // IArticles 中沒有 Add、Remove 方法 所以這邊宣告為 Bags 類
            Bags bigBag, smallBag;
            Commodity commodity;
            bigBag = new Bags("Big Bag");
            smallBag = new Bags("small Bag");
            commodity = new Commodity("bamboo shoot", 5, 20);
            smallBag.Add(commodity);
            commodity = new Commodity("plate", 5, 40);
            smallBag.Add(commodity);
            commodity = new Commodity("meat", 10, 300);
            smallBag.Add(commodity);
            commodity = new Commodity("seafood", 3, 480);
            smallBag.Add(commodity);
            commodity = new Commodity("barbecue grill", 2, 199);
            bigBag.Add(commodity);
            commodity = new Commodity("charcoal", 2, 399);
            bigBag.Add(commodity);
            bigBag.Add(smallBag);
            Console.WriteLine("list:");
            bigBag.Show();
            float amount = bigBag.Calculation();
            Console.WriteLine("total: NT " + amount);
        }
    }
}
