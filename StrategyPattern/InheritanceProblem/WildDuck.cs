using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.InheritanceProblem
{
    public class WildDuck : ProblemParentDuck
    {
        public override void Quack()
        {
            Console.WriteLine($"野鴨 低音叫");
        }

        public override void Swim()
        {
            Console.WriteLine($"野鴨 水下游泳");
        }

        public override void Fly()
        {
            Console.WriteLine($"野鴨 高空飛翔");
        }
    }
}
