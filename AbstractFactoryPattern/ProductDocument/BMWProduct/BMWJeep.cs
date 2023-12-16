using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ProductDocument.BMWProduct
{
    // BMW 的 吉普車
    public class BMWJeep : BMW
    {
        public BMWJeep()
        {
            setType("Jeep");
        }
    }
}
