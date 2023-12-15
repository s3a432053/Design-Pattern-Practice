using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ShapeAndColor.Before
{
    public class BlueCircle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw BlueCircle");
        }
    }
}
