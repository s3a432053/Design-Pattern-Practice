namespace BuilderPattern.ItemDocument
{
    public class Coke : ColdDrink
    {
        public override float price()
        {
            return 30.0f;
        }

        public override string name()
        {
            return "Coke";
        }
    }
}
