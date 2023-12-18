namespace BuilderPattern.ItemDocument
{
    public class VegBurger : Burger
    {
        public override float price()
        {
            return 25.0f;
        }

        public override string name()
        {
            return "Veg Burger";
        }
    }
}
