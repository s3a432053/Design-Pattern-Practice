using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ToastMaker
    {
        public Toast CreateToast()
        {
            return new Toast("Chocolate toast");
        }
    }
}
