using AbstractFactoryPattern.ProductDocument;
using AbstractFactoryPattern.ProductDocument.AudiProduct;
using AbstractFactoryPattern.ProductDocument.BMWProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryDocument
{
    // 吉普車系列 工廠
    public class JeepFactory : AbstractFactory
    {
        // 產生 奧迪 品牌 的 吉普車
        public override Audi createAudi()
        {
            return new AudiJeep();
        }

        // 產生 BMW 品牌 的 吉普車
        public override BMW createBMW()
        {
            return new BMWJeep();
        }
    }
}
