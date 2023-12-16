using FactoryDesignPattern.ProductDocument;

namespace FactoryDesignPattern.FactoryDocument
{
    // 繼承 抽象麵包店 的 吐司工廠
    public class CakeFactory : Bakery
    {
        // 依據 抽象麵包店的規範 宣告 產出 IBread 麵包的 方法
        public override IBread CreateBread(string name)
        {
            Cake cake = new Cake(name);

            // 不同蛋糕有其對應的 形狀
            if (name == "Cheesecake")
            {
                cake.Shape = "square";
            }
            else
            {
                cake.Shape = "round";
            }
            return cake;
        }
    }
}
