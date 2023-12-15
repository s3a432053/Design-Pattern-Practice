using BridgePattern.ShapeAndColor.After.ColorDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ShapeAndColor.After.ShapeDocument
{
    public class Circle : AbstractShape
    {
        public Circle(AbstractColor abstractColor) : base(abstractColor)
        {
        }

        public override void GetShape()
        {
            Console.WriteLine($"Circle fill with {base.abstractColor.GetColor()}");
        }
    }
}
