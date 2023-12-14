using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // BMW 抽象 Class
    public abstract class BMW
    {

        private String brand;
        private String type;

        public BMW()
        {
            this.brand = "BMW";
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
