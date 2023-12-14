using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.InheritanceProblem
{
    // 假鴨
    public class FakeDuck : ProblemParentDuck
    {
        public override void Quack()
        {
            Console.WriteLine($"假鴨 不叫");
        }

        public override void Swim()
        {
            Console.WriteLine($"假鴨 不游泳");
        }

        public override void Fly()
        {
            Console.WriteLine($"假鴨 不飛翔");
        }
    }
}
