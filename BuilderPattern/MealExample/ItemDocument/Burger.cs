using BuilderPattern.MealExample.PackingDocument;

namespace BuilderPattern.ItemDocument
{
    public abstract class Burger : Item
    {
        public abstract string name();
        public Packing packing()
        {
            return new Wrapper();
        }
        public abstract float price();
    }
}
