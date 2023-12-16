using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ProductDocument.AudiProduct
{
    // 奧迪 抽象 Class
    public abstract class Audi
    {

        private string brand;
        private string type;

        public Audi()
        {
            brand = "Audi";
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
