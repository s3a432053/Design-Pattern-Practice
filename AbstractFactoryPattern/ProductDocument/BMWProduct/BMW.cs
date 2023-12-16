using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ProductDocument.BMWProduct
{
    // BMW 抽象 Class
    public abstract class BMW
    {

        private string brand;
        private string type;

        public BMW()
        {
            brand = "BMW";
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getBrand()
        {
            return brand;
        }

        public string getType()
        {
            return type;
        }
    }
}
