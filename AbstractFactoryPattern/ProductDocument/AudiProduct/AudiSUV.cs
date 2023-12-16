using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ProductDocument.AudiProduct
{
    // 奧迪 的 SUV
    public class AudiSUV : Audi
    {
        public AudiSUV()
        {
            setType("SUV");
        }
    }
}
