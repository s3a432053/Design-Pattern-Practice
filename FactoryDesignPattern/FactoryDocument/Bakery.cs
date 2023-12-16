using FactoryDesignPattern.ProductDocument;

namespace FactoryDesignPattern.FactoryDocument
{
    // 抽象 麵包店
    public abstract class Bakery
    {
        // 規範 只要是麵包店產出的產品 都必須是 IBread
        public abstract IBread CreateBread(string name);
    }
}
