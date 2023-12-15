using BridgePattern.ShapeAndColor.After.ColorDocument;

namespace BridgePattern.ShapeAndColor.After.ShapeDocument
{
    public abstract class AbstractShape
    {
        protected readonly AbstractColor abstractColor;

        public AbstractShape(AbstractColor abstractColor)
        {
            this.abstractColor = abstractColor;
        }

        public abstract void GetShape();
    }
}
