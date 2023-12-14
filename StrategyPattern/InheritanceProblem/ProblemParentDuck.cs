namespace StrategyPattern.InheritanceProblem
{
    // 父類別
    public class ProblemParentDuck
    {
        public virtual void Quack()
        {
            Console.WriteLine($"duck says Quack!");
        }

        public virtual void Swim()
        {
            Console.WriteLine($"duck is swimming.");
        }

        public virtual void Fly()
        {
            Console.WriteLine($"duck is flying.");
        }
    }
}
