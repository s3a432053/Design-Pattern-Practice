using BuilderPattern.MealExample.PackingDocument;

namespace BuilderPattern.ItemDocument
{
    public interface Item
    {
        public string name();
        public Packing packing();
        public float price();
    }
}
