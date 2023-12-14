using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.InheritanceProblem
{
    // 城市鴨子
    public class CityDuck : ProblemParentDuck
    {
        public override void Quack()
        {
            Console.WriteLine($"城市鴨 高音叫");
        }

        public override void Swim()
        {
            Console.WriteLine($"城市鴨 水上游泳");
        }

        public override void Fly()
        {
            Console.WriteLine($"城市鴨 低空飛翔");
        }
    }
}
