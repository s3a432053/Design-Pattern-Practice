using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Swim
{
    public class WaterUpSwim : ISwimable
    {
        public void Swim(string name)
        {
            Console.WriteLine($"{name} 水上游泳");
        }
    }
}
