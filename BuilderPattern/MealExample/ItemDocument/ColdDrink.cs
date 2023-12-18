using BuilderPattern.MealExample.PackingDocument;

namespace BuilderPattern.ItemDocument
{
    public abstract class ColdDrink : Item
    {
        public abstract string name();
        public Packing packing()
        {
            return new Bottle();
        }
        public abstract float price();
    }
}
