using BridgePattern.ShapeAndColor.After.ColorDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ShapeAndColor.After.ShapeDocument
{
    public class Rectangle : AbstractShape
    {
        public Rectangle(AbstractColor abstractColor) : base(abstractColor)
        {
        }

        public override void GetShape()
        {
            Console.WriteLine($"Draw Rectangle fill with {base.abstractColor.GetColor()}");
        }
    }
}
