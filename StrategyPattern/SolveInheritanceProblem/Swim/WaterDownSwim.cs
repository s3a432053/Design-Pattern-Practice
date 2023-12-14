using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Swim
{
    public class WaterDownSwim : ISwimable
    {
        public void Swim(string name)
        {
            Console.WriteLine($"{name} 水下游泳");
        }
    }
}
