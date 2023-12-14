using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // SUV 系列工廠
    public class SUVFactory : AbstractFactory
    {
        // 建立 奧迪 品牌的 SUV
        public override Audi createAudi()
        {
            return new AudiSUV();
        }

        // 建立 BMW 品牌的 SUV
        public override BMW createBMW()
        {
            return new BMWSUV();
        }
    }
}
