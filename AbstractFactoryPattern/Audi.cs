using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // 奧迪 抽象 Class
    public abstract class Audi
    {

        private String brand;
        private String type;

        public Audi()
        {
            this.brand = "Audi";
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public String getBrand()
        {
            return brand;
        }

        public String getType()
        {
            return type;
        }
    }
}
