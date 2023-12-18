using BuilderPattern.ItemDocument;

namespace BuilderPattern.MealExample.MealDocument
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public float GetCost()
        {
            float cost = 0.0f;

            foreach (Item item in items)
            {
                cost += item.price();
            }

            return cost;
        }

        public void ShowItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"Item : {item.name()}, Packing : {item.packing().pack()}, Price : {item.price()}");
            }
        }
    }
}
