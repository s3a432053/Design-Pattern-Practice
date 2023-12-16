namespace FactoryDesignPattern.ProductDocument
{
    // 麵包 Interface
    public interface IBread
    {
        // 麵包名稱
        string Name { get; set; }
        // 取得麵包名稱
        string GetBreadName();
    }
}
