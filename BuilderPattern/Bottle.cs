using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}
