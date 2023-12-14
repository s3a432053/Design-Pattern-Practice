using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // 抽象工廠
    public abstract class AbstractFactory
    {
        // 生產奧迪
        public abstract Audi createAudi();

        // 生產BMW
        public abstract BMW createBMW();

    }
}
