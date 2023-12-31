﻿using FactoryDesignPattern.ProductDocument;

namespace FactoryDesignPattern.FactoryDocument
{
    // 繼承 抽象麵包店 的 吐司工廠
    public class ToastFactory : Bakery
    {
        // 依據 抽象麵包店的規範 宣告 產出 IBread 麵包的 方法
        public override IBread CreateBread(string name)
        {
            return new Toast(name);
        }
    }
}
